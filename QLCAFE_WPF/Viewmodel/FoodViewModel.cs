using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace QLCAFE_WPF.Viewmodel
{
    public class FoodViewModel : BaseViewModel
    {

        private Dao.DaoTableFood daoTableFood;
        private Dao.DaoFoodCategory daoFoodCategory;
        private Dao.DaoFood daoFood;
        private Dao.DaoBill daoBill;
        private ObservableCollection<Tablefood> obsTablefood;
        private ObservableCollection<Account> obsAccount;
        private ObservableCollection<FoodCategory> obsFoodCategory;
        private ObservableCollection<Food> obsFood;
        private ObservableCollection<Object> obsObject;

        //Cac thanh phan món, loại món, số lượng
        private int idCategory = 0, idTableSelect = 0, quantity = 0, idFood = 0;

        public int IdFood
        {
            get { return idFood; }
            set { idFood = value; OnPropertyChanged(); }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(); }
        }

        public int IdTableSelect
        {
            get { return idTableSelect; }
            set { idTableSelect = value; OnPropertyChanged(); }
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; OnPropertyChanged(); }
        }




        public ObservableCollection<Object> ObsObject
        {
            get { return obsObject; }
            set
            {
                obsObject = value;
                OnPropertyChanged();
            }
        }






        public ObservableCollection<FoodCategory> ObsFoodCategory
        {
            get { return obsFoodCategory; }
            set { obsFoodCategory = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Food> ObsFood
        {
            get { return obsFood; }
            set { obsFood = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Tablefood> ObsTablefood
        {
            get { return obsTablefood; }
            set { obsTablefood = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Account> ObsAccount
        {
            get { return obsAccount; }
            set { obsAccount = value; OnPropertyChanged(); }
        }
        public FoodViewModel()
        {
            //Dao
            daoTableFood = new Dao.DaoTableFood();
            daoFoodCategory = new Dao.DaoFoodCategory();
            daoFood = new Dao.DaoFood();
            daoBill = new Dao.DaoBill();


            obsTablefood = new ObservableCollection<Tablefood>();
            obsTablefood = daoTableFood.getAll();
            obsAccount = new ObservableCollection<Account>();
            obsFood = new ObservableCollection<Food>();
            obsFoodCategory = new ObservableCollection<FoodCategory>();
            obsFoodCategory = daoFoodCategory.getAll();

            obsObject = new ObservableCollection<object>();
            obsObject = new ObservableCollection<Object>(
                (
                        from a in daoBill.getAll()
                        join b in new Dao.DaoTableFood().getAll()
                        on a.id equals b.id
                        join c in new Dao.DaoBillInfo().getAll()
                        on a.id equals c.idBill
                        join d in new Dao.DaoFood().getAll()
                        on c.idFood equals d.id
                        select new
                        {
                            ma = a.id,
                            ten = c.idFood,
                            tenmon = c.Food.name,
                            soluong = c.count1,
                            tien = c.count1 * c.Food.price,
                            tenban = b.name

                        }).ToList());
            //Icommand
            selectedTable = new RelayCommand<Object>(x => true, x =>
            {
                idTableSelect = Convert.ToInt32(x);

                MessageBox.Show(idTableSelect.ToString());

            });
            cbFoodCategoryChangeIndex = new RelayCommand<Object>(x => true, x =>
            {
                var cb = (ComboBoxEdit)x;
                FoodCategory index = (FoodCategory)cb.SelectedItem;
                ObsFood = daoFood.getAllbyCategory(index.id);
                idCategory = index.id;

            });
            dgFoodChangeIndex = new RelayCommand<Object>(x => true, x =>
            {
             //   var cb = (GridControl)x;
              //  FoodCategory index = (FoodCategory)cb.SelectedItem;
                string nameFood ="";
                //= index.name;
                foreach (var item in obsFoodCategory)
                {
                    nameFood += item.name+"\n";
                }
                DXMessageBox.Show(nameFood.ToString());

            });
            addFoodToTable = new RelayCommand<Object>(x => true, x =>
            {
                DXMessageBox.Show(idTableSelect.ToString() + "ID: " + idFood + " ID Loại" + idCategory);
            });

            Addrow = new RelayCommand<Object>(x => true, x =>
            {
                var table = (TableView)x;
                table.AddNewRow();
            });
        }
        //Icommand
        // public ICommand 
        public ICommand selectedTable { get; set; }
        public ICommand cbFoodCategoryChangeIndex { get; set; }
        public ICommand addFoodToTable { get; set; }
        public ICommand dgFoodChangeIndex { get; set; }


        public ICommand Addrow { get; set; }
    }
}
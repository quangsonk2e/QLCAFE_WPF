using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
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
   public class TableAndPaymentViewModel:BaseViewModel
    {
       
       private Dao.DaoTableFood daoTableFood;
       private Dao.DaoFoodCategory daoFoodCategory;
       private Dao.DaoFood daoFood;
        private ObservableCollection<Tablefood> obsTablefood;
        private ObservableCollection<Account> obsAccount;
        private ObservableCollection<FoodCategory> obsFoodCategory;       
        private ObservableCollection<Food> obsFood;
        private ObservableCollection<Object> obsObject;

       //Cac thanh phan món, loại món, số lượng
        private int idCategory = 0, idTableSelect=0, quantity=0, idFood=0;
       



        public ObservableCollection<Object> ObsObject
        {
            get { return obsObject; }
            set { obsObject = value;
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
        public TableAndPaymentViewModel()
        {
            //Dao
            daoTableFood = new Dao.DaoTableFood();
            daoFoodCategory = new Dao.DaoFoodCategory();
            daoFood = new Dao.DaoFood();



            obsTablefood = new ObservableCollection<Tablefood>();
            obsTablefood = daoTableFood.getAll();
            obsAccount = new ObservableCollection<Account>();
            obsFood = new ObservableCollection<Food>();
            obsFoodCategory = new ObservableCollection<FoodCategory>();
            obsFoodCategory = daoFoodCategory.getAll();

            obsObject = new ObservableCollection<object>();
            obsObject = new ObservableCollection<Object>((from a in daoFood.getAll()
                       join  b in new Dao.DaoBill().getAll()
                       on a.id equals b.id
                        select new
                        {
                           ma= a.id,
                            ten=a.name,
                            tenban=b.idTable
                        }).ToList());
            //Icommand
            selectedTable = new RelayCommand<Object>(x => true, x => {
                idTableSelect = Convert.ToInt32(x);

                MessageBox.Show(idTableSelect.ToString());

            });
            cbFoodCategoryChangeIndex = new RelayCommand<Object>(x => true, x => {
                var cb = (ComboBoxEdit)x;
                FoodCategory index = (FoodCategory)cb.SelectedItem;
                ObsFood = daoFood.getAllbyCategory(index.id);
                
            });
            addFoodToTable = new RelayCommand<Object>(x => true, x => {



                DXMessageBox.Show(idTableSelect.ToString());
            });
        }
        //Icommand
        // public ICommand 
        public ICommand selectedTable { get; set; }
        public ICommand cbFoodCategoryChangeIndex { get; set; }
        public ICommand addFoodToTable { get; set; }
    }
}

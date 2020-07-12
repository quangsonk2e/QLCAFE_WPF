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
        private ObservableCollection<Tablefood> obsTablefood;
        private ObservableCollection<Account> obsAccount;
        private ObservableCollection<FoodCategory> obsFoodCategory;       
        private ObservableCollection<Food> obsFood;

        private Dao.DaoTableFood daoTableFood;

   


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
            daoTableFood = new Dao.DaoTableFood();
            obsTablefood = new ObservableCollection<Tablefood>();
            obsTablefood = daoTableFood.getAll();
            obsAccount = new ObservableCollection<Account>();
            obsFood = new ObservableCollection<Food>();
            obsFoodCategory = new ObservableCollection<FoodCategory>();


            //Icommand
            mes = new RelayCommand<Object>(x => true, x => {
                var y=Convert.ToInt32(x);
                MessageBox.Show(y.ToString());

            });
            
        }
        //Icommand
        // public ICommand 
        public ICommand mes { get; set; }
    }
}

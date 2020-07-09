using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLCAFE_WPF.Viewmodel
{
    class TableAndPaymentViewModel:BaseViewModel
    {
        private ObservableCollection<Tablefood> obsTablefood;
        private ObservableCollection<Account> obsAccount;
        private ObservableCollection<FoodCategory> obsFoodCategory;       
        private ObservableCollection<Food> obsFood;

        private Dao.DaoTableFood daoTableFood;

        //Icommand
       // public ICommand 


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
            obsAccount = new ObservableCollection<Account>();
            obsFood = new ObservableCollection<Food>();
            obsFoodCategory = new ObservableCollection<FoodCategory>();
            obsTablefood = new ObservableCollection<Tablefood>();
        }
    }
}

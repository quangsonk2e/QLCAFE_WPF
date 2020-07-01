using QLCAFE_WPF.Dao;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLCAFE_WPF.Viewmodel
{
    class MainViewModel:BaseViewModel
    {
        DaoAccount dao = new DaoAccount();
        private ObservableCollection<Tablefood> tbF;
        private ObservableCollection<Account> obs;
        private Account ac;

        public Account Ac
        {
            get { return ac; }
            set { ac = value; OnPropertyChanged(); }
        }
        private Tablefood tb;

        public Tablefood Tb
        {
            get { return tb; }
            set { tb = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Tablefood> TbF
        {
            get { return tbF; }
            set
            {
                tbF = value;
            OnPropertyChanged();
            }
        }
        public ObservableCollection<Account> Obs
        {
            get { return obs; }
            set { obs = value;
            OnPropertyChanged();
            }
        }
        private string userName;

        public string UserName
        {
            get {return userName;}
            set 
            { 
                userName=value;
            OnPropertyChanged();
                
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
         set 
                    { 
                        password=value;
                    OnPropertyChanged();
                
                    }
        }

        public ICommand login { get; set; }
        
        public ICommand close { get; set; }
        public ICommand Clickbutton { get; set; }

        public MainViewModel()
        {
            obs = new ObservableCollection<Account>();
            obs=dao.getAll();
            ac = obs[1];
            tbF = new ObservableCollection<Tablefood>();
            tbF = new DaoTableFood().getAll();
            login = new RelayCommand<Account>(x => true, x => {
                MessageBox.Show(password+"\n"+userName);
               // Application.Current.Shutdown();
            });
            close = new RelayCommand<Account>(x => true, x =>
            {
                Application.Current.Shutdown();
                // Application.Current.Shutdown();
            });
            Clickbutton = new RelayCommand<object>(x => true, x =>
            {
              
                Account ac1 = dao.getById(Convert.ToInt32(x.ToString()));
                Ac = ac1;

                //Application.Current.Shutdown();
                // Application.Current.Shutdown();
            });
            
        }
        public ObservableCollection<Account> getAccout()
        {
            return dao.getAll();
        }
        
    }
}

using QLCAFE_WPF.Dao;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
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

        public MainViewModel()
        {
           
            login = new RelayCommand<Account>(x => true, x => {
                MessageBox.Show(password+"\n"+userName);
               // Application.Current.Shutdown();
            });
            close = new RelayCommand<Account>(x => true, x =>
            {
                Application.Current.Shutdown();
                // Application.Current.Shutdown();
            });
            
        }
        
    }
}

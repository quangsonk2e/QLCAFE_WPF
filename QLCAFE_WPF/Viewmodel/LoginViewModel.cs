using QLCAFE_WPF.Dao;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using QLCAFE_WPF.View;

namespace QLCAFE_WPF.Viewmodel
{
    class LoginViewModel: BaseViewModel
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
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand close { get; set; }
        
        public LoginViewModel()
        {
           
            login = new RelayCommand<Object>(x => true, x => {
                MainWindow mainWindow = new MainWindow();
                var p = x as Window;
                p.Hide();
                mainWindow.ShowDialog();
                
                //if (dao.checkAccount(new Account{UserName=userName, Password=password})==1)
                //{
                    
                //}

               // Application.Current.Shutdown();
            });
            close = new RelayCommand<object>(x => true, x =>
            {
                Application.Current.Shutdown();
                // Application.Current.Shutdown();
            });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }
        
    }
}

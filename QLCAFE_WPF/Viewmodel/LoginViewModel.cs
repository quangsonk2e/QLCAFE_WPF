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
    class LoginViewModel: ObservableCollection<Login>
    {
        DaoAccount dao = new DaoAccount();
        
        public LoginViewModel()
        {
           
            login = new RelayCommand<Account>(x => true, x => { 
            
            });
        }
        public ICommand login { get; set; }
    }
}

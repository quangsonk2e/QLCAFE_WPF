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
    class LoginViewModel
    {
        public LoginViewModel()
        {
            MessageBox.Show("fdfdf");
            login = new RelayCommand<Account>(x => true, x => { 
            
            });
        }
        public ICommand login { get; set; }
    }
}

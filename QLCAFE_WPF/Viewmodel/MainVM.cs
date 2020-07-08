using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLCAFE_WPF.Viewmodel
{
    public class MainVM:BaseViewModel
    {
        public ICommand them { get; set; }
        public MainVM()
        {
            them = new RelayCommand<Object>(x=>true,x=>{
                var tabs = (DXTabControl)x;
                DXTabItem a = new DXTabItem();
                a.Content = new UserCT.UserControl1();
                tabs.Items.Add(a);
            
            }
                
                );
        }
    }
}

using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
                ItemCollection itemstab = tabs.Items;
                foreach (DXTabItem item in itemstab)
                {
                    
                    DXMessageBox.Show(item.Header.ToString());
                }
                DXTabItem a = new DXTabItem();
                a.Header = "Tab mới";
                a.Content = new UserCT.UCTableAndPayment();
                tabs.Items.Add(a);
               // DXMessageBox.Show("fdfdf");
                
            }
                
                );
        }
    }
}

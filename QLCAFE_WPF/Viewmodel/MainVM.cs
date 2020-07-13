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
                
               string header="Tab mới";
                var tabs = (DXTabControl)x;
                ItemCollection itemstab = tabs.Items;
                List<string> headerTab=new List<string>();
                int i = 0;
                foreach (DXTabItem item in itemstab)
                {
                    if (header == item.Header.ToString()) {
                        tabs.SelectTabItem(i);
                        headerTab.Add(item.Header.ToString());
                    }
                    i++;
                  //  headerTab.Add();
                    
                }
                if (!headerTab.Contains(header))
                {
                    DXTabItem a = new DXTabItem();
                    a.Header = "Tab mới";
                    a.Content = new UserCT.UCTableAndPayment();
                    tabs.Items.Add(a);
                    
                }
               // DXMessageBox.Show("fdfdf");
                
            }
                
                );
        }
    }
}

using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    class DaoAccount
    {
        QLCafe qlcafe;
        public DaoAccount()
        {
            qlcafe = new QLCafe();
        }
        public int insert(Account account)
        {
            qlcafe.Accounts.Add(account);
            qlcafe.SaveChanges();
            return 1;
        }
        public ObservableCollection<Account> getAll()
        {

            return new ObservableCollection<Account>(qlcafe.Accounts.ToList());
        }
        public int checkAccount(Account account)
        {
            var user=qlcafe.Accounts.FirstOrDefault(x => x.UserName == account.UserName && x.Password == account.Password);
            if (user != null)
            {
                return 1;
            }
            return 0;
        }
    }
}

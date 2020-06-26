using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
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
    }
}

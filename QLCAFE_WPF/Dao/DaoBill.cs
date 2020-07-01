using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    class DaoBill
    {
         QLCafe qlcafe;
        public DaoBill()
        {
            qlcafe = new QLCafe();
        }
        public int insert(Bill Bill)
        {
            qlcafe.Bills.Add(Bill);
            qlcafe.SaveChanges();
            return Bill.id;
        }
        public Bill getById(int id)
        {
            return qlcafe.Bills.FirstOrDefault(x => x.id == id); 
        }
        public ObservableCollection<Bill> getAll()
        {

            return new ObservableCollection<Bill>(qlcafe.Bills.ToList());
        }
        public int delete(Bill Bill)
        {
            qlcafe.Bills.Remove(Bill);
            qlcafe.SaveChanges();
            return 1;
        }
        public int update(Bill Bill)
        {
            var bl = qlcafe.Bills.FirstOrDefault(x => x.id == Bill.id);
            bl.BillInfoes = Bill.BillInfoes;
            bl.DateCheckIn = Bill.DateCheckIn;
            bl.DateCheckOut = Bill.DateCheckOut;
            bl.idTable = Bill.idTable;
            bl.status = Bill.status;
            bl.Tablefood = Bill.Tablefood;
            qlcafe.SaveChanges();
            return 1;
        }
    }
}

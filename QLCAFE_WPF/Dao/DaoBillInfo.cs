using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    
    class DaoBillInfo
    {
        QLCafe qlcafe;
        public DaoBillInfo()
        {
            qlcafe = new QLCafe();
        }
        public int insert(BillInfo BillInfo)
        {
            qlcafe.BillInfoes.Add(BillInfo);
            qlcafe.SaveChanges();
            return BillInfo.id;
        }
        public BillInfo getById(int id)
        {
            return qlcafe.BillInfoes.FirstOrDefault(x => x.id == id);
        }
        public ObservableCollection<BillInfo> getAll()
        {

            return new ObservableCollection<BillInfo>(qlcafe.BillInfoes.ToList());
        }
        public int delete(BillInfo BillInfo)
        {
            qlcafe.BillInfoes.Remove(BillInfo);
            qlcafe.SaveChanges();
            return 1;
        }
        public int update(BillInfo BillInfo)
        {
            var blInfo = qlcafe.BillInfoes.FirstOrDefault(x => x.id == BillInfo.id);
           
            qlcafe.SaveChanges();
            return 1;
        }
    }
}

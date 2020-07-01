using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    
    class DaoTableFood
    {
        QLCafe qlcafe;
        public DaoTableFood()
        {
            qlcafe = new QLCafe();
        }
        public int insert(Tablefood Tablefood)
        {
            qlcafe.Tablefoods.Add(Tablefood);
            qlcafe.SaveChanges();
            return Tablefood.id;
        }
        public Tablefood getById(int id)
        {
            return qlcafe.Tablefoods.FirstOrDefault(x => x.id == id);
        }
        public ObservableCollection<Tablefood> getAll()
        {

            return new ObservableCollection<Tablefood>(qlcafe.Tablefoods.ToList());
        }
        public int delete(Tablefood Tablefood)
        {
            qlcafe.Tablefoods.Remove(Tablefood);
            qlcafe.SaveChanges();
            return 1;
        }
        public int update(Tablefood Tablefood)
        {
            var tF = qlcafe.Tablefoods.FirstOrDefault(x => x.id == Tablefood.id);
            tF.Bills = Tablefood.Bills;
            tF.name = Tablefood.name;
            tF.status = Tablefood.status;
            qlcafe.SaveChanges();
            return 1;
        }
    }
}

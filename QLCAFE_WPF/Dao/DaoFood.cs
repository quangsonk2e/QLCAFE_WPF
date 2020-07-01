using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    class DaoFood
    {
        QLCafe qlcafe;
        public DaoFood()
        {
            qlcafe = new QLCafe();
        }
        public int insert(Food Food)
        {
            qlcafe.Foods.Add(Food);
            qlcafe.SaveChanges();
            return Food.id;
        }
        public Food getById(int id)
        {
            return qlcafe.Foods.FirstOrDefault(x => x.id == id);
        }
        public ObservableCollection<Food> getAll()
        {

            return new ObservableCollection<Food>(qlcafe.Foods.ToList());
        }
        public int delete(Food Food)
        {
            qlcafe.Foods.Remove(Food);
            qlcafe.SaveChanges();
            return 1;
        }
        public int update(Food Food)
        {
            var fd = qlcafe.Foods.FirstOrDefault(x => x.id == Food.id);
            fd.BillInfoes = Food.BillInfoes;
            fd.idCategory = Food.idCategory;
                 fd.name=Food.name;
                      fd.price=Food.price;
            qlcafe.SaveChanges();
            return 1;
        }
    }
}

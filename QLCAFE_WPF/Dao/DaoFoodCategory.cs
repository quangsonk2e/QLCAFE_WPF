using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_WPF.Dao
{
    class DaoFoodCategory
    {
        QLCafe qlcafe;
        public DaoFoodCategory()
        {
            qlcafe = new QLCafe();
        }
        public int insert(FoodCategory FoodCategory)
        {
            qlcafe.FoodCategories.Add(FoodCategory);
            qlcafe.SaveChanges();
            return FoodCategory.id;
        }
        public FoodCategory getById(int id)
        {
            return qlcafe.FoodCategories.FirstOrDefault(x => x.id == id);
        }
        public ObservableCollection<FoodCategory> getAll()
        {

            return new ObservableCollection<FoodCategory>(qlcafe.FoodCategories.ToList());
        }
        public int delete(FoodCategory FoodCategory)
        {
            qlcafe.FoodCategories.Remove(FoodCategory);
            qlcafe.SaveChanges();
            return 1;
        }
        public int update(FoodCategory FoodCategory)
        {
            var fc = qlcafe.FoodCategories.FirstOrDefault(x => x.id == FoodCategory.id);
            fc.name = FoodCategory.name;
            qlcafe.SaveChanges();
            return 1;
        }
    }
}

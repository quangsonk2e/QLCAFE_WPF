using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLCAFE_WPF.View.QLCafeDataModel {

    /// <summary>
    /// A QLCafeUnitOfWork instance that represents the run-time implementation of the IQLCafeUnitOfWork interface.
    /// </summary>
    public class QLCafeUnitOfWork : DbUnitOfWork<QLCafe>, IQLCafeUnitOfWork {

        public QLCafeUnitOfWork(Func<QLCafe> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Account, int> IQLCafeUnitOfWork.Accounts {
            get { return GetRepository(x => x.Set<Account>(), (Account x) => x.id); }
        }

        IRepository<BillInfo, int> IQLCafeUnitOfWork.BillInfoes {
            get { return GetRepository(x => x.Set<BillInfo>(), (BillInfo x) => x.id); }
        }

        IRepository<Bill, int> IQLCafeUnitOfWork.Bills {
            get { return GetRepository(x => x.Set<Bill>(), (Bill x) => x.id); }
        }

        IRepository<Tablefood, int> IQLCafeUnitOfWork.Tablefoods {
            get { return GetRepository(x => x.Set<Tablefood>(), (Tablefood x) => x.id); }
        }

        IRepository<Food, int> IQLCafeUnitOfWork.Foods {
            get { return GetRepository(x => x.Set<Food>(), (Food x) => x.id); }
        }

        IRepository<FoodCategory, int> IQLCafeUnitOfWork.FoodCategories {
            get { return GetRepository(x => x.Set<FoodCategory>(), (FoodCategory x) => x.id); }
        }
    }
}

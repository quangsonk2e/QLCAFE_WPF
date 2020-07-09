using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLCAFE_WPF.View.QLCafeDataModel {

    /// <summary>
    /// A QLCafeDesignTimeUnitOfWork instance that represents the design-time implementation of the IQLCafeUnitOfWork interface.
    /// </summary>
    public class QLCafeDesignTimeUnitOfWork : DesignTimeUnitOfWork, IQLCafeUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the QLCafeDesignTimeUnitOfWork class.
        /// </summary>
        public QLCafeDesignTimeUnitOfWork() {
        }

        IRepository<Account, int> IQLCafeUnitOfWork.Accounts {
            get { return GetRepository((Account x) => x.id); }
        }

        IRepository<BillInfo, int> IQLCafeUnitOfWork.BillInfoes {
            get { return GetRepository((BillInfo x) => x.id); }
        }

        IRepository<Bill, int> IQLCafeUnitOfWork.Bills {
            get { return GetRepository((Bill x) => x.id); }
        }

        IRepository<Tablefood, int> IQLCafeUnitOfWork.Tablefoods {
            get { return GetRepository((Tablefood x) => x.id); }
        }

        IRepository<Food, int> IQLCafeUnitOfWork.Foods {
            get { return GetRepository((Food x) => x.id); }
        }

        IRepository<FoodCategory, int> IQLCafeUnitOfWork.FoodCategories {
            get { return GetRepository((FoodCategory x) => x.id); }
        }
    }
}

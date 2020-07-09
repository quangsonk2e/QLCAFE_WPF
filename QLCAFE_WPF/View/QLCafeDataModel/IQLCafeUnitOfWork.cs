using DevExpress.Mvvm.DataModel;
using QLCAFE_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLCAFE_WPF.View.QLCafeDataModel {

    /// <summary>
    /// IQLCafeUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IQLCafeUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Account entities repository.
        /// </summary>
		IRepository<Account, int> Accounts { get; }
        
        /// <summary>
        /// The BillInfo entities repository.
        /// </summary>
		IRepository<BillInfo, int> BillInfoes { get; }
        
        /// <summary>
        /// The Bill entities repository.
        /// </summary>
		IRepository<Bill, int> Bills { get; }
        
        /// <summary>
        /// The Tablefood entities repository.
        /// </summary>
		IRepository<Tablefood, int> Tablefoods { get; }
        
        /// <summary>
        /// The Food entities repository.
        /// </summary>
		IRepository<Food, int> Foods { get; }
        
        /// <summary>
        /// The FoodCategory entities repository.
        /// </summary>
		IRepository<FoodCategory, int> FoodCategories { get; }
    }
}

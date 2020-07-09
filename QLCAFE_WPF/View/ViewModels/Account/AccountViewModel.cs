using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLCAFE_WPF.View.QLCafeDataModel;
using QLCAFE_WPF.View.Common;
using QLCAFE_WPF.Model;

namespace QLCAFE_WPF.View.ViewModels {

    /// <summary>
    /// Represents the single Account object view model.
    /// </summary>
    public partial class AccountViewModel : SingleObjectViewModel<Account, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AccountViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AccountViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts, x => x.DisplayName) {
                }



    }
}

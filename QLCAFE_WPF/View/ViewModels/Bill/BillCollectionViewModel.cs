using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLCAFE_WPF.View.QLCafeDataModel;
using QLCAFE_WPF.View.Common;
using QLCAFE_WPF.Model;

namespace QLCAFE_WPF.View.ViewModels {

    /// <summary>
    /// Represents the Bills collection view model.
    /// </summary>
    public partial class BillCollectionViewModel : CollectionViewModel<Bill, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BillCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BillCollectionViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BillCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BillCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BillCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BillCollectionViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Bills) {
        }
    }
}
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
    /// Represents the single Bill object view model.
    /// </summary>
    public partial class BillViewModel : SingleObjectViewModel<Bill, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BillViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BillViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BillViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BillViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BillViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BillViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Bills, x => x.id) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillInfoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillInfo> LookUpBillInfoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BillViewModel x) => x.LookUpBillInfoes,
                    getRepositoryFunc: x => x.BillInfoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Tablefoods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Tablefood> LookUpTablefoods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BillViewModel x) => x.LookUpTablefoods,
                    getRepositoryFunc: x => x.Tablefoods);
            }
        }


        /// <summary>
        /// The view model for the BillBillInfoes detail collection.
        /// </summary>
        public CollectionViewModelBase<BillInfo, BillInfo, int, IQLCafeUnitOfWork> BillBillInfoesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BillViewModel x) => x.BillBillInfoesDetails,
                    getRepositoryFunc: x => x.BillInfoes,
                    foreignKeyExpression: x => x.idBill,
                    navigationExpression: x => x.Bill);
            }
        }
    }
}

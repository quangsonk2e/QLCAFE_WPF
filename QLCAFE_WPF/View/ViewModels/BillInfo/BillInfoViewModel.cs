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
    /// Represents the single BillInfo object view model.
    /// </summary>
    public partial class BillInfoViewModel : SingleObjectViewModel<BillInfo, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BillInfoViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BillInfoViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BillInfoViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BillInfoViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BillInfoViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BillInfoViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BillInfoes, x => x.id) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bills for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bill> LookUpBills {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BillInfoViewModel x) => x.LookUpBills,
                    getRepositoryFunc: x => x.Bills);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Foods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Food> LookUpFoods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BillInfoViewModel x) => x.LookUpFoods,
                    getRepositoryFunc: x => x.Foods);
            }
        }

    }
}

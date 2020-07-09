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
    /// Represents the single Food object view model.
    /// </summary>
    public partial class FoodViewModel : SingleObjectViewModel<Food, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FoodViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FoodViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FoodViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FoodViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FoodViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FoodViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Foods, x => x.name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillInfoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillInfo> LookUpBillInfoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FoodViewModel x) => x.LookUpBillInfoes,
                    getRepositoryFunc: x => x.BillInfoes);
            }
        }


        /// <summary>
        /// The view model for the FoodBillInfoes detail collection.
        /// </summary>
        public CollectionViewModelBase<BillInfo, BillInfo, int, IQLCafeUnitOfWork> FoodBillInfoesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (FoodViewModel x) => x.FoodBillInfoesDetails,
                    getRepositoryFunc: x => x.BillInfoes,
                    foreignKeyExpression: x => x.idFood,
                    navigationExpression: x => x.Food);
            }
        }
    }
}

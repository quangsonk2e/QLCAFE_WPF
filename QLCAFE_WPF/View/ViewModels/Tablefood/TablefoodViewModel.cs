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
    /// Represents the single Tablefood object view model.
    /// </summary>
    public partial class TablefoodViewModel : SingleObjectViewModel<Tablefood, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TablefoodViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TablefoodViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TablefoodViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TablefoodViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TablefoodViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TablefoodViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Tablefoods, x => x.name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bills for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bill> LookUpBills {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TablefoodViewModel x) => x.LookUpBills,
                    getRepositoryFunc: x => x.Bills);
            }
        }


        /// <summary>
        /// The view model for the TablefoodBills detail collection.
        /// </summary>
        public CollectionViewModelBase<Bill, Bill, int, IQLCafeUnitOfWork> TablefoodBillsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TablefoodViewModel x) => x.TablefoodBillsDetails,
                    getRepositoryFunc: x => x.Bills,
                    foreignKeyExpression: x => x.idTable,
                    navigationExpression: x => x.Tablefood);
            }
        }
    }
}

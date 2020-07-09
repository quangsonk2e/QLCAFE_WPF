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
    /// Represents the single FoodCategory object view model.
    /// </summary>
    public partial class FoodCategoryViewModel : SingleObjectViewModel<FoodCategory, int, IQLCafeUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FoodCategoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FoodCategoryViewModel Create(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FoodCategoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FoodCategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FoodCategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FoodCategoryViewModel(IUnitOfWorkFactory<IQLCafeUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FoodCategories, x => x.name) {
                }



    }
}

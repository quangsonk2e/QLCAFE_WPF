using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using QLCAFE_WPF.View.Localization;using QLCAFE_WPF.View.QLCafeDataModel;

namespace QLCAFE_WPF.View.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the QLCafe data model.
    /// </summary>
    public partial class QLCafeViewModel : DocumentsViewModel<QLCafeModuleDescription, IQLCafeUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of QLCafeViewModel as a POCO view model.
        /// </summary>
        public static QLCafeViewModel Create() {
            return ViewModelSource.Create(() => new QLCafeViewModel());
        }

		        static QLCafeViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<QLCafeMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the QLCafeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QLCafeViewModel type without the POCO proxy factory.
        /// </summary>
        protected QLCafeViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override QLCafeModuleDescription[] CreateModules() {
			return new QLCafeModuleDescription[] {
                new QLCafeModuleDescription(QLCafeResources.AccountPlural, "AccountCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Accounts)),
                new QLCafeModuleDescription(QLCafeResources.BillInfoPlural, "BillInfoCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.BillInfoes)),
                new QLCafeModuleDescription(QLCafeResources.BillPlural, "BillCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Bills)),
                new QLCafeModuleDescription(QLCafeResources.TablefoodPlural, "TablefoodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Tablefoods)),
                new QLCafeModuleDescription(QLCafeResources.FoodPlural, "FoodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Foods)),
                new QLCafeModuleDescription(QLCafeResources.FoodCategoryPlural, "FoodCategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FoodCategories)),
			};
        }
                	}

    public partial class QLCafeModuleDescription : ModuleDescription<QLCafeModuleDescription> {
        public QLCafeModuleDescription(string title, string documentType, string group, Func<QLCafeModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}
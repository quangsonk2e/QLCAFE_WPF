using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using QLCAFE_WPF.Model;
using System;
using System.Collections;
using System.Linq;

namespace QLCAFE_WPF.View.QLCafeDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<IQLCafeUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<IQLCafeUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
			if(isInDesignTime)
                return new DesignTimeUnitOfWorkFactory<IQLCafeUnitOfWork>(() => new QLCafeDesignTimeUnitOfWork());
            return new DbUnitOfWorkFactory<IQLCafeUnitOfWork>(() => new QLCafeUnitOfWork(() => new QLCafe()));
        }
    }
}
using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using DevExpressWalkthrough.Common.Utils;
using DevExpressWalkthrough.Common.DataModel;
using DevExpressWalkthrough.Common.DataModel.DesignTime;
using DevExpressWalkthrough.Common.DataModel.EntityFramework;
using DevExpressWalkthrough;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace DevExpressWalkthrough.NorthwindEntitiesDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {
        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
            if(isInDesignTime)
                return new DesignTimeUnitOfWorkFactory<INorthwindEntitiesUnitOfWork>(() => new NorthwindEntitiesDesignTimeUnitOfWork());
            return new DbUnitOfWorkFactory<INorthwindEntitiesUnitOfWork>(() => new NorthwindEntitiesUnitOfWork(() => new NorthwindEntities()));
        }
    }
}
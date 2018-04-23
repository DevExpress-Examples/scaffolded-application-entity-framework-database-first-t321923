using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Scaffolding.DatabaseFirst.NorthwindEntitiesDataModel;
using Scaffolding.DatabaseFirst.Common;
using Scaffolding.DatabaseFirst;

namespace Scaffolding.DatabaseFirst.ViewModels {

    /// <summary>
    /// Represents the single Region object view model.
    /// </summary>
    public partial class RegionViewModel : SingleObjectViewModel<Region, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RegionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RegionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RegionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RegionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RegionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RegionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Regions, x => x.RegionDescription) {
        }


        /// <summary>
        /// The view model that contains a look-up collection of Territories for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Territory> LookUpTerritories
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RegionViewModel x) => x.LookUpTerritories,
                    getRepositoryFunc: x => x.Territories);
            }
        }


        /// <summary>
        /// The view model for the RegionTerritories detail collection.
        /// </summary>
        public CollectionViewModelBase<Territory, Territory, string, INorthwindEntitiesUnitOfWork> RegionTerritoriesDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (RegionViewModel x) => x.RegionTerritoriesDetails,
                    getRepositoryFunc: x => x.Territories,
                    foreignKeyExpression: x => x.RegionID,
                    navigationExpression: x => x.Region);
            }
        }
    }
}

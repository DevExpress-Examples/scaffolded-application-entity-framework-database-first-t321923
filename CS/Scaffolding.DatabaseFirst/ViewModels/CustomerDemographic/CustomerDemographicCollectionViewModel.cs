using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Scaffolding.DatabaseFirst.NorthwindEntitiesDataModel;
using Scaffolding.DatabaseFirst.Common;
using Scaffolding.DatabaseFirst;

namespace Scaffolding.DatabaseFirst.ViewModels {

    /// <summary>
    /// Represents the CustomerDemographics collection view model.
    /// </summary>
    public partial class CustomerDemographicCollectionViewModel : CollectionViewModel<CustomerDemographic, string, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerDemographicCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerDemographicCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerDemographicCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerDemographicCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerDemographicCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerDemographicCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomerDemographics) {
        }
    }
}
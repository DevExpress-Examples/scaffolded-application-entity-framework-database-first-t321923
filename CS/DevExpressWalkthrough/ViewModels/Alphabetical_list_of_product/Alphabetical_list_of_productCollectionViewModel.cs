using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpressWalkthrough.Common.Utils;
using DevExpressWalkthrough.NorthwindEntitiesDataModel;
using DevExpressWalkthrough.Common.DataModel;
using DevExpressWalkthrough;
using DevExpressWalkthrough.Common.ViewModel;

namespace DevExpressWalkthrough.ViewModels {
    /// <summary>
    /// Represents the Alphabetical_list_of_products collection view model.
    /// </summary>
    public partial class Alphabetical_list_of_productCollectionViewModel : ReadOnlyCollectionViewModel<Alphabetical_list_of_product, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Alphabetical_list_of_productCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Alphabetical_list_of_productCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Alphabetical_list_of_productCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Alphabetical_list_of_productCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Alphabetical_list_of_productCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Alphabetical_list_of_productCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Alphabetical_list_of_products) {
        }
    }
}
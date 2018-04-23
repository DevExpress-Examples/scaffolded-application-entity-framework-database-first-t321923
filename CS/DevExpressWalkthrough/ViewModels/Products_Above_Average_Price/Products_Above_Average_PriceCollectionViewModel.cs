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
    /// Represents the Products_Above_Average_Prices collection view model.
    /// </summary>
    public partial class Products_Above_Average_PriceCollectionViewModel : ReadOnlyCollectionViewModel<Products_Above_Average_Price, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Products_Above_Average_PriceCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Products_Above_Average_PriceCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Products_Above_Average_PriceCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Products_Above_Average_PriceCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Products_Above_Average_PriceCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Products_Above_Average_PriceCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products_Above_Average_Prices) {
        }
    }
}
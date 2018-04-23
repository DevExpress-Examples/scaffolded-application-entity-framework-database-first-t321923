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
    /// Represents the Order_Subtotals collection view model.
    /// </summary>
    public partial class Order_SubtotalCollectionViewModel : ReadOnlyCollectionViewModel<Order_Subtotal, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Order_SubtotalCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Order_SubtotalCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Order_SubtotalCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Order_SubtotalCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Order_SubtotalCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Order_SubtotalCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Order_Subtotals) {
        }
    }
}
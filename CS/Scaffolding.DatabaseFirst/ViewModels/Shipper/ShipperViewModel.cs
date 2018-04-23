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
    /// Represents the single Shipper object view model.
    /// </summary>
    public partial class ShipperViewModel : SingleObjectViewModel<Shipper, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ShipperViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ShipperViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ShipperViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ShipperViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ShipperViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ShipperViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Shippers, x => x.CompanyName) {
        }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ShipperViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the ShipperOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, INorthwindEntitiesUnitOfWork> ShipperOrdersDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ShipperViewModel x) => x.ShipperOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.ShipVia,
                    navigationExpression: x => x.Shipper);
            }
        }
    }
}

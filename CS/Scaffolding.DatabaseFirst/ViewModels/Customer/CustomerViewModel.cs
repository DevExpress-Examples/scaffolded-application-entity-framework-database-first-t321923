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
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, string, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.CompanyName) {
        }


        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
            CustomerDemographicsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.CustomerDemographics, x => x.CustomerDemographics);
        }
        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }

        public virtual AddRemoveDetailEntitiesViewModel<Customer, String, CustomerDemographic, String, INorthwindEntitiesUnitOfWork> CustomerDemographicsDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the CustomerOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, INorthwindEntitiesUnitOfWork> CustomerOrdersDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.CustomerID,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}

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
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products, x => x.ProductName) {
        }


        /// <summary>
        /// The view model that contains a look-up collection of Order_Details for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order_Detail> LookUpOrder_Details
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpOrder_Details,
                    getRepositoryFunc: x => x.Order_Details);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Categories for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Category> LookUpCategories
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpCategories,
                    getRepositoryFunc: x => x.Categories);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suppliers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier> LookUpSuppliers
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpSuppliers,
                    getRepositoryFunc: x => x.Suppliers);
            }
        }


        /// <summary>
        /// The view model for the ProductOrder_Details detail collection.
        /// </summary>
        public CollectionViewModelBase<Order_Detail, Order_Detail, Tuple<int, int>, INorthwindEntitiesUnitOfWork> ProductOrder_DetailsDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProductViewModel x) => x.ProductOrder_DetailsDetails,
                    getRepositoryFunc: x => x.Order_Details,
                    foreignKeyExpression: x => x.ProductID,
                    navigationExpression: x => x.Product);
            }
        }
    }
}

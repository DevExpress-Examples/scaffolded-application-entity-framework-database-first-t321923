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
    /// Represents the single Supplier object view model.
    /// </summary>
    public partial class SupplierViewModel : SingleObjectViewModel<Supplier, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SupplierViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SupplierViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SupplierViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SupplierViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SupplierViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SupplierViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suppliers, x => x.CompanyName) {
        }


        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SupplierViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }


        /// <summary>
        /// The view model for the SupplierProducts detail collection.
        /// </summary>
        public CollectionViewModelBase<Product, Product, int, INorthwindEntitiesUnitOfWork> SupplierProductsDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SupplierViewModel x) => x.SupplierProductsDetails,
                    getRepositoryFunc: x => x.Products,
                    foreignKeyExpression: x => x.SupplierID,
                    navigationExpression: x => x.Supplier);
            }
        }
    }
}

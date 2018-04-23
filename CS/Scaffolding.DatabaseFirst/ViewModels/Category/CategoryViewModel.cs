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
    /// Represents the single Category object view model.
    /// </summary>
    public partial class CategoryViewModel : SingleObjectViewModel<Category, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CategoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CategoryViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CategoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CategoryViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Categories, x => x.CategoryName) {
        }


        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CategoryViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }


        /// <summary>
        /// The view model for the CategoryProducts detail collection.
        /// </summary>
        public CollectionViewModelBase<Product, Product, int, INorthwindEntitiesUnitOfWork> CategoryProductsDetails
        {
            get
            {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CategoryViewModel x) => x.CategoryProductsDetails,
                    getRepositoryFunc: x => x.Products,
                    foreignKeyExpression: x => x.CategoryID,
                    navigationExpression: x => x.Category);
            }
        }
    }
}

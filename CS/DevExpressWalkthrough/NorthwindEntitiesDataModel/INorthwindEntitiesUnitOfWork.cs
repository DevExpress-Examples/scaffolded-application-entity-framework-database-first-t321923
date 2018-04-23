using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using DevExpressWalkthrough.Common.Utils;
using DevExpressWalkthrough.Common.DataModel;
using DevExpressWalkthrough.Common.DataModel.DesignTime;
using DevExpressWalkthrough.Common.DataModel.EntityFramework;
using DevExpressWalkthrough;

namespace DevExpressWalkthrough.NorthwindEntitiesDataModel {
    /// <summary>
    /// INorthwindEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface INorthwindEntitiesUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Alphabetical_list_of_product entities repository.
        /// </summary>
        IReadOnlyRepository<Alphabetical_list_of_product> Alphabetical_list_of_products { get; }

        /// <summary>
        /// The Category entities repository.
        /// </summary>
        IRepository<Category, int> Categories { get; }

        /// <summary>
        /// The Category_Sales_for_1997 entities repository.
        /// </summary>
        IReadOnlyRepository<Category_Sales_for_1997> Category_Sales_for_1997 { get; }

        /// <summary>
        /// The Current_Product_List entities repository.
        /// </summary>
        IReadOnlyRepository<Current_Product_List> Current_Product_Lists { get; }

        /// <summary>
        /// The Customer_and_Suppliers_by_City entities repository.
        /// </summary>
        IReadOnlyRepository<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; }

        /// <summary>
        /// The CustomerDemographic entities repository.
        /// </summary>
        IRepository<CustomerDemographic, string> CustomerDemographics { get; }

        /// <summary>
        /// The Customer entities repository.
        /// </summary>
        IRepository<Customer, string> Customers { get; }

        /// <summary>
        /// The Employee entities repository.
        /// </summary>
        IRepository<Employee, int> Employees { get; }

        /// <summary>
        /// The Invoice entities repository.
        /// </summary>
        IReadOnlyRepository<Invoice> Invoices { get; }

        /// <summary>
        /// The Order_Detail entities repository.
        /// </summary>
        IRepository<Order_Detail, Tuple<int, int>> Order_Details { get; }

        /// <summary>
        /// The Order_Details_Extended entities repository.
        /// </summary>
        IReadOnlyRepository<Order_Details_Extended> Order_Details_Extendeds { get; }

        /// <summary>
        /// The Order_Subtotal entities repository.
        /// </summary>
        IReadOnlyRepository<Order_Subtotal> Order_Subtotals { get; }

        /// <summary>
        /// The Order entities repository.
        /// </summary>
        IRepository<Order, int> Orders { get; }

        /// <summary>
        /// The Orders_Qry entities repository.
        /// </summary>
        IReadOnlyRepository<Orders_Qry> Orders_Qries { get; }

        /// <summary>
        /// The Product_Sales_for_1997 entities repository.
        /// </summary>
        IReadOnlyRepository<Product_Sales_for_1997> Product_Sales_for_1997 { get; }

        /// <summary>
        /// The Product entities repository.
        /// </summary>
        IRepository<Product, int> Products { get; }

        /// <summary>
        /// The Products_Above_Average_Price entities repository.
        /// </summary>
        IReadOnlyRepository<Products_Above_Average_Price> Products_Above_Average_Prices { get; }

        /// <summary>
        /// The Products_by_Category entities repository.
        /// </summary>
        IReadOnlyRepository<Products_by_Category> Products_by_Categories { get; }

        /// <summary>
        /// The Region entities repository.
        /// </summary>
        IRepository<Region, int> Regions { get; }

        /// <summary>
        /// The Sales_by_Category entities repository.
        /// </summary>
        IReadOnlyRepository<Sales_by_Category> Sales_by_Categories { get; }

        /// <summary>
        /// The Sales_Totals_by_Amount entities repository.
        /// </summary>
        IReadOnlyRepository<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; }

        /// <summary>
        /// The Shipper entities repository.
        /// </summary>
        IRepository<Shipper, int> Shippers { get; }

        /// <summary>
        /// The Summary_of_Sales_by_Quarter entities repository.
        /// </summary>
        IReadOnlyRepository<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; }

        /// <summary>
        /// The Summary_of_Sales_by_Year entities repository.
        /// </summary>
        IReadOnlyRepository<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; }

        /// <summary>
        /// The Supplier entities repository.
        /// </summary>
        IRepository<Supplier, int> Suppliers { get; }

        /// <summary>
        /// The Territory entities repository.
        /// </summary>
        IRepository<Territory, string> Territories { get; }
    }
}

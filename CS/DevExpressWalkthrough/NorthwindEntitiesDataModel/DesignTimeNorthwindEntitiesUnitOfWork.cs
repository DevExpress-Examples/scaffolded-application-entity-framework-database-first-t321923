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
    /// A NorthwindEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the INorthwindEntitiesUnitOfWork interface.
    /// </summary>
    public class NorthwindEntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, INorthwindEntitiesUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the NorthwindEntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public NorthwindEntitiesDesignTimeUnitOfWork() {
        }

        IReadOnlyRepository<Alphabetical_list_of_product> INorthwindEntitiesUnitOfWork.Alphabetical_list_of_products
        {
            get { return GetReadOnlyRepository<Alphabetical_list_of_product>(); }
        }

        IRepository<Category, int> INorthwindEntitiesUnitOfWork.Categories
        {
            get { return GetRepository((Category x) => x.CategoryID); }
        }

        IReadOnlyRepository<Category_Sales_for_1997> INorthwindEntitiesUnitOfWork.Category_Sales_for_1997
        {
            get { return GetReadOnlyRepository<Category_Sales_for_1997>(); }
        }

        IReadOnlyRepository<Current_Product_List> INorthwindEntitiesUnitOfWork.Current_Product_Lists
        {
            get { return GetReadOnlyRepository<Current_Product_List>(); }
        }

        IReadOnlyRepository<Customer_and_Suppliers_by_City> INorthwindEntitiesUnitOfWork.Customer_and_Suppliers_by_Cities
        {
            get { return GetReadOnlyRepository<Customer_and_Suppliers_by_City>(); }
        }

        IRepository<CustomerDemographic, string> INorthwindEntitiesUnitOfWork.CustomerDemographics
        {
            get { return GetRepository((CustomerDemographic x) => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwindEntitiesUnitOfWork.Customers
        {
            get { return GetRepository((Customer x) => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwindEntitiesUnitOfWork.Employees
        {
            get { return GetRepository((Employee x) => x.EmployeeID); }
        }

        IReadOnlyRepository<Invoice> INorthwindEntitiesUnitOfWork.Invoices
        {
            get { return GetReadOnlyRepository<Invoice>(); }
        }

        IRepository<Order_Detail, Tuple<int, int>> INorthwindEntitiesUnitOfWork.Order_Details
        {
            get { return GetRepository((Order_Detail x) => Tuple.Create(x.OrderID, x.ProductID)); }
        }

        IReadOnlyRepository<Order_Details_Extended> INorthwindEntitiesUnitOfWork.Order_Details_Extendeds
        {
            get { return GetReadOnlyRepository<Order_Details_Extended>(); }
        }

        IReadOnlyRepository<Order_Subtotal> INorthwindEntitiesUnitOfWork.Order_Subtotals
        {
            get { return GetReadOnlyRepository<Order_Subtotal>(); }
        }

        IRepository<Order, int> INorthwindEntitiesUnitOfWork.Orders
        {
            get { return GetRepository((Order x) => x.OrderID); }
        }

        IReadOnlyRepository<Orders_Qry> INorthwindEntitiesUnitOfWork.Orders_Qries
        {
            get { return GetReadOnlyRepository<Orders_Qry>(); }
        }

        IReadOnlyRepository<Product_Sales_for_1997> INorthwindEntitiesUnitOfWork.Product_Sales_for_1997
        {
            get { return GetReadOnlyRepository<Product_Sales_for_1997>(); }
        }

        IRepository<Product, int> INorthwindEntitiesUnitOfWork.Products
        {
            get { return GetRepository((Product x) => x.ProductID); }
        }

        IReadOnlyRepository<Products_Above_Average_Price> INorthwindEntitiesUnitOfWork.Products_Above_Average_Prices
        {
            get { return GetReadOnlyRepository<Products_Above_Average_Price>(); }
        }

        IReadOnlyRepository<Products_by_Category> INorthwindEntitiesUnitOfWork.Products_by_Categories
        {
            get { return GetReadOnlyRepository<Products_by_Category>(); }
        }

        IRepository<Region, int> INorthwindEntitiesUnitOfWork.Regions
        {
            get { return GetRepository((Region x) => x.RegionID); }
        }

        IReadOnlyRepository<Sales_by_Category> INorthwindEntitiesUnitOfWork.Sales_by_Categories
        {
            get { return GetReadOnlyRepository<Sales_by_Category>(); }
        }

        IReadOnlyRepository<Sales_Totals_by_Amount> INorthwindEntitiesUnitOfWork.Sales_Totals_by_Amounts
        {
            get { return GetReadOnlyRepository<Sales_Totals_by_Amount>(); }
        }

        IRepository<Shipper, int> INorthwindEntitiesUnitOfWork.Shippers
        {
            get { return GetRepository((Shipper x) => x.ShipperID); }
        }

        IReadOnlyRepository<Summary_of_Sales_by_Quarter> INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Quarters
        {
            get { return GetReadOnlyRepository<Summary_of_Sales_by_Quarter>(); }
        }

        IReadOnlyRepository<Summary_of_Sales_by_Year> INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Years
        {
            get { return GetReadOnlyRepository<Summary_of_Sales_by_Year>(); }
        }

        IRepository<Supplier, int> INorthwindEntitiesUnitOfWork.Suppliers
        {
            get { return GetRepository((Supplier x) => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwindEntitiesUnitOfWork.Territories
        {
            get { return GetRepository((Territory x) => x.TerritoryID); }
        }
    }
}

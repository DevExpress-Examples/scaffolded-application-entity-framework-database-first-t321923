using DevExpress.Mvvm.DataAnnotations;
using Scaffolding.DatabaseFirst;
using Scaffolding.DatabaseFirst.Localization;

namespace Scaffolding.DatabaseFirst.NorthwindEntitiesDataModel {

    public class NorthwindEntitiesMetadataProvider {
        public static void BuildMetadata(MetadataBuilder<Category> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Category);
            builder.Property(x => x.CategoryID).DisplayName(NorthwindEntitiesResources.Category_CategoryID);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Category_CategoryName);
            builder.Property(x => x.Description).DisplayName(NorthwindEntitiesResources.Category_Description);
            builder.Property(x => x.Picture).DisplayName(NorthwindEntitiesResources.Category_Picture);
        }
        public static void BuildMetadata(MetadataBuilder<CustomerDemographic> builder) {
            builder.DisplayName(NorthwindEntitiesResources.CustomerDemographic);
            builder.Property(x => x.CustomerTypeID).DisplayName(NorthwindEntitiesResources.CustomerDemographic_CustomerTypeID);
            builder.Property(x => x.CustomerDesc).DisplayName(NorthwindEntitiesResources.CustomerDemographic_CustomerDesc);
        }
        public static void BuildMetadata(MetadataBuilder<Customer> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Customer);
            builder.Property(x => x.CustomerID).DisplayName(NorthwindEntitiesResources.Customer_CustomerID);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Customer_CompanyName);
            builder.Property(x => x.ContactName).DisplayName(NorthwindEntitiesResources.Customer_ContactName);
            builder.Property(x => x.ContactTitle).DisplayName(NorthwindEntitiesResources.Customer_ContactTitle);
            builder.Property(x => x.Address).DisplayName(NorthwindEntitiesResources.Customer_Address);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Customer_City);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Customer_Region);
            builder.Property(x => x.PostalCode).DisplayName(NorthwindEntitiesResources.Customer_PostalCode);
            builder.Property(x => x.Country).DisplayName(NorthwindEntitiesResources.Customer_Country);
            builder.Property(x => x.Phone).DisplayName(NorthwindEntitiesResources.Customer_Phone);
            builder.Property(x => x.Fax).DisplayName(NorthwindEntitiesResources.Customer_Fax);
        }
        public static void BuildMetadata(MetadataBuilder<Employee> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Employee);
            builder.Property(x => x.EmployeeID).DisplayName(NorthwindEntitiesResources.Employee_EmployeeID);
            builder.Property(x => x.LastName).DisplayName(NorthwindEntitiesResources.Employee_LastName);
            builder.Property(x => x.FirstName).DisplayName(NorthwindEntitiesResources.Employee_FirstName);
            builder.Property(x => x.Title).DisplayName(NorthwindEntitiesResources.Employee_Title);
            builder.Property(x => x.TitleOfCourtesy).DisplayName(NorthwindEntitiesResources.Employee_TitleOfCourtesy);
            builder.Property(x => x.BirthDate).DisplayName(NorthwindEntitiesResources.Employee_BirthDate);
            builder.Property(x => x.HireDate).DisplayName(NorthwindEntitiesResources.Employee_HireDate);
            builder.Property(x => x.Address).DisplayName(NorthwindEntitiesResources.Employee_Address);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Employee_City);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Employee_Region);
            builder.Property(x => x.PostalCode).DisplayName(NorthwindEntitiesResources.Employee_PostalCode);
            builder.Property(x => x.Country).DisplayName(NorthwindEntitiesResources.Employee_Country);
            builder.Property(x => x.HomePhone).DisplayName(NorthwindEntitiesResources.Employee_HomePhone);
            builder.Property(x => x.Extension).DisplayName(NorthwindEntitiesResources.Employee_Extension);
            builder.Property(x => x.Photo).DisplayName(NorthwindEntitiesResources.Employee_Photo);
            builder.Property(x => x.Notes).DisplayName(NorthwindEntitiesResources.Employee_Notes);
            builder.Property(x => x.PhotoPath).DisplayName(NorthwindEntitiesResources.Employee_PhotoPath);
            builder.Property(x => x.Employee1).DisplayName(NorthwindEntitiesResources.Employee_Employee1);
        }
        public static void BuildMetadata(MetadataBuilder<Order_Detail> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Order_Detail);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Order_Detail_UnitPrice);
            builder.Property(x => x.Quantity).DisplayName(NorthwindEntitiesResources.Order_Detail_Quantity);
            builder.Property(x => x.Discount).DisplayName(NorthwindEntitiesResources.Order_Detail_Discount);
            builder.Property(x => x.Order).DisplayName(NorthwindEntitiesResources.Order_Detail_Order);
            builder.Property(x => x.Product).DisplayName(NorthwindEntitiesResources.Order_Detail_Product);
        }
        public static void BuildMetadata(MetadataBuilder<Order> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Order);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Order_OrderID);
            builder.Property(x => x.OrderDate).DisplayName(NorthwindEntitiesResources.Order_OrderDate);
            builder.Property(x => x.RequiredDate).DisplayName(NorthwindEntitiesResources.Order_RequiredDate);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Order_ShippedDate);
            builder.Property(x => x.Freight).DisplayName(NorthwindEntitiesResources.Order_Freight);
            builder.Property(x => x.ShipName).DisplayName(NorthwindEntitiesResources.Order_ShipName);
            builder.Property(x => x.ShipAddress).DisplayName(NorthwindEntitiesResources.Order_ShipAddress);
            builder.Property(x => x.ShipCity).DisplayName(NorthwindEntitiesResources.Order_ShipCity);
            builder.Property(x => x.ShipRegion).DisplayName(NorthwindEntitiesResources.Order_ShipRegion);
            builder.Property(x => x.ShipPostalCode).DisplayName(NorthwindEntitiesResources.Order_ShipPostalCode);
            builder.Property(x => x.ShipCountry).DisplayName(NorthwindEntitiesResources.Order_ShipCountry);
            builder.Property(x => x.Customer).DisplayName(NorthwindEntitiesResources.Order_Customer);
            builder.Property(x => x.Employee).DisplayName(NorthwindEntitiesResources.Order_Employee);
            builder.Property(x => x.Shipper).DisplayName(NorthwindEntitiesResources.Order_Shipper);
        }
        public static void BuildMetadata(MetadataBuilder<Product> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Product);
            builder.Property(x => x.ProductID).DisplayName(NorthwindEntitiesResources.Product_ProductID);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Product_ProductName);
            builder.Property(x => x.QuantityPerUnit).DisplayName(NorthwindEntitiesResources.Product_QuantityPerUnit);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Product_UnitPrice);
            builder.Property(x => x.UnitsInStock).DisplayName(NorthwindEntitiesResources.Product_UnitsInStock);
            builder.Property(x => x.UnitsOnOrder).DisplayName(NorthwindEntitiesResources.Product_UnitsOnOrder);
            builder.Property(x => x.ReorderLevel).DisplayName(NorthwindEntitiesResources.Product_ReorderLevel);
            builder.Property(x => x.Discontinued).DisplayName(NorthwindEntitiesResources.Product_Discontinued);
            builder.Property(x => x.Category).DisplayName(NorthwindEntitiesResources.Product_Category);
            builder.Property(x => x.Supplier).DisplayName(NorthwindEntitiesResources.Product_Supplier);
        }
        public static void BuildMetadata(MetadataBuilder<Region> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Region);
            builder.Property(x => x.RegionID).DisplayName(NorthwindEntitiesResources.Region_RegionID);
            builder.Property(x => x.RegionDescription).DisplayName(NorthwindEntitiesResources.Region_RegionDescription);
        }
        public static void BuildMetadata(MetadataBuilder<Shipper> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Shipper);
            builder.Property(x => x.ShipperID).DisplayName(NorthwindEntitiesResources.Shipper_ShipperID);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Shipper_CompanyName);
            builder.Property(x => x.Phone).DisplayName(NorthwindEntitiesResources.Shipper_Phone);
        }
        public static void BuildMetadata(MetadataBuilder<Supplier> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Supplier);
            builder.Property(x => x.SupplierID).DisplayName(NorthwindEntitiesResources.Supplier_SupplierID);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Supplier_CompanyName);
            builder.Property(x => x.ContactName).DisplayName(NorthwindEntitiesResources.Supplier_ContactName);
            builder.Property(x => x.ContactTitle).DisplayName(NorthwindEntitiesResources.Supplier_ContactTitle);
            builder.Property(x => x.Address).DisplayName(NorthwindEntitiesResources.Supplier_Address);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Supplier_City);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Supplier_Region);
            builder.Property(x => x.PostalCode).DisplayName(NorthwindEntitiesResources.Supplier_PostalCode);
            builder.Property(x => x.Country).DisplayName(NorthwindEntitiesResources.Supplier_Country);
            builder.Property(x => x.Phone).DisplayName(NorthwindEntitiesResources.Supplier_Phone);
            builder.Property(x => x.Fax).DisplayName(NorthwindEntitiesResources.Supplier_Fax);
            builder.Property(x => x.HomePage).DisplayName(NorthwindEntitiesResources.Supplier_HomePage);
        }
        public static void BuildMetadata(MetadataBuilder<Territory> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Territory);
            builder.Property(x => x.TerritoryID).DisplayName(NorthwindEntitiesResources.Territory_TerritoryID);
            builder.Property(x => x.TerritoryDescription).DisplayName(NorthwindEntitiesResources.Territory_TerritoryDescription);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Territory_Region);
        }
        public static void BuildMetadata(MetadataBuilder<Alphabetical_list_of_product> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product);
            builder.Property(x => x.ProductID).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_ProductID);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_ProductName);
            builder.Property(x => x.SupplierID).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_SupplierID);
            builder.Property(x => x.CategoryID).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_CategoryID);
            builder.Property(x => x.QuantityPerUnit).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_QuantityPerUnit);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_UnitPrice);
            builder.Property(x => x.UnitsInStock).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_UnitsInStock);
            builder.Property(x => x.UnitsOnOrder).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_UnitsOnOrder);
            builder.Property(x => x.ReorderLevel).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_ReorderLevel);
            builder.Property(x => x.Discontinued).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_Discontinued);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Alphabetical_list_of_product_CategoryName);
        }
        public static void BuildMetadata(MetadataBuilder<Category_Sales_for_1997> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Category_Sales_for_1997);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Category_Sales_for_1997_CategoryName);
            builder.Property(x => x.CategorySales).DisplayName(NorthwindEntitiesResources.Category_Sales_for_1997_CategorySales);
        }
        public static void BuildMetadata(MetadataBuilder<Current_Product_List> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Current_Product_List);
            builder.Property(x => x.ProductID).DisplayName(NorthwindEntitiesResources.Current_Product_List_ProductID);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Current_Product_List_ProductName);
        }
        public static void BuildMetadata(MetadataBuilder<Customer_and_Suppliers_by_City> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Customer_and_Suppliers_by_City);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Customer_and_Suppliers_by_City_City);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Customer_and_Suppliers_by_City_CompanyName);
            builder.Property(x => x.ContactName).DisplayName(NorthwindEntitiesResources.Customer_and_Suppliers_by_City_ContactName);
            builder.Property(x => x.Relationship).DisplayName(NorthwindEntitiesResources.Customer_and_Suppliers_by_City_Relationship);
        }
        public static void BuildMetadata(MetadataBuilder<Invoice> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Invoice);
            builder.Property(x => x.ShipName).DisplayName(NorthwindEntitiesResources.Invoice_ShipName);
            builder.Property(x => x.ShipAddress).DisplayName(NorthwindEntitiesResources.Invoice_ShipAddress);
            builder.Property(x => x.ShipCity).DisplayName(NorthwindEntitiesResources.Invoice_ShipCity);
            builder.Property(x => x.ShipRegion).DisplayName(NorthwindEntitiesResources.Invoice_ShipRegion);
            builder.Property(x => x.ShipPostalCode).DisplayName(NorthwindEntitiesResources.Invoice_ShipPostalCode);
            builder.Property(x => x.ShipCountry).DisplayName(NorthwindEntitiesResources.Invoice_ShipCountry);
            builder.Property(x => x.CustomerID).DisplayName(NorthwindEntitiesResources.Invoice_CustomerID);
            builder.Property(x => x.CustomerName).DisplayName(NorthwindEntitiesResources.Invoice_CustomerName);
            builder.Property(x => x.Address).DisplayName(NorthwindEntitiesResources.Invoice_Address);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Invoice_City);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Invoice_Region);
            builder.Property(x => x.PostalCode).DisplayName(NorthwindEntitiesResources.Invoice_PostalCode);
            builder.Property(x => x.Country).DisplayName(NorthwindEntitiesResources.Invoice_Country);
            builder.Property(x => x.Salesperson).DisplayName(NorthwindEntitiesResources.Invoice_Salesperson);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Invoice_OrderID);
            builder.Property(x => x.OrderDate).DisplayName(NorthwindEntitiesResources.Invoice_OrderDate);
            builder.Property(x => x.RequiredDate).DisplayName(NorthwindEntitiesResources.Invoice_RequiredDate);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Invoice_ShippedDate);
            builder.Property(x => x.ShipperName).DisplayName(NorthwindEntitiesResources.Invoice_ShipperName);
            builder.Property(x => x.ProductID).DisplayName(NorthwindEntitiesResources.Invoice_ProductID);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Invoice_ProductName);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Invoice_UnitPrice);
            builder.Property(x => x.Quantity).DisplayName(NorthwindEntitiesResources.Invoice_Quantity);
            builder.Property(x => x.Discount).DisplayName(NorthwindEntitiesResources.Invoice_Discount);
            builder.Property(x => x.ExtendedPrice).DisplayName(NorthwindEntitiesResources.Invoice_ExtendedPrice);
            builder.Property(x => x.Freight).DisplayName(NorthwindEntitiesResources.Invoice_Freight);
        }
        public static void BuildMetadata(MetadataBuilder<Order_Details_Extended> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Order_Details_Extended);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_OrderID);
            builder.Property(x => x.ProductID).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_ProductID);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_ProductName);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_UnitPrice);
            builder.Property(x => x.Quantity).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_Quantity);
            builder.Property(x => x.Discount).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_Discount);
            builder.Property(x => x.ExtendedPrice).DisplayName(NorthwindEntitiesResources.Order_Details_Extended_ExtendedPrice);
        }
        public static void BuildMetadata(MetadataBuilder<Order_Subtotal> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Order_Subtotal);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Order_Subtotal_OrderID);
            builder.Property(x => x.Subtotal).DisplayName(NorthwindEntitiesResources.Order_Subtotal_Subtotal);
        }
        public static void BuildMetadata(MetadataBuilder<Orders_Qry> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Orders_Qry);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Orders_Qry_OrderID);
            builder.Property(x => x.CustomerID).DisplayName(NorthwindEntitiesResources.Orders_Qry_CustomerID);
            builder.Property(x => x.EmployeeID).DisplayName(NorthwindEntitiesResources.Orders_Qry_EmployeeID);
            builder.Property(x => x.OrderDate).DisplayName(NorthwindEntitiesResources.Orders_Qry_OrderDate);
            builder.Property(x => x.RequiredDate).DisplayName(NorthwindEntitiesResources.Orders_Qry_RequiredDate);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShippedDate);
            builder.Property(x => x.ShipVia).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipVia);
            builder.Property(x => x.Freight).DisplayName(NorthwindEntitiesResources.Orders_Qry_Freight);
            builder.Property(x => x.ShipName).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipName);
            builder.Property(x => x.ShipAddress).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipAddress);
            builder.Property(x => x.ShipCity).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipCity);
            builder.Property(x => x.ShipRegion).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipRegion);
            builder.Property(x => x.ShipPostalCode).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipPostalCode);
            builder.Property(x => x.ShipCountry).DisplayName(NorthwindEntitiesResources.Orders_Qry_ShipCountry);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Orders_Qry_CompanyName);
            builder.Property(x => x.Address).DisplayName(NorthwindEntitiesResources.Orders_Qry_Address);
            builder.Property(x => x.City).DisplayName(NorthwindEntitiesResources.Orders_Qry_City);
            builder.Property(x => x.Region).DisplayName(NorthwindEntitiesResources.Orders_Qry_Region);
            builder.Property(x => x.PostalCode).DisplayName(NorthwindEntitiesResources.Orders_Qry_PostalCode);
            builder.Property(x => x.Country).DisplayName(NorthwindEntitiesResources.Orders_Qry_Country);
        }
        public static void BuildMetadata(MetadataBuilder<Product_Sales_for_1997> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Product_Sales_for_1997);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Product_Sales_for_1997_CategoryName);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Product_Sales_for_1997_ProductName);
            builder.Property(x => x.ProductSales).DisplayName(NorthwindEntitiesResources.Product_Sales_for_1997_ProductSales);
        }
        public static void BuildMetadata(MetadataBuilder<Products_Above_Average_Price> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Products_Above_Average_Price);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Products_Above_Average_Price_ProductName);
            builder.Property(x => x.UnitPrice).DisplayName(NorthwindEntitiesResources.Products_Above_Average_Price_UnitPrice);
        }
        public static void BuildMetadata(MetadataBuilder<Products_by_Category> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Products_by_Category);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Products_by_Category_CategoryName);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Products_by_Category_ProductName);
            builder.Property(x => x.QuantityPerUnit).DisplayName(NorthwindEntitiesResources.Products_by_Category_QuantityPerUnit);
            builder.Property(x => x.UnitsInStock).DisplayName(NorthwindEntitiesResources.Products_by_Category_UnitsInStock);
            builder.Property(x => x.Discontinued).DisplayName(NorthwindEntitiesResources.Products_by_Category_Discontinued);
        }
        public static void BuildMetadata(MetadataBuilder<Sales_by_Category> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Sales_by_Category);
            builder.Property(x => x.CategoryID).DisplayName(NorthwindEntitiesResources.Sales_by_Category_CategoryID);
            builder.Property(x => x.CategoryName).DisplayName(NorthwindEntitiesResources.Sales_by_Category_CategoryName);
            builder.Property(x => x.ProductName).DisplayName(NorthwindEntitiesResources.Sales_by_Category_ProductName);
            builder.Property(x => x.ProductSales).DisplayName(NorthwindEntitiesResources.Sales_by_Category_ProductSales);
        }
        public static void BuildMetadata(MetadataBuilder<Sales_Totals_by_Amount> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Sales_Totals_by_Amount);
            builder.Property(x => x.SaleAmount).DisplayName(NorthwindEntitiesResources.Sales_Totals_by_Amount_SaleAmount);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Sales_Totals_by_Amount_OrderID);
            builder.Property(x => x.CompanyName).DisplayName(NorthwindEntitiesResources.Sales_Totals_by_Amount_CompanyName);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Sales_Totals_by_Amount_ShippedDate);
        }
        public static void BuildMetadata(MetadataBuilder<Summary_of_Sales_by_Quarter> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Quarter);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Quarter_ShippedDate);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Quarter_OrderID);
            builder.Property(x => x.Subtotal).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Quarter_Subtotal);
        }
        public static void BuildMetadata(MetadataBuilder<Summary_of_Sales_by_Year> builder) {
            builder.DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Year);
            builder.Property(x => x.ShippedDate).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Year_ShippedDate);
            builder.Property(x => x.OrderID).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Year_OrderID);
            builder.Property(x => x.Subtotal).DisplayName(NorthwindEntitiesResources.Summary_of_Sales_by_Year_Subtotal);
        }
    }
}
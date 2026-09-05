/* SQL Server 2022+ portfolio lab */

IF DB_ID(N'TaskFlowSqlLab') IS NULL
    CREATE DATABASE TaskFlowSqlLab;
GO
USE TaskFlowSqlLab;
GO

DROP TABLE IF EXISTS dbo.SalesOrderItem;
DROP TABLE IF EXISTS dbo.SalesOrder;
DROP TABLE IF EXISTS dbo.Product;
DROP TABLE IF EXISTS dbo.ProductCategory;
DROP TABLE IF EXISTS dbo.Customer;
GO

CREATE TABLE dbo.Customer
(
    CustomerId int IDENTITY(1,1) CONSTRAINT PK_Customer PRIMARY KEY,
    CustomerCode varchar(30) NOT NULL CONSTRAINT UQ_Customer_Code UNIQUE,
    CustomerName varchar(150) NOT NULL,
    Region varchar(50) NOT NULL,
    IsActive bit NOT NULL CONSTRAINT DF_Customer_IsActive DEFAULT (1),
    CreatedAt datetime2(3) NOT NULL CONSTRAINT DF_Customer_CreatedAt DEFAULT SYSUTCDATETIME()
);

CREATE TABLE dbo.ProductCategory
(
    ProductCategoryId int IDENTITY(1,1) CONSTRAINT PK_ProductCategory PRIMARY KEY,
    CategoryName varchar(100) NOT NULL CONSTRAINT UQ_ProductCategory_Name UNIQUE
);

CREATE TABLE dbo.Product
(
    ProductId int IDENTITY(1,1) CONSTRAINT PK_Product PRIMARY KEY,
    ProductCategoryId int NOT NULL CONSTRAINT FK_Product_Category REFERENCES dbo.ProductCategory(ProductCategoryId),
    SKU varchar(40) NOT NULL CONSTRAINT UQ_Product_SKU UNIQUE,
    ProductName varchar(150) NOT NULL,
    UnitPrice decimal(12,2) NOT NULL,
    IsActive bit NOT NULL CONSTRAINT DF_Product_IsActive DEFAULT (1)
);

CREATE TABLE dbo.SalesOrder
(
    SalesOrderId bigint IDENTITY(1,1) CONSTRAINT PK_SalesOrder PRIMARY KEY,
    CustomerId int NOT NULL CONSTRAINT FK_SalesOrder_Customer REFERENCES dbo.Customer(CustomerId),
    OrderDate datetime2(3) NOT NULL,
    Status varchar(20) NOT NULL,
    SalesChannel varchar(20) NOT NULL,
    TotalAmount decimal(14,2) NOT NULL
);

CREATE TABLE dbo.SalesOrderItem
(
    SalesOrderItemId bigint IDENTITY(1,1) CONSTRAINT PK_SalesOrderItem PRIMARY KEY,
    SalesOrderId bigint NOT NULL CONSTRAINT FK_SalesOrderItem_Order REFERENCES dbo.SalesOrder(SalesOrderId),
    ProductId int NOT NULL CONSTRAINT FK_SalesOrderItem_Product REFERENCES dbo.Product(ProductId),
    Quantity int NOT NULL,
    UnitPrice decimal(12,2) NOT NULL
);
GO

INSERT dbo.ProductCategory(CategoryName)
VALUES ('Industrial'), ('Software'), ('Services');

INSERT dbo.Customer(CustomerCode, CustomerName, Region)
VALUES
('ACME-001','Acme Manufacturing','West'),
('ZEN-002','Zenith Retail','South'),
('NOVA-003','Nova Logistics','North'),
('ORBIT-004','Orbit Energy','West'),
('APEX-005','Apex Healthcare','East');

INSERT dbo.Product(ProductCategoryId, SKU, ProductName, UnitPrice)
SELECT pc.ProductCategoryId, v.SKU, v.ProductName, v.UnitPrice
FROM (VALUES
('IND-100','Industrial Sensor',1250.00,'Industrial'),
('IND-200','PLC Controller',4200.00,'Industrial'),
('SW-100','Analytics Platform',18000.00,'Software'),
('SW-200','Workflow Suite',9500.00,'Software'),
('SRV-100','Implementation Services',7500.00,'Services')) v(SKU,ProductName,UnitPrice,CategoryName)
JOIN dbo.ProductCategory pc ON pc.CategoryName = v.CategoryName;

;WITH Numbers AS
(
    SELECT TOP (5000) ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
    FROM sys.all_objects a CROSS JOIN sys.all_objects b
)
INSERT dbo.SalesOrder(CustomerId, OrderDate, Status, SalesChannel, TotalAmount)
SELECT
    ((n - 1) % 5) + 1,
    DATEADD(DAY, -(n % 365), SYSUTCDATETIME()),
    CASE n % 5 WHEN 0 THEN 'Cancelled' WHEN 1 THEN 'Pending' ELSE 'Completed' END,
    CASE n % 3 WHEN 0 THEN 'Web' WHEN 1 THEN 'Partner' ELSE 'Direct' END,
    CAST(500 + (n % 100) * 125.50 AS decimal(14,2))
FROM Numbers;

INSERT dbo.SalesOrderItem(SalesOrderId, ProductId, Quantity, UnitPrice)
SELECT
    o.SalesOrderId,
    ((o.SalesOrderId + v.n) % 5) + 1,
    (o.SalesOrderId % 5) + v.n,
    p.UnitPrice
FROM dbo.SalesOrder o
CROSS JOIN (VALUES (1),(2)) v(n)
JOIN dbo.Product p ON p.ProductId = ((o.SalesOrderId + v.n) % 5) + 1;
GO

CREATE INDEX IX_SalesOrder_Customer_OrderDate
ON dbo.SalesOrder(CustomerId, OrderDate DESC)
INCLUDE(Status, SalesChannel, TotalAmount);

CREATE INDEX IX_SalesOrderItem_Order_Product
ON dbo.SalesOrderItem(SalesOrderId, ProductId)
INCLUDE(Quantity, UnitPrice);

CREATE INDEX IX_Product_Category_Active
ON dbo.Product(ProductCategoryId, IsActive)
INCLUDE(SKU, ProductName, UnitPrice);
GO

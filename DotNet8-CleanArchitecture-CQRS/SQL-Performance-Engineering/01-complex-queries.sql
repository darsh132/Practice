USE TaskFlowSqlLab;
GO

/* 1. Multi-table join + aggregation + HAVING */
SELECT
    c.CustomerCode,
    c.CustomerName,
    c.Region,
    COUNT(DISTINCT o.SalesOrderId) AS OrderCount,
    SUM(oi.Quantity * oi.UnitPrice) AS GrossRevenue,
    AVG(oi.Quantity * oi.UnitPrice) AS AverageLineValue
FROM dbo.Customer c
JOIN dbo.SalesOrder o ON o.CustomerId = c.CustomerId
JOIN dbo.SalesOrderItem oi ON oi.SalesOrderId = o.SalesOrderId
JOIN dbo.Product p ON p.ProductId = oi.ProductId
JOIN dbo.ProductCategory pc ON pc.ProductCategoryId = p.ProductCategoryId
WHERE o.Status = 'Completed'
  AND o.OrderDate >= DATEADD(DAY, -90, SYSUTCDATETIME())
GROUP BY c.CustomerCode, c.CustomerName, c.Region
HAVING SUM(oi.Quantity * oi.UnitPrice) > 100000
ORDER BY GrossRevenue DESC;
GO

/* 2. CTE: monthly revenue, followed by regional ranking */
;WITH MonthlyRevenue AS
(
    SELECT
        c.Region,
        DATEFROMPARTS(YEAR(o.OrderDate), MONTH(o.OrderDate), 1) AS RevenueMonth,
        SUM(oi.Quantity * oi.UnitPrice) AS Revenue
    FROM dbo.Customer c
    JOIN dbo.SalesOrder o ON o.CustomerId = c.CustomerId
    JOIN dbo.SalesOrderItem oi ON oi.SalesOrderId = o.SalesOrderId
    WHERE o.Status = 'Completed'
    GROUP BY c.Region, DATEFROMPARTS(YEAR(o.OrderDate), MONTH(o.OrderDate), 1)
),
RankedRevenue AS
(
    SELECT
        Region,
        RevenueMonth,
        Revenue,
        RANK() OVER (PARTITION BY RevenueMonth ORDER BY Revenue DESC) AS RegionalRank,
        SUM(Revenue) OVER
        (
            PARTITION BY Region
            ORDER BY RevenueMonth
            ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
        ) AS RunningRegionalRevenue
    FROM MonthlyRevenue
)
SELECT *
FROM RankedRevenue
ORDER BY RevenueMonth, RegionalRank;
GO

/* 3. Window function: latest completed order per customer */
;WITH RankedOrders AS
(
    SELECT
        o.SalesOrderId,
        o.CustomerId,
        o.OrderDate,
        o.TotalAmount,
        ROW_NUMBER() OVER
        (
            PARTITION BY o.CustomerId
            ORDER BY o.OrderDate DESC, o.SalesOrderId DESC
        ) AS rn
    FROM dbo.SalesOrder o
    WHERE o.Status = 'Completed'
)
SELECT
    c.CustomerCode,
    c.CustomerName,
    r.SalesOrderId,
    r.OrderDate,
    r.TotalAmount
FROM RankedOrders r
JOIN dbo.Customer c ON c.CustomerId = r.CustomerId
WHERE r.rn = 1
ORDER BY r.OrderDate DESC;
GO

/* 4. Window function: top 3 products in each category */
;WITH ProductRevenue AS
(
    SELECT
        pc.CategoryName,
        p.ProductId,
        p.ProductName,
        SUM(oi.Quantity * oi.UnitPrice) AS Revenue
    FROM dbo.Product p
    JOIN dbo.ProductCategory pc ON pc.ProductCategoryId = p.ProductCategoryId
    JOIN dbo.SalesOrderItem oi ON oi.ProductId = p.ProductId
    JOIN dbo.SalesOrder o ON o.SalesOrderId = oi.SalesOrderId
    WHERE o.Status = 'Completed'
    GROUP BY pc.CategoryName, p.ProductId, p.ProductName
), RankedProducts AS
(
    SELECT *,
           DENSE_RANK() OVER (PARTITION BY CategoryName ORDER BY Revenue DESC) AS RevenueRank
    FROM ProductRevenue
)
SELECT CategoryName, ProductName, Revenue, RevenueRank
FROM RankedProducts
WHERE RevenueRank <= 3
ORDER BY CategoryName, RevenueRank;
GO

USE TaskFlowSqlLab;
GO

/*
QUERY TUNING LAB

Goal: compare a non-sargable date predicate against a sargable range predicate.
Capture Actual Execution Plan and STATISTICS IO/TIME for both versions.
*/

SET STATISTICS IO ON;
SET STATISTICS TIME ON;
GO

/* BEFORE: function applied to the indexed OrderDate column. */
SELECT
    o.CustomerId,
    COUNT_BIG(*) AS OrderCount,
    SUM(o.TotalAmount) AS Revenue
FROM dbo.SalesOrder AS o
WHERE CONVERT(date, o.OrderDate) = CONVERT(date, DATEADD(DAY, -30, SYSUTCDATETIME()))
GROUP BY o.CustomerId;
GO

/* TUNING STEP: make the predicate sargable and align an index to the access path. */
CREATE INDEX IX_SalesOrder_OrderDate_Customer
ON dbo.SalesOrder(OrderDate)
INCLUDE(CustomerId, TotalAmount);
GO

/* AFTER: range predicate can seek directly into the OrderDate index. */
DECLARE @StartDate datetime2(3) = CONVERT(date, DATEADD(DAY, -30, SYSUTCDATETIME()));
DECLARE @EndDate datetime2(3) = DATEADD(DAY, 1, @StartDate);

SELECT
    o.CustomerId,
    COUNT_BIG(*) AS OrderCount,
    SUM(o.TotalAmount) AS Revenue
FROM dbo.SalesOrder AS o
WHERE o.OrderDate >= @StartDate
  AND o.OrderDate < @EndDate
GROUP BY o.CustomerId;
GO

SET STATISTICS IO OFF;
SET STATISTICS TIME OFF;
GO

/*
OPTIONAL comparison query: inspect index usage through DMVs after executing the lab.
Run in the same database and correlate with the query text / plan handle as needed.
*/
SELECT
    OBJECT_NAME(i.object_id) AS TableName,
    i.name AS IndexName,
    i.type_desc,
    i.is_unique,
    i.is_primary_key
FROM sys.indexes AS i
WHERE i.object_id IN
(
    OBJECT_ID('dbo.SalesOrder'),
    OBJECT_ID('dbo.SalesOrderItem')
)
ORDER BY TableName, IndexName;
GO

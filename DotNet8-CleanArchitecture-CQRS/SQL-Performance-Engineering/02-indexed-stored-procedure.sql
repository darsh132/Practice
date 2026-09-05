USE TaskFlowSqlLab;
GO

DROP PROCEDURE IF EXISTS dbo.usp_GetCustomerOrderHistory;
GO

/*
    Indexed stored procedure pattern:
    - Parameterized filtering
    - Stable ORDER BY
    - Narrow covering index aligned with the access path
    - OFFSET/FETCH pagination
*/
CREATE OR ALTER PROCEDURE dbo.usp_GetCustomerOrderHistory
    @CustomerId int,
    @FromDate datetime2(3),
    @ToDate datetime2(3),
    @PageNumber int = 1,
    @PageSize int = 50
AS
BEGIN
    SET NOCOUNT ON;

    IF @PageNumber < 1 OR @PageSize NOT BETWEEN 1 AND 500
        THROW 50001, 'Invalid pagination arguments.', 1;

    SELECT
        o.SalesOrderId,
        o.OrderDate,
        o.Status,
        o.SalesChannel,
        o.TotalAmount
    FROM dbo.SalesOrder AS o
    WHERE o.CustomerId = @CustomerId
      AND o.OrderDate >= @FromDate
      AND o.OrderDate < @ToDate
    ORDER BY o.OrderDate DESC, o.SalesOrderId DESC
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
END;
GO

/* Supporting index: equality predicate first, then date/range + ordering, covering output columns. */
CREATE INDEX IX_SalesOrder_Customer_OrderDate_Proc
ON dbo.SalesOrder(CustomerId, OrderDate DESC, SalesOrderId DESC)
INCLUDE(Status, SalesChannel, TotalAmount);
GO

EXEC dbo.usp_GetCustomerOrderHistory
    @CustomerId = 1,
    @FromDate = DATEADD(DAY, -180, SYSUTCDATETIME()),
    @ToDate = SYSUTCDATETIME(),
    @PageNumber = 1,
    @PageSize = 50;
GO

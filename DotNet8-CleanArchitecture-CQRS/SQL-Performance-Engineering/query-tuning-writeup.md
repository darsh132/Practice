# Query Tuning Write-up: Non-SARGable Predicate to Index Seek

## Problem

The baseline query filters with:

```sql
WHERE CONVERT(date, o.OrderDate) = CONVERT(date, DATEADD(DAY, -30, SYSUTCDATETIME()))
```

The expression applies a function to the indexed column. That can prevent the optimizer from using the index as an efficient range access path.

## Before

Expected evidence to capture in SQL Server Management Studio with **Include Actual Execution Plan** enabled:

- Scan or inefficient access against `SalesOrder`.
- Higher logical reads.
- Higher CPU/elapsed time as the table grows.
- A filter operation evaluating the converted value.

Also execute with:

```sql
SET STATISTICS IO ON;
SET STATISTICS TIME ON;
```

Record the `logical reads`, CPU time, and elapsed time.

> Do not invent benchmark numbers. Populate the table with a representative volume, execute the query, and paste the real values into the comparison table below.

## Optimization

Create the covering access-path index:

```sql
CREATE INDEX IX_SalesOrder_OrderDate_Customer
ON dbo.SalesOrder(OrderDate)
INCLUDE(CustomerId, TotalAmount);
```

Then rewrite the filter as a half-open range:

```sql
WHERE o.OrderDate >= @StartDate
  AND o.OrderDate < @EndDate
```

This preserves datetime precision and gives the optimizer a direct range predicate on the indexed column.

## After

Capture the actual plan again and compare:

- Index Scan vs Index Seek / more selective access.
- Filter cost and row counts.
- Logical reads.
- CPU time.
- Elapsed time.
- Estimated vs actual row counts.
- Key Lookup presence/absence where relevant.

## Before/after evidence table

| Metric | Before | After |
|---|---:|---:|
| Logical reads | _capture_ | _capture_ |
| CPU time | _capture_ | _capture_ |
| Elapsed time | _capture_ | _capture_ |
| Dominant access operator | _capture_ | _capture_ |
| Estimated rows | _capture_ | _capture_ |
| Actual rows | _capture_ | _capture_ |

## What this demonstrates

1. Performance work starts from an execution plan and workload characteristics, not from blindly adding indexes.
2. SARGability matters because the predicate determines whether an index can be used efficiently.
3. A covering index can reduce additional lookups when the output columns are included.
4. The correct result must remain identical after optimization.
5. Benchmark numbers are workload-specific and therefore must be measured rather than fabricated.

## Production considerations

Before adding an index in production, evaluate write amplification, storage, index maintenance, selectivity, statistics, parameter sensitivity, and the complete workload. A query can be fast in isolation while an index makes the overall system slower.

## Screenshot checklist

Save the actual screenshots under `execution-plans/`:

- `01-before-plan.png`
- `02-after-plan.png`
- `03-before-statistics.png`
- `04-after-statistics.png`

The screenshots should visibly show the database name/query, execution operators, and relevant metrics. Do not use fabricated or illustrative plans as proof of measured performance.

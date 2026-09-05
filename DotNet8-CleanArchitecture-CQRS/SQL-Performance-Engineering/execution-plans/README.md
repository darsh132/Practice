# Execution Plan Evidence

This directory is intentionally a **capture area for real SQL Server evidence**.

## How to capture

1. Run `00-schema-and-seed.sql` against SQL Server.
2. Open `03-query-tuning-lab.sql` in SQL Server Management Studio.
3. Enable **Include Actual Execution Plan** (`Ctrl+M`).
4. Run the BEFORE query.
5. Save a screenshot of the graphical plan as `01-before-plan.png`.
6. Record the Messages tab output from `STATISTICS IO/TIME` as `03-before-statistics.png`.
7. Run the index creation and AFTER query.
8. Save the graphical plan as `02-after-plan.png`.
9. Save the Messages tab evidence as `04-after-statistics.png`.
10. Update `query-tuning-writeup.md` with the measured numbers.

## Review criteria

A strong evidence screenshot should make it possible for a reviewer to identify:

- the query being executed;
- the dominant access operator;
- index usage;
- estimated and actual row counts;
- relative operator cost;
- logical reads and CPU/elapsed time where applicable.

**Important:** The repository does not fabricate screenshots or benchmark numbers. Actual execution-plan evidence must come from an executed SQL Server workload.

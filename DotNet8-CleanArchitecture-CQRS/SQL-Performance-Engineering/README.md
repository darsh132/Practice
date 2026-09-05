# SQL Performance Engineering Portfolio

A production-style SQL Server portfolio demonstrating complex querying, stored procedures, indexing, execution-plan analysis, and evidence-driven query tuning.

## Evidence map

| Requirement | Evidence |
|---|---|
| Multi-table joins | `01-complex-queries.sql` |
| CTEs | `01-complex-queries.sql` |
| Window functions | `01-complex-queries.sql` |
| Indexed stored procedure | `02-indexed-stored-procedure.sql` |
| Query tuning before/after | `03-query-tuning-lab.sql` + `query-tuning-writeup.md` |
| Execution plan capture | `execution-plans/README.md` |
| SQL certification | HackerRank SQL Advanced or Oracle Dev Gym Performance certificate |

## Database

The scripts target **SQL Server 2022+** syntax where practical. The examples use a small sales/order domain:

`Customer -> SalesOrder -> SalesOrderItem -> Product -> ProductCategory`

The tuning lab deliberately starts with a non-sargable predicate and then introduces an appropriate index and sargable predicate. Capture the **Actual Execution Plan** in SQL Server Management Studio before and after the change.

## Run order

1. `00-schema-and-seed.sql`
2. `01-complex-queries.sql`
3. `02-indexed-stored-procedure.sql`
4. `03-query-tuning-lab.sql`
5. Follow `execution-plans/README.md` to capture actual plan screenshots.

## What a reviewer should look for

- Join predicates are explicit and indexed foreign keys are considered.
- CTEs are used to make multi-stage analytical logic readable rather than as a claim that CTEs inherently improve performance.
- Window functions solve ranking, running totals, and latest-row problems without procedural loops.
- Stored procedure filtering is parameterized and the supporting index follows the access pattern.
- Query tuning decisions are justified from execution-plan evidence, not from elapsed time alone.
- Before/after comparison considers logical reads, CPU/time, row estimates, and operator changes.

## Certification evidence

Two official options are included in the root write-up:

- HackerRank **SQL Advanced Skills Certification**: complete the verified assessment and add your personal certificate URL to `certifications.md`.
- Oracle Dev Gym **Databases for Developers: Performance**: complete the free course and certificate, then add the certificate/profile URL to `certifications.md`.

Do not commit a certificate belonging to another person. Replace the placeholders in `certifications.md` with your own verified evidence after completion.

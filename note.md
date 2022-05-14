#### TOP 10 for building efficient Queries
  - favor set-based logic over precedural or cursor logic
  - test Query variations for performance
  - avoid Query hints (use Query Optimizer)
  - Do not use correlated subqueries to improve performance (use EXISTS)
  - avoid using a scalar user-defined function in WHERE clause
  - Use table-valued  user-defined  functions as derived  tables
  - Avoid unnecessary  GROUP BY columns (correlated scalar subquery)
  - Use CASE  expressions to include variable logic in a query
  - Divide  joins into temporary  tables when you query very large tables
  - Refactoring Cursors into Queries


####
    Best Practices
    Use views to abstract complex data structures
    •Use views to encapsulate aggregate queries
    •Use views to provide more user-friendly column names
    •Think of reusability when designing views
    •Avoid using the ORDER BY clause in views that contain a TOP 100 PERCENT clause.
    •Utilize indexes on views that include aggregate data
    
    
#### 
    •Avoid using “sp_” as name prefix
    •Avoid stored procedures that accept parameters for table names
    •Use the SET NOCOUNT ON option in stored procedures
    •Limit the use of temporary tables and table variables in stored procedures
    •If a stored procedure does multiple data modification operations, make sure to enlist them  in a transaction.
    •When working with dynamic T-SQL, use sp_executesqlinsteadof the EXEC statement
    
#### Transaction Log
  - log records produced during the logging process
  - important when recovery
 
#### CONSTRAINTS (table constraints or column constraints)
  - NOT NULL
  - UNIQUE
  - PRIMARY KEY
      - Composite primary key is a table constraint    
  - FOREIGN KEY
      - ON DELETE
          - NO ACTION: deletion fails with error message
          - CASCADE: the row referenced by FK will be deleted as well
          - SET NULL: the row referenced by FK will be deleted as well and set NULL
          - SET DEFAULT: the row referenced by FK will be deleted as well and set default
  - Check constraints
  - Check constraints

#### INTEGRITY
  - Domain Integrity: check(age>18)
  - Entity Integrity: PK
  - Referential Integrity: FK


#### Normalization
   - Database Normalization is a process of organizing data to minimize redundancy
   - steps
      - first: all atomic values (not list values) one value one cell, no repeating groups
      - second: no partial dependency (seperate employee table and manager table)
      - third: No Transitive Dependency (any column can be generated from other columns)

#### EXCEPTION HANDLING
    BEGIN TRY
        SELECT 1/0;
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE();
    END CATCH
    
#### IDENTITY 
   - surrogate key: a unique, primary key
   - identity(1,3): 1,4,7..

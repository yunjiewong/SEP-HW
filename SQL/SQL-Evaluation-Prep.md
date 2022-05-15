<h2 align='center'> SQL Evaluation Prep </h2>

#### 1.What is index; types of indices; pros and cons
    - simply put,index is a pointer to data, to find data in a table without scanning the entire table
    - types: clustered and nonclustered indexes
    - pros: easy retrieval of data
    - cons: additional disk space, make insert, update, delete slower
    
#### 2. What's the difference between Primary key and Unique constraint?
    - PK is unique and not null by default, and there is only one PK in a table
    - Unique: constraint the data to be unique, only one NULL value allowed, can be many unique constraints in a table
    
#### 3. Tell me about check constraint
    - check constraints enforce  domain integrity by limiting the values that are accepted by a column 
    
#### 4.Difference between temp table and table variable
    - Life scope:  temp table can be local or global, table variable is valid in a batch
    - temp table is for large data, table variable is for small data
    - usage: temp table cannot used in strored procedures and functions, table variable can
    - structure: temp table can create index and constraint except FK, table variable can not
    
#### 5. Difference between WHERE and HAVING
    - where filters data from the table, having filters data from groups
    - where cannot filter by aggregate functions, haivng can
    - where can use with Select, Update and Delete
    - haivng can only use with Select

 #### 6. Difference between RANK() and DenseRank() — value gap
    - rank() has a value gap (1,2,2,4 catch up with row number) 
    - denseRank() doesn't have a value gap (1,2,2,3..)
    
 #### 7. COUNT(*) vs. COUNT(colName)
    - COUNT(*): count all rows in a table including NULL values
    - count(colName): count all rows in a column excluding the NULL value
    
 #### 8.What's the difference between left join and inner join? JOIN and Subquery, which one has a better performance, why?
    - inner join only returns rows that have matching value in both table
    - Left join: returns all rows in a left table
    
    - join can only be used in From clause, subquery can be used in Select, From, Where, Group By, Order By clauses
    - Join has a better performance typically
    
 #### 9. What is correlated subquery
     - inner query is dependent on outer query
     
 #### 10.What is a CTE, why do we need CTE?  
    - CTE: common table expression
    - allow to define a temporary named result set that available temporarily in the execution scope 
    - improve readability and maintenance easier
  
 #### 11. What does SQL Profiler do?
    - an interface to create and manage traces and analyze and replay trace results
    
 #### 12. What is SQL injection, how to avoid SQL injection?
    - SQL injection: ask users to insert values
    - avoid injection: injection via parameter, stored procedure
    
 #### 13.Difference between SP and user defined function? When to use SP when to use function? 
    - usage: SP is for DML statements, UDF function is for calculations
    
    - calling: SP uses EXEC, UDF requires query and input parameter
    - input: SP can have one or more, UDF must have one
    - output: SP can have one or more, UDF don't have output parameter but UDF must return value or table 
    - SP can call UDF, UDF cannot call SP
    - can use transaction in SP, not in UDF
    - can use exception handling in SP,not in UDF
    
 #### 14. Criteria of Union and Union all? Difference between UNION and UNION ALL
    - Criteria: must have same column number and data type related to that column
    - difference: 
        - union all have duplicate rows, union deletes duplicates
        - union the data is sorted automatically, union all is not
        - union all can use with recursive CTE, union can not
    
    
 #### 15. Steps you take to improve SQL Queries
    -  favor set-based logic over precedural or cursor logic
    -  test Query variations for performance
    -  avoid Query hints (use Query Optimizer)
    -  Do not use correlated subqueries to improve performance (use EXISTS)
    -  avoid using a scalar user-defined function in WHERE clause
    -  Use table-valued user-defined functions as derived tables
    -  Avoid unnecessary GROUP BY columns (correlated scalar subquery)
    -  Use CASE expressions to include variable logic in a query
    -  Divide joins into temporary tables when you query very large tables
    -  Refactoring Cursors into Queries

 #### 16.concurrency problem in transaction 
     - dirty reads: Reading the data written by an uncommitted transaction 
        - the uncommitted transaction might roll back later
     - lost update: multiple transactions execute concurrently and updates from one or more transactions get lost
     - non-repeatable reads: different values of the same variable in its different read operations even when it has not updated its value
     - phantom reads:  a transaction reads some variable from the buffer and when it reads the same variable later, it finds that the variable does not exist
 
 #### 17.what is deadlock, how to prevent
    - when two or more processes lock the separate resources. each process cannot continue and wait for others to release the resource
    - how to prevent:
        - keep transaction short
        - Create a covering index to reduce the possibility of a deadlock
 
 #### 18. what is normalization, 1NF - BCNF, benefits using normalization
    - normalization: a process of organizing data to minimize redundancy
    - pros: data consistency, save disk space
    - 1NF: all atomic values
    - 2NF: no partial dependency
    - 3NF: no transitive dependency
    - BCNF: stricter version of 3NF

    
 #### 19.what are the system defined databases?
    - master, tempdb, model, msdb
 #### 20.composite key
    - combine two or more columns used to uniquely identify each row in a table
  
 #### 21. candidate key
    - unique can be used as candidate key
 #### 22.DDL vs. DML --
    - DDL: data defination Language
    - DML: data manipulation language
    
 #### 23.ACID property
    - Atomicity: the entire transaction happens at once or never happens at all
    - Consistency: the database must be consistent before and after the transaction
    - Isolation: multiple transaction occurs independently without interference
    - Durability: the changes of a successful transaction occurs even if the system failure occurs
    
 #### 24. table scan vs. index scan. --
    - table scan: search for condition-satisfied data according to insertion order
    - index scan: search for condition-satisfied data according to index page order  ....
 #### 25.Difference between Union and JOIN
    - Union: combine data vertically (new rows)
    - Join: combine data horizontally (new columns)

 
 

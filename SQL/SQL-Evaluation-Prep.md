<h2 align='center'> SQL Evaluation Prep </h2>

#### 1.What is index; types of indices; pros and cons
  - index is 
  - types: clustered and nonclustered indexes
  - pros: easy retrieval of data
  - cons: take up memories
#### 2. What's the difference between Primary key and Unique constraint?
  - PK is unique and not null by default, and there is only one PK in a table
  - Unique: constraint the data to be unique, can be many unique constraints in a table
#### 3. Tell me about check constraint
  - check domain integrity
#### 4.Difference between temp table and table variable
  - Life scope: 
    - temp table can be local or global
    - table variable is valid in a batch
#### 5. Difference between WHERE and HAVING
  - where: 
  - Having: aggregate function

 #### 6. Difference between RANK() and DenseRank() — value gap
  - rank() doesn't catch up with row numbers
 #### 7. COUNT(*) vs. COUNT(colName)
  - COUNT(*): count all rows in a table including NULL values
  - count(colName): count all rows in a column excluding the NULL value
 #### 8.What's the difference between left join and inner join? JOIN and Subquery, which one has a better performance, why?
  - inner join only returns rows that have matching value in both table
  - Left join: returns all rows in a left table
  - subquery has a better performance
 #### 9. What is correlated subquery
  - inner query is dependent on outer query
 #### 10.What is a CTE, why do we need CTE?
  - CTE: common table expression
  - readability
  
 #### 11. What does SQL Profiler do?
  - an interface to create and manage traces and analyze and replay trace results
 #### 12. What is SQL injection, how to avoid SQL injection?
  - SQL injection: ask users to insert values
  - avoid injection: use string 
 #### 13.Difference between SP and user defined function? When to use SP when to use function?
 
 #### 14. Criteria of Union and Union all? Difference between UNION and UNION ALL
  - Criteria: must have same column number and data type related to that column
  - difference: union all have duplicate rows, union deletes duplicates
 #### 15. Steps you take to improve SQL Queries
  - 1. all atomic values
  - 2. no partial dependency
  - 3. 
  
 #### 16.concurrency problem in transaction
 
 #### 17.what is deadlock, how to prevent
 
 #### 18. what is normalization, 1NF - BCNF, benefits using normalization
 
 #### 19.what are the system defined databases?
  - master, tempdb, model, msdb
 #### 20.composite key
  - combine two or more columns used to uniquely identify each row in a table
  
 #### 21. candidate key
  - unique can be used as candidate key
 #### 22.DDL vs. DML
  - DDL: data defination Language
  - DML: data manipulation language
 #### 23.ACID property
  - Atomicity 
  - Concurrency
  - Isolation
  - Durability
 #### 24. table scan vs. index scan
  - table scan: search for condition-satisfied data according to insertion order
  - index scan: search for condition-satisfied data according to index page order  ....
 #### 25.Difference between Union and JOIN
  - Union: combine data vertically (new rows)
  - Join: combine data horizontally (new columns)

 
 

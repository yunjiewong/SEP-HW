<h2 align="center"> </h2>


#### SQL
--basic query: select, where, order by, join, aggregation function, having, 
--advanced topics: subquery, cte, window function, pagination
--temp tables, table variables, views, sp, user defined functions, normalization
identity


--Delete vs. Truncate
--1) DELETE is a DML statement, will not reset identity; but Truncate is a DDL statement, will reset the identity


--transaction: a group of logically related DML statements that will either succeed together or fail together
--three mode of transactions:
--autocommit transaction: default
--implicit transaction
--explicit transaction

--properties of transactions
/*ACID
A: Atomicity -- work is atomic
C: Consistency -- whatever happends in the middle of the transaction, this property will never leave your db in half-completed state
I: Isolation -- two transactions will be isolated from each other by locking the resource
D: Durability -- once the transaction is completed, then the changes it has made to the db will be permanent



concurrency occurs when two or more transactions are trying to access the same data or info
1. dirty reads:
	t1 allows t2 to read uncommitted data and then t1 rolled back
	caused by isolation level read uncommitted
	solved by isolation level read committed
2. lost update
	t1 and t2 read and update the same data but t2 finish its work earlier than t1, then t2 will lost their update
	caused by isolation level read committed
	solved by isolation level repeatable read
3. non repeatable read
	t1 read the same data twice while t2 is updating the data
	caused by isolation level read committed
	solved by isolation level repeatable read
4. phantom read
	t1 reads the same data twice while t2 is inserting records
	cuased by isolation level repeatable read
	solved by isolation level serializable
*/


--Pros: index will help us improve retrieving speed -- improve performance of select
--Cons: slow down other DML statements, extra space


--performance tuning
--1. look at the execution plan
--2. choose index wisely
--3. avoid unnecessary joins
--4. avoid SELECT *
--5. JOIN to replace subquery
--6. derived table to avoid a lot of grouping by


--Pagination:
--OFFSET: skip
--FETCH: select


#### day9: LINQ, 

deferred execution,immediate excution
Deferred execution can greatly improve performance when you have to manipulate large data collections.

query variable only store query commands

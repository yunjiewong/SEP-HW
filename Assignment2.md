<h2 align="center"> Assignment 2</h2>

#### Difference between WHERE and HAVING?

    - Where applies to individual rows ,having applies to groups
    - where cannot filter by aggregate functions, having can
    - where can be used with select, update, delete, having can only be used with select

#### 	Difference between RANK() and DenseRank()
    -  They are similar to row_number
    -  Rank will keep the ranking like 1,2,2,4,etc denseRank will never give any gaps like 1,2,2,3


#### 	What is correlated subquery?
    -  Subquery where inner query is dependent on the outer query

####	Criteria of Union and Union all?
    - same number of columns
    - Same data type associated with the column number

####	Difference between UNION and UNION ALL
    - Union removes duplicates, union all will not
    - union the records from the first column is sorted automatically, union all does not
    - union can not be used with recursive CTE, union all can


####	Difference between Union and JOIN
    - Join combines data into new column
    - Union combines data vertically



#### use AdventureWorks2019
 

#### 1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables
    Select c.Name as Country, p.Name as Province
    From Person.CountryRegion c Join Person.StateProvince p
    ON c.CountryRegionCode = p.CountryRegionCode

#### 2. Write a query that lists the country and province names from person.
    Select c.Name as Country, p.Name  as Province
    From Person.CountryRegion c Join Person.StateProvince p
    ON c.CountryRegionCode = p.CountryRegionCode and c.name in ('Germany', 'Canada')
    order by c.name 




####use Northwind


#### 3.List all Products that has been sold at least once in last 25 years.
    Select distinct p.ProductName, o.OrderDate
    From dbo.Products p join dbo.[Order Details] od on p.ProductID = od.ProductID
    Join dbo.orders o on od.OrderID = o.orderID
    where o.OrderDate >= DATEADD(year, -25,'2022')
    ORDER by o.OrderDate

#### 4.list top 5 locations (Zip Code) where the products sold most in last 25 years.
    SELECT top(5) SUM(od.Quantity) [total sold], o.ShipPostalCode
    From dbo.[Order Details] od join dbo.Orders o on od.OrderID = o.OrderID
    where o.OrderDate >= DATEADD(year, -25,'2022')
    GROUP by o.ShipPostalCode
    ORDER by  [total sold] desc



#### 5.List all city names and number of customers in that city.     
    Select city, count(CustomerID) as [number of customer]
    From dbo.customers c
    Group by city
    ORDER by [number of customer] desc

#### 6. List city names which have more than 2 customers, and number of customers in that city
    Select city, count(CustomerID) as [number of customer]
    From dbo.customers c
    Group by city 
    HAVING count(CustomerID) >2
    ORDER by [number of customer] desc

#### 7. Display the names of all customers  along with the  count of products they bought
    Select c.ContactName,sum(od.Quantity) [total product]
    From dbo.Customers c Join dbo.Orders o On c.CustomerID = o.CustomerID
    JOIN dbo.[Order Details] od On od.OrderID=o.OrderID
    group by c.ContactName
    ORDER by [total product] desc

#### 8.Display the customer ids who bought more than 100 Products with count of products.
    SELECT o.CustomerID, sum(od.Quantity) [total product]
    From dbo.[Orders] o Join dbo.[Order Details] od On o.OrderID=od.OrderID
    Group by o.CustomerID
    having sum(od.Quantity) >100
    order by [total product] desc

#### 9. List all of the possible ways that suppliers can ship their products. Display the results as below
    Select s.CompanyName [Supplier Company Name], sh.CompanyName [Shippping Company Name]
    From dbo.Suppliers s cross join dbo.Shippers sh
    order by[Supplier Company Name]

#### 10.Display the products order each day. Show Order date and Product Name.
    SELECT p.ProductName, cast(o.OrderDate as date)[Order date]
    From dbo.Products p Join dbo.[Order Details] od on p.ProductID = od.ProductID
    Join dbo.Orders o on o.OrderID = od.OrderID
    ORDER by o.OrderDate

#### 11.Displays pairs of employees who have the same job title.
    SELECT dt.[employee1], dt.[employee2]
    from (SELECT e1.FirstName +' '+ e1.LastName as employee1, e2.FirstName+' ' +e2.LastName as employee2, e1.Title
    From dbo.Employees e1 cross join dbo.Employees e2
    where e1.Title = e2.Title ) dt
    where dt.[employee1] > dt.[employee2]

#### 12.Display all the Managers who have more than 2 employees reporting to them.
    SELECT e1.FirstName +' '+ e1.LastName as manager, count(e2.ReportsTo) as [number of employees]
    From  dbo.Employees e1 left join dbo.Employees e2 on e1.EmployeeID =e2.ReportsTo
    group by e1.FirstName +' '+ e1.LastName
    having count(e2.ReportsTo) >2

#### 13.Display the customers and suppliers by city. The results should have the following columns
    SELECT c.City, c.ContactName, c.CompanyName,'Customers'
    From dbo.Customers c 
    UNION
    SELECT s.City, s.ContactName, s.CompanyName,'Suppliers'
    From dbo.Suppliers s

#### 14. List all cities that have both Employees and Customers.
    SELECT distinct e.city
    From dbo.Employees e join dbo.Customers c on e.City = c.City

#### 15.List all cities that have Customers but no Employee. use subqueries and don't use
    SELECT city
    From dbo.Customers
    EXCEPT
    SELECT city
    From dbo.Employees

    SELECT  distinct City
    From dbo.Customers 
    where City not in (select city from dbo.Employees)

#### 16.List all products and their total order quantities throughout all orders.
    SELECT p.ProductName, sum(od.Quantity) [total order quantities]
    From dbo.Products p join dbo.[Order Details] od on p.ProductID =od.ProductID
    GROUP by p.ProductName
    ORDER by [total order quantities] desc

#### 17.List all Customer Cities that have at least two customers. union and subquerry

    SELECT city
    From dbo.Customers 
    group by City
    having count(city) >2
    union
    SELECT city
    From dbo.Customers 
    group by City
    having count(city) =2

    SELECT distinct City 
    from dbo.Customers 
    where City in (Select City From dbo.Customers Group By City Having count(city) >=2)

    SELECT city
    From dbo.Customers 
    group by City
    having count(city) >=2

#### 18. List all Customer Cities that have ordered at least two different kinds of products.
    SELECT City, count(distinct(od.ProductID)) [product types]
    From dbo.Customers c join dbo.Orders o on c.CustomerID=o.CustomerID
    join dbo.[Order Details] od on od.OrderID=o.OrderID
    GROUP by City
    having count(distinct(od.ProductID)) >= 2

#### 19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
    SELECT top(5) ProductID, AVG(UnitPrice) [avgPrice],
    (select top(1) City
     from customers c join Orders o on o.customerID = c.customerID
     join [Order Details] od2 on od2.orderID = o.orderID 
     where od2.ProductID = od1.ProductID
     GROUP by city
     order by sum(quantity) desc
    ) as City
    FROM dbo.[Order Details] od1
    GROUP BY ProductID
    ORDER BY sum(quantity) desc

#### 20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordere from. (tip: join  sub-query)

    SELECT top(1) e.city
    From dbo.Orders o join dbo.[Order Details] od on o.OrderID=od.OrderID
    join dbo.Employees e on e.EmployeeId = o.EmployeeId
    where e.city in (
      SELECT top(1) ShipCity
      From dbo.Orders 
      GROUP by ShipCity
      ORDER by ShipCity desc
    )





#### 21. How do you remove the duplicates record of a table?
    -- Find duplicate rows using GROUP BY clause or ROW_NUMBER() function.
    -- Use DELETE statement to remove the duplicate rows.

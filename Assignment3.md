<h2 align="center"> Assignment 3</h2>

#### 1.  Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
    CREATE VIEW view_product_order_wang AS(
        SELECT p.ProductName, p.ProductID, sum(od.Quantity) [Total Quantity]
        FROM Products p 
        JOIN [Order Details] od ON p.ProductID = od.ProductID
        GROUP BY p.ProductName, p.ProductID
    )

#### 2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.
    CREATE PROC sp_product_order_quantity_wang
    @productID INT,
    @quantity INT OUT
    AS
    BEGIN
        SELECT @quantity = v.[Total Quantity]
        FROM view_product_order_wang v
        WHERE v.productID = @productID
    END
    
    - For result:
    DECLARE @quantity INT 
    exec dbo.sp_product_order_quantity_wang @productID =23, @quantity =  @quantity out
    print @quantity 

#### 3.Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.

    CREATE PROC sp_product_order_city_wang
    @productName NVARCHAR(30)
    AS
    BEGIN
        SELECT TOP(5)  c.city, SUM(od. Quantity)[Quantity]
        FROM Products p
        JOIN [Order Details] od ON od.ProductID =p.ProductID
        JOIN Orders o ON o.OrderID=od.OrderID
        JOIN Customers c ON c.CustomerID =o.CustomerID
        WHERE p.ProductName = @productName
        GROUP BY c.City
        ORDER BY SUM(od. Quantity) DESC
    END
    
     - For result:
     DECLARE @city NVARCHAR(30), @quantity INT
     EXEC dbo.sp_product_order_city_wang 'Alice Mutton'

#### 4.      Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. Create a view “Packers_your_name” lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.

    -- create 2 new tables
    CREATE TABLE city_your_wang(
        Id int, city NVARCHAR(30))
    GO
    INSERT city_your_wang values(1,'Seattle'),(2, 'Green Bay')

    CREATE TABLE people_your_wang(
        Id int, name NVARCHAR(30), city int)
    GO
    INSERT people_your_wang values(1,'Aaron Rodgers',2),(2, 'Russell Wilson',2),(3,'Jody Nelson',2)

    -- update data
    IF EXISTS(
        SELECT p.*
        FROM city_your_wang c
        JOIN people_your_wang p
        ON c.Id = p.city
        Where c.city = 'Seattle'
    )
    BEGIN
        UPDATE city_your_wang 
        SET city = 'Madison'
        WHERE city = 'Seattle'
    END
    ELSE
    BEGIN
        DELETE FROM city_your_wang
        WHERE city = 'Seattle'
    END
   
    -- create view
    CREATE VIEW Packers_your_name AS(
        SELECT p.name
        FROM people_your_wang p 
        JOIN city_your_wang c ON c.Id = p.city
        WHERE c.city = 'Green Bay'
    )
    GO
    SELECT * FROM Packers_your_name
    
    -- drop tables and view
    DROP TABLE city_your_wang, people_your_wang
    DROP VIEW Packers_your_name



#### 5.       Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.

    CREATE PROC sp_birthday_employees_wang 
    AS
    BEGIN
        CREATE TABLE birthday_employees_wang(EmpName NVARCHAR(30), BirthDate DATE)
        INSERT birthday_employees_wang
            SELECT e.FirstName +' '+LastName, e.BirthDate
            FROM Employees e
            WHERE Month(e.BirthDate) = 2
    END
    
    GO
    EXEC sp_birthday_employees_wang
    SELECT * from birthday_employees_wang
    SELECT * from Employees

    DROP TABLE birthday_employees_wang
    DROP PROC sp_birthday_employees_wang
    
<img src ="https://github.com/yunjiewong/SEP-HW/blob/main/image.png" width =800 > 

#### 6. How do you make sure two tables have the same data?
    If two tables have no duplicates, then just do 
    SELECT * FROM TABLE1 EXCEPT SELECT * FROM TABLE2 
    IF there is no error message and return nothing, then two tables have same data and vice versa.
    
    If two tables have duplicates, then do
    TABLE1 UNION TABLE2 EXCEPT TABLE1 INSERTSECT TABLE2
    IF there is no error message and return nothing, then two tables have same data and vice versa.
    
  

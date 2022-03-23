use Northwind
SELECT ProductID, ProductName, UnitPrice
FROM PRODUCTS WHERE SupplierID IN
(SELECT SupplierID
FROM Suppliers
WHERE CITY='NEW York')

SELECT ProductID, ProductName, SupplierID,UnitPrice
FROM Products
WHERE UnitPrice > ALL
(Select UnitPrice
FROM Products
WHERE SupplierID=10098)

--Exists
SELECT SupplierID
FROM suppliers
WHERE EXISTS
(select 'A'
from orders
where suppliers.SupplierID = orders.SupplierID);
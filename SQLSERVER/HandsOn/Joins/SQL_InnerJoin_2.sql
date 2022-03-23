USE northwind
GO

SELECT ProductID, ProductName, CategoryName
FROM Products, Categories
WHERE Products.CategoryID=Categories.CategoryID
GO
SELECT categoryname, description,
productname, productid, companyname, suppliers.city
FROM products, categories, suppliers
WHERE Products.categoryid = Categories.categoryid
AND Products.supplierid = Suppliers.supplierid
AND Suppliers.city = 'London'
ORDER by productname
GO
SELECT categoryname, description,
productname, productid, companyname, suppliers.city
FROM products join categories on Products.CategoryID=Categories.CategoryID 
join Suppliers on Products.supplierid = Suppliers.supplierid
WHERE Suppliers.city = 'London'
ORDER by productname
SELECT categoryname, description,
productname, productid
FROM CATEGORIES
LEFT OUTER JOIN PRODUCTS
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO
--Right outer join
SELECT categoryname, description,
productname, productid
FROM CATEGORIES
RIGHT OUTER JOIN PRODUCTS
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO
--Full outer JOin
USE Northwind;
GO
SELECT categoryname, description,
productname, productid
FROM CATEGORIES
FULL OUTER JOIN PRODUCTS
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO
create database retail_details;

use retail_details;
Go

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 1200.00),
(2, 'Smartphone', 'Electronics', 800.00),
(3, 'Tablet', 'Electronics', 600.00),
(4, 'Headphones', 'Accessories', 150.00);

insert into products (ProductID,ProductName,Category,Price)
values
(5, 'Wired Earphones', 'Electronics', 50.00),
(6, 'Smartwatch', 'Electronics', 300.00),
(7, 'VR Headset', 'Electronics', 450.00);

select * from products;

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS row_num
    FROM Products
) AS Ranked
WHERE row_num <= 3;

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS rank_ord
    FROM Products
) AS Ranked
WHERE rank_ord <= 3;

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS dense_rank_ord
    FROM Products
) AS Ranked
WHERE dense_rank_ord <= 3;


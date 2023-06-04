CREATE TABLE dbo.Products (
    ProductId BIGINT NULL,
    ProductName NVARCHAR(50) NOT NULL
);

CREATE TABLE dbo.Categories (
    CategoryId BIGINT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    CategoryName NVARCHAR(50) NOT NULL
);

INSERT INTO [dbo].[Products]
			([ProductId]
			,[ProductName])
	VALUES 
			(2,	'������'),
			(3,	'������'),
			(2,	'���'),
			(3,	'���'),
			(2,	'��������'),
			(3,	'��������'),
			(2,	'�������'),
			(3,	'�������'),
			(NULL,	'������'),
			(NULL,	'����'),
			(NULL,	'������'),
			(3,	'�������'),
			(1,	'������� ���'),
			(3,	'������� ���'),
			(NULL,	'�������');

INSERT INTO [dbo].[Categories]
			([CategoryName])
	VALUES 
			('������'),
			('������'),
			('�����-����');

SELECT Products.ProductName, Categories.CategoryName
FROM Products LEFT JOIN Categories
ON Products.ProductId = Categories.CategoryId
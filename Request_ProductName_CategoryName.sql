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
			(2,	'Гречка'),
			(3,	'Гречка'),
			(2,	'Рис'),
			(3,	'Рис'),
			(2,	'Макароны'),
			(3,	'Макароны'),
			(2,	'Котлета'),
			(3,	'Котлета'),
			(NULL,	'Спрайт'),
			(NULL,	'Кола'),
			(NULL,	'Липтон'),
			(3,	'Пирожок'),
			(1,	'Грибной суп'),
			(3,	'Грибной суп'),
			(NULL,	'Сникерс');

INSERT INTO [dbo].[Categories]
			([CategoryName])
	VALUES 
			('Первое'),
			('Второе'),
			('Комбо-обед');

SELECT Products.ProductName, Categories.CategoryName
FROM Products LEFT JOIN Categories
ON Products.ProductId = Categories.CategoryId
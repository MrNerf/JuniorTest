SELECT P.ProductName, C.CategoryName FROM Product_Category PC 

LEFT JOIN Product P ON PC.FK_ProductId = P.ProductId
LEFT JOIN Category C ON PC.FK_CategoryId = C.CategoryId

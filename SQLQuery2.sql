--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City ='London'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by CategoryID,ProductName

Select * from Products where CategoryID=1 order by UnitPrice desc --asc artan --desc azalan

Select COUNT(*) from Products

Select COUNT(*) Adet from Products where CategoryID=2

Select categoryID,COUNT(*) from Products group by CategoryID having COUNT(*)<10

Select Products.ProductID,Products.ProductName
 from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID 

Select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID 

Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null

Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID 
inner join Orders o
on o.OrderID=od.OrderID






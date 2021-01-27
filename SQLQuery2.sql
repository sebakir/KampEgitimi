--Select
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers;
--Where dedikten sonra parametre girisi yapmalisin
select * from Customers where City = 'berlin'
--case insensitive büyük kucuk harf duyarsiz
select* from Products where CategoryID = 1 or CategoryID = 3
select* from Products where CategoryID = 1 and UnitPrice >= 10
--order by sıralama yapılacagında kullanılır Productname e göre sırala 
select * from Products order by ProductName
select * from Products order by CategoryID
select * from Products order by ProductName , CategoryID
select * from Products order by UnitPrice -- asc -- desc artan azalan  kullanımı 
-- where order by birlikte kullanımı
select * from Products where CategoryID = 1 order by UnitPrice desc
select count(*) Adet from Products
--Hangi kategoride kac farkli urun var ??? 
-- group by kullanıyorsan select den sonra bir parametre vermelisin...
select CategoryID, count(*) from Products group by CategoryID
--having kümilatif sorguya yazılır
select CategoryID, count(*) from Products group by CategoryID having count(*) < 10
select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10
--Join komutu kullanımı
select Products.ProductID , Products.ProductName, Products.UnitPrice , Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object
-- inner join sadece eşleşen verileri getirir iki tablo ortak kolon gibi
--inner yerine left kullanmak solda olup sagda olmayanlarıda getir demektir
Select * from  Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null -- is nol primary key e uygulanır başka bir yere uygulanmaz

--sistemimize kayıt olmuş bizden ürün almayan müşterileri getir




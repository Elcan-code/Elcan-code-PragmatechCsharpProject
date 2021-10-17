--1. --   Sales.SalesOrderHeader, Sales.SalesOrderDetail cedvellerinden istifade ederek 
--      '2011-05-31 00:00:00.000' tarixinde satis eden satis temsilcilerinin ad soyadini ve toplam lineTotal deyeri
--      getiren query yazin.


-- SalesPerson	        LineTotal
--DavidCampbell	        69472.996300
--GarrettVargas	        9109.168300
--JillianCarson	        46695.556400
--JoséSaraiva	            106251.727700
--LindaMitchell	        5475.948500
--MichaelBlythe	        63762.922800
--PamelaAnsman-Wolfe	    24432.608800
--ShuIto	                59708.320800
--TsviReiter	            104419.329100


 select pr.FirstName + pr.LastName as SalesPerson ,Sum(sd.LineTotal) LineTotal 
 from Sales.SalesOrderHeader so
 join Person.Person pr 
 on pr.BusinessEntityID=so.SalesPersonID
 join Sales.SalesOrderDetail sd
 on so.SalesOrderID=sd.SalesOrderID
 where so.OrderDate= '2011-05-31 00:00:00.000'
 group by pr.FirstName,pr.LastName
 order by pr.FirstName


--2.
-- /*
-- Store procudure examples 

-- 2.a Person Cedveli yaradin (Id,Name,Surname,Status,Gender,CreateDate) 

-- 2.b Person cedveline AdventureWorks db-dan data insert eden proc yaradilmalidir.

-- 2.c PersonCedveli ucun asagidakilara uygun proc-lar yaradilmalidir.
-- Add (insert edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
-- Update (update edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
-- Delete

-- GetById (parametr olaraq id deyeri daxil edilecek)
-- GetAll (parametr almayacaq)
-- GetAll (Gender deyeri qebul ederse daxil edilen deyere esasen filter olacaq, daxil edilmezse 'M' ve ya 'F' olanlar getirilecek )
-- GetByEmail (parametr olaraq email deyeri daxil edilecek)
-- */

create table person (
Id int primary key,
[Name] nvarchar(50),
Surname nvarchar(50),
[Status] nvarchar(50),
Gender char(1),
CreateDate datetime default getdate(),
);

--Add Db

 create proc DataAdd 
 as
 begin
 insert into person(Id,[Name],SurName,Gender,[Status])
 select pr.BusinessEntityID,pr.FirstName,pr.LastName,ep.Gender,ep.JobTitle
 from Person.Person pr
 inner join HumanResources.Employee ep
 on pr.BusinessEntityID=ep.BusinessEntityID
 end
 exec DataAdd
 select * from person

 --Add

 create proc dbadddata(
 @id int,
 @name nvarchar(50),
 @surname nvarchar(50),
 @status nvarchar(50),
 @gender char='M'
 )
 as 
 begin
 insert into Person
 (Id,[Name],SurName,[Status],Gender)
 values
 (@id,@name,@surname,@status,@gender)
 exec GetById @id=@id
 end

-- GetById

 create proc GetById(@id int)
as
begin
select * from Person where Id = @id
end

--GetAll

create proc GetAll
as
begin 
select * from Person
end

--GetAllGender

create proc GetAllGender(@gender char(1)='M')
 as 
 begin
 select * from Person where Gender=@gender
  end
  exec GetAllGender

  --EmailGet

  create proc Email(@email nvarchar(50))
 as 
 begin
 select * from Person
  end

  --update

  create proc [Update](
 @id int,
 @name nvarchar(50),
 @surname nvarchar(50),
 @status nvarchar(50),
 @gender char='M'
 )
 as 
 begin
 update Person set
 [Name]=@name,SurName=@surname,[Status]=@status,Gender=@gender
 where Id=@id
 exec GetById @id=@id
 end

 --Delete

 create proc [Delete](@id int)
 as
 begin
 delete Person where Id=@id
 
 end







-- 3.
-- /*
-- Store procudure examples 

-- Person Cedveli yaradin (Id,Name,Surname,Status,CreateDate) 

-- PersonCedveli ucun asagidakilara uygun tek proc yaradilmalidir.
-- Yaradilan proc-a verilen uygun keyword-e gore Add,Update,Delete,GetAll emeliyyatlarini
-- yerine yetirmelidir.
-- Add (insert edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
-- Update (update edilen row-un idsi output olaraq GetById proc-a oturulmelidir)
-- Delete
-- GetAll
-- */
Create table Person2
(Id int primary key,
[Name] nvarchar(50),
Surname nvarchar(50),
[Status] nvarchar(50),
CreateDate datetime default getdate(),
)

Create proc Crud(@KeyWord nvarchar(10))
as
begin
if @KeyWord='Add'
begin
insert into Person
 (Id,[Name],SurName,[Status],Gender)
 values
 (10001,'Elcan','Elcan','Test','M')
 exec GetById @id=10001
 end

else if @KeyWord='Update'
begin
update Person set
 [Name]='User',SurName='User',[Status]='Test',Gender='M'
 where Id=1001
 exec GetById @id=1001
 end
else if @KeyWord='Delete'
begin
 delete Person where Id=1001
end

 else if @KeyWord='GetAll'
 begin
 select * from Person
 end
 end

-- 4.
--  /*
-- Dbdaki iscilerin 
-- Adini,Soyadini, Islediyi Departamenti , Ise baslama tarxini, mevacibinin cemini
-- getiren proc yazin

-- order by mevacibinin cemine gore desc

--  isteye gore en cox qazan en az qazan iscini
-- -- hal hazirda isden cixan butun iscileri getiren query yaza bilersiz.
 
-- */
create proc GetEmploye
as
begin
select 
pr.FirstName,pr.LastName,Sum(py.Rate),MAX(py.Rate) as [Max],MIN(py.Rate) as [Min],hd.[Name],hs.StartDate,hs.EndDate 
from Person.Person pr
join HumanResources.EmployeePayHistory py 
on py.BusinessEntityID=pr.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory hs 
on hs.BusinessEntityID=pr.BusinessEntityID
join HumanResources.Department hd on hd.DepartmentID=hs.DepartmentID
group by pr.FirstName,pr.LastName,hd.[Name],hs.StartDate,hs.EndDate 
order by Sum(py.Rate) desc
end

# Real-Time-Data-Update-Using-SignalR-And-Sql-Dependency.-
--How To Run The Project

#Stap 1
Create Database And a Table:
Execute The code on your sql database

USE master
GO
IF DB_ID('EmployeeDB') is not null
DROP database EmployeeDB
GO
CREATE DATABASE EmployeeDB
GO
USE [EmployeeDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[empId] [int] IDENTITY(1,1) NOT NULL,
	[empName] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[empId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

Step - 2
Change The connection string from Web.config

Step - 3
Run the application

Step - 4
Excute the script on your sql database:

USE [EmployeeDB]
GO
DECLARE @i INT = 1;  
 DECLARE @sal INT = 78000;  
 DECLARE @sal_increment INT = 1;  
 WHILE (@i <=20)  
  BEGIN  
  WAITFOR DELAY '00:00:02'  
  set @sal_increment=5000  
     /*Your Script*/  
 insert into Employee  
 select 'Lori_'+cast(@i as varchar),@sal+@sal_increment,'IT','Software Engineer'  
  SET @i = @i + 1;  
  SET @sal = @sal + @sal_increment;  
 END   

Step-5
Look changes on your browser!

Thanks.



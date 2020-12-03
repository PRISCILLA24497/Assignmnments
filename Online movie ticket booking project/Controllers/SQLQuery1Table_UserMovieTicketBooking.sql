/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [UserId]
      ,[UserName]
      ,[Email]
      ,[Gender]
      ,[Password]
  FROM [MovieTicket].[dbo].[Table_User]
  select * from Table_User
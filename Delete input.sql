/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[HTML]
      ,[CreatedOn]
      ,[LastEdit]
  FROM [HTMLPreviewer].[dbo].[HTMLBoxes]

  SELECT * FROM HTMLBoxes WHERE HTML NOT  LIKE '<%'

  DELETE FROM HTMLBoxes WHERE HTML NOT Like '<%';
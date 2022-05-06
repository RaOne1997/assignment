



USE [StudentPerformanceManagement]
GO

INSERT INTO [student].[student]
           ([Name]
           ,[Email]
           ,[Address]
           ,[Cource_ID])
     VALUES
       ('Abhijeet'
           ,'Abhijeet@gmail.com'
           ,'Pune'
           ,101)
GO




--insert cource

INSERT INTO [Course].[Course]
           ([Cource_Code]
           ,[Title]
           ,[Description])
     VALUES
           ('SCI001'
           ,'Science 1'
           ,'Pure Science Course')

go
		   
INSERT INTO [Course].[Course]
           ([Cource_Code]
           ,[Title]
           ,[Description])
     VALUES
           ('SCI002'
           ,'Science with Economics'
           ,'Pure Science Course with Eco')
go

		   		   
INSERT INTO [Course].[Course]
           ([Cource_Code]
           ,[Title]
           ,[Description])
     VALUES
           ('ART001'
           ,'Fine Arts'
           ,'Elementary Drawing')

GO

---------------------------------------------------------

--Insert Subject 



INSERT INTO [Course].[Subjects]
           ([Subject_Code]
           ,[Cource_id]
           ,[Title]
           ,[Description])
     VALUES
           ('PHY001'
           ,101
           ,'Physics'
           ,'Elementary Physics')
GO

INSERT INTO [Course].[Subjects]
        ([Subject_Code]
           ,[Cource_id]
           ,[Title]
           ,[Description])
     VALUES
           ('PHY002',
		  102,
		   'Modern Physics ',
           'Modern Physics')
		   go

INSERT INTO [Course].[Subjects]
          ([Subject_Code]
           ,[Cource_id]
           ,[Title]
           ,[Description])
     VALUES
           ('SKT001',
		   103,
		   'Sketching ',
           'Basic Art Sketching')

GO




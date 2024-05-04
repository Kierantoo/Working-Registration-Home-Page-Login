USE [Username/Passwords]
GO

INSERT INTO [dbo].[Users]
           ([user_name]
           ,[password]
           ,[FirstName]
           ,[LastName]
           ,[Email])
     VALUES
           (<user_name, varchar(50),>
           ,<password, varchar(50),>
           ,<FirstName, varchar(50),>
           ,<LastName, varchar(50),>
           ,<Email, varchar(50),>)
GO


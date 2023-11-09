USE [Logistic]
GO
/****** Object:  StoredProcedure [dbo].[InsertContactUs]    Script Date: 09-11-2023 11:09:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[InsertContactUs]
(
@Name varchar(25),
@Email varchar(30),
@Phone bigint,
@Message varchar(500)
)
as
begin
insert into tbl_ContactUs (Contact_Name,Contact_Email,Conatct_Phone,Conatct_Message) values(@Name,@Email,@Phone,@Message)
end
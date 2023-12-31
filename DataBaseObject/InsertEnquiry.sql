USE [Logistic]
GO
/****** Object:  StoredProcedure [dbo].[InsertEnquiry]    Script Date: 09-11-2023 11:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[InsertEnquiry]
(
@Name varchar(25),
@Email varchar(30),
@Phone bigint,
@Organization varchar(30),
@Type varchar(30),
@State varchar(30),
@City varchar(30),
@Zip bigint,
@Address varchar(50),
@Quiery varchar(500)
)
as
begin
insert into tbl_Enquiry (Enquiry_Name,Enquiry_Email,Enquiry_Phone,Enquiry_Organization,Enquiry_Type,Enquiry_State,Enquiry_City,Enquiry_Zip,Enquiry_Address,Enquiry_Quiery) 
values(@Name,@Email,@Phone,@Organization,@Type,@State,@City,@Zip,@Address,@Quiery)
end
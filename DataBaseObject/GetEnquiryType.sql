USE [Logistic]
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiryType]    Script Date: 09-11-2023 11:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[GetEnquiryType]
as
begin
select Enquiry_Type from tbl_EnquiryType
end
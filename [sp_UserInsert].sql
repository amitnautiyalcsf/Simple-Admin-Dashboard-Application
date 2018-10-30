USE [Training]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UserInsert] 
	-- Add the parameters for the stored procedure here
	@userName varchar(150),
	@password varchar(20),
	@roleName varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
Insert into TM_USERMASTER(userName,password,roleName) values(@userName,@password,@roleName)
END
GO

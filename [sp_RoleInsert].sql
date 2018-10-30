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
CREATE PROCEDURE  [dbo].[sp_RoleInsert]
	-- Add the parameters for the stored procedure here
	@roleName varchar(30),
	@roleDescription varchar(150)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into TM_ROLEMASTER(roleName, roleDescription) values(@roleName, @roleDescription)
END
GO

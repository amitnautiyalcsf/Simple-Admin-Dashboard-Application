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
CREATE PROCEDURE [dbo].[sp_RoleDelete] 
@roleName varchar(30)	
AS

BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from[TM_ROLEMASTER]
	where roleName=@roleName
END
GO

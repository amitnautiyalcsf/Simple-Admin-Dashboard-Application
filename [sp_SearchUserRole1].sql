USE [Training]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchUserRole]    Script Date: 10/22/2018 2:48:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
Create PROCEDURE [dbo].[sp_SearchUserRole1]
@userName varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TM_USERMASTER where  userName LIKE @userName+'%'
END

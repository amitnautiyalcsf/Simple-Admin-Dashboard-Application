USE [Training]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchUser]    Script Date: 10/18/2018 5:05:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[sp_SearchUserRole]
@userName varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TM_USERMASTER where userName=@userName
END

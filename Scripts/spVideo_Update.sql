USE [BlazorDapperCrudDb]
GO
/****** Object:  StoredProcedure [dbo].[spVideo_Insert]    Script Date: 2020/06/26 12:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE dbo.spVideo_Update
	-- Add the parameters for the stored procedure here
	@Id int,
	@Title varchar(128),
	@DatePublished date,
	@IsActive bit
AS
BEGIN
UPDATE       Video
SET                Title =@Title, DatePublished =@DatePublished, IsActive =@IsActive
where Id = @Id
END

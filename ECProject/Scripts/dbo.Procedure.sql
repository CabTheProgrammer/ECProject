CREATE PROCEDURE [dbo].[Procedure]
	@ID int,
	@Name varchar(50),
	@Description varchar(250),
	@Price float,
	@ISBN varchar(50),
	@Img_Location char(100),
	@Category varchar(50),
	@Author varchar(50)

AS
	INSERT INTO PRODUCT_INFO VALUES (
	@ID,
	@Name,
	@Description,
	@Price,
	@ISBN,
	@Img_Location,
	@Category,
	@Author)
RETURN 0

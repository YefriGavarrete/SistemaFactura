--Tabla Productos
USE SistemaGestionFacturacion
IF OBJECT_ID('dbo.Productos', 'U') IS NULL
BEGIN

	CREATE TABLE [dbo].[Productos](
		[IdProducto] INT IDENTITY(1,1) NOT NULL,
		[Codigo] VARCHAR(10) NOT NULL,
		[Marca] VARCHAR(50) NOT NULL,
		[Modelo] VARCHAR(100) NOT NULL,
		[Precio] DECIMAL(10,2) NOT NULL,
		[Stock] INT NOT NULL,
		[IdCategoria] INT NOT NULL,
		[IdDescuento] INT NOT NULL,
		[Descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);
END;
GO
SELECT * FROM dbo.Productos








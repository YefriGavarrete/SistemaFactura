USE SistemaGestionFacturacion
CREATE TABLE [dbo].[DetallesPedidos](
	[IdDetallesPedidos] INT IDENTITY(1,1) NOT NULL,
	[IdPedido] INT NOT NULL,
	[IdProducto] INT NOT NULL,
	[Categoria] NVARCHAR(100) NOT NULL,
	[Marca] NVARCHAR(100) NOT NULL,
	[Modelo] NVARCHAR(100) NOT NULL,
	[Precio] DECIMAL(20,4) NOT NULL,
	[Cantidad] INT NOT NULL,
	[Descuento] DECIMAL(10,4) NOT NULL,
	[Subtotal] DECIMAL(10,4) NOT NULL,
	[ISV] DECIMAL(10,4) NOT NULL,
	[Total] DECIMAL(20,4) NOT NULL,
PRIMARY KEY CLUSTERED ([IdDetallesPedidos] ASC)
);
GO

SELECT * FROM dbo.DetallesPedidos






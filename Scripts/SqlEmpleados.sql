--TABLE EMPLEADOS
USE SistemaGestionFacturacion

IF OBJECT_ID('dbo.Empleados', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Empleados (
        IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
        NombreEmpleado NVARCHAR(100) NOT NULL,
        ApellidoEmpleado NVARCHAR(100) NOT NULL,
        IdCargo INT NOT NULL,
        DNI NVARCHAR(20) NULL,
        Estado VARCHAR(15) NOT NULL DEFAULT ('Activo')
        CONSTRAINT FK_Empleados_Cargos FOREIGN KEY (IdCargo)
            REFERENCES dbo.Cargos (IdCargo)
            ON UPDATE NO ACTION
            ON DELETE NO ACTION
    );
END;
GO

SELECT * FROM dbo.Empleados

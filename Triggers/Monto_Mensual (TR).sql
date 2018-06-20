-- Al insertar una tupla, calculo el Monto_Final
CREATE TRIGGER TR_Fecha_Finalizacion
ON Cobro_Mensual INSTEAD OF INSERT
AS
	DECLARE @Monto_Final	INTEGER
	DECLARE @Monto_Mensual	INTEGER
	DECLARE @Porcentaje		FLOAT

	-- Obtengo el porcentaje.
	SELECT @Porcentaje = (SELECT c.Porcentaje_Descuento FROM Inserted i	JOIN Cobro c ON c.ID_Factura_PK = i.ID_Factura_FK)
	SELECT @Monto_Mensual = (SELECT Monto_Mensual FROM Inserted)
	SELECT @Monto_Final = @Monto_Mensual*( 1 - (@Porcentaje / 100) )

	-- Inserto la tupla con los datos de la inserción.
	INSERT INTO Cobro_Mensual( ID_Factura_FK, Monto_Mensual, Monto_Final )
		(SELECT i.ID_Factura_FK, i.Monto_Mensual, @Monto_Final
		FROM Inserted i)
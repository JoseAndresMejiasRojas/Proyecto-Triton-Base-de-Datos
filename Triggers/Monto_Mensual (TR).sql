-- Al insertar una tupla, calculo el Monto_Final
CREATE TRIGGER TR_Monto_Final
ON Cobro_Mensual AFTER INSERT
AS
	DECLARE @Monto_Final	INTEGER
	DECLARE @Monto_Mensual	INTEGER
	DECLARE @id_factura		INTEGER
	DECLARE @Porcentaje		FLOAT

	-- Obtengo el porcentaje.
	SELECT @Porcentaje = (SELECT c.Porcentaje_Descuento FROM Inserted i	JOIN Cobro c ON c.ID_Factura_PK = i.ID_Factura_FK)
	SELECT @Monto_Mensual = (SELECT Monto_Mensual FROM Inserted)
	SELECT @Monto_Final = @Monto_Mensual*( 1 - (@Porcentaje / 100) )

	-- Obtengo el id_factura de la tupla recién insertada, esto no se puede hacer desde UPDATE.
	SELECT @id_factura = ID_Factura_FK
	FROM INSERTED

	-- Modifico el Monto_Final para agregarle el posible descuento, a la tupla agregada.
	UPDATE Cobro_Mensual
	SET Monto_Final = @Monto_Final
	WHERE ID_Factura_FK = @id_factura
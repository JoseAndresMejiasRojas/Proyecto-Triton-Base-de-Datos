-- Al insertar una tupla, calculo el Monto_Final
CREATE TRIGGER TR_Mensual_Monto_Final
ON Cobro_Mensual AFTER INSERT
AS
	DECLARE @Monto_Final	INTEGER
	DECLARE @Monto_Mensual	INTEGER
	DECLARE @id_factura		INTEGER
	DECLARE @Porcentaje		FLOAT

	IF @@ROWCOUNT = 1 
	BEGIN
		SET @Porcentaje = (SELECT COALESCE(c.Porcentaje_Descuento, 0) FROM Inserted i	JOIN Cobro c ON c.ID_Factura_PK = i.ID_Factura_FK)
		SET @Monto_Mensual = (SELECT i.Monto_Mensual FROM Inserted i JOIN Cobro_Mensual c ON c.ID_Factura_FK = i.ID_Factura_FK )
		SET @Monto_Final = @Monto_Mensual*( 1 - (@Porcentaje / 100) )

		-- Modifico el Monto_Final para agregarle el posible descuento, a la tupla agregada.
		UPDATE Cobro_Mensual
		SET Monto_Final = @Monto_Final
		FROM INSERTED
		WHERE Cobro_Mensual.ID_Factura_FK = INSERTED.ID_Factura_FK
	END
	ELSE
	BEGIN
		UPDATE Cobro_Mensual
		SET Monto_Final = 5
		FROM INSERTED
		WHERE Cobro_Mensual.ID_Factura_FK IN
			(SELECT INSERTED.ID_Factura_FK FROM INSERTED)
	END
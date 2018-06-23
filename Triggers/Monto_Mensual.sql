-- Al insertar una tupla, calculo el Monto_Final
CREATE TRIGGER TR_Mensual_Monto_Final
ON Cobro_Mensual AFTER INSERT
AS
	DECLARE @Monto_Final	MONEY
	DECLARE @Monto_Mensual	MONEY
	DECLARE @id_factura		INTEGER
	DECLARE @Porcentaje		FLOAT

	DECLARE Cursor_Tupla_Individual CURSOR LOCAL FOR
		SELECT c.Porcentaje_Descuento, i.Monto_Mensual, i.ID_Factura_FK
		FROM INSERTED i JOIN Cobro c ON i.ID_Factura_FK = c.ID_Factura_PK;

		OPEN Cursor_Tupla_Individual
		FETCH NEXT FROM Cursor_Tupla_Individual INTO @Porcentaje, @Monto_Mensual, @id_factura

		WHILE (@@FETCH_STATUS <> -1)
		BEGIN
			
			IF @Porcentaje IS NULL		-- Porcentaje puede ser nulo.
				SET @Porcentaje = 0

			SET @Monto_Final = @Monto_Mensual*( 1 - (@Porcentaje / 100) )

			UPDATE Cobro_Mensual
			SET Monto_Final = @Monto_Final
			WHERE @id_factura = ID_Factura_FK

			FETCH NEXT FROM Cursor_Tupla_Individual INTO @Porcentaje, @Monto_Mensual, @id_factura
		END
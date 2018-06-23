/*
	NOTA: para poder ejecutarlo, se usa la siguiente instrucción:
	SELECT dbo.Obtener_Ganancias_Mes(int)

	COALESCE se usa porque SUM, si no hay tuplas, devuelve NULL.  Esto hace que si hay un NULL, el valor que escoja
	sea un 0.
*/

CREATE FUNCTION Obtener_Ganancias_Mes(@Mes TINYINT )
RETURNS INTEGER
AS
BEGIN
	DECLARE @Ganancias INTEGER

	IF  EXISTS 	(
	SELECT Cobro.ID_Factura_PK
	FROM Cobro JOIN Cobro_Mensual
	ON Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK) 
		SET @Ganancias =	(SELECT COALESCE(SUM(Cobro_Mensual.Monto_Final), 0)
							FROM Cobro_Mensual	JOIN Cobro ON Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK
												JOIN Atleta ON Atleta.Codigo_Atleta_PK = Cobro.Codigo_Atleta_FK
		WHERE MONTH(Cobro.Fecha_Pago) = @Mes

		);

	IF EXISTS (
		SELECT Cobro.ID_Factura_PK
		FROM Cobro JOIN Cobro_Individual
		ON Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK) 
			SET @Ganancias +=	(SELECT COALESCE(SUM(Cobro_Individual.Monto_Total), 0)
								FROM Cobro_Individual	JOIN Cobro ON Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK
														JOIN Atleta ON Atleta.Codigo_Atleta_PK = Cobro.Codigo_Atleta_FK
		WHERE MONTH(Cobro.Fecha_Pago) = @Mes
		);

		RETURN @Ganancias
END;
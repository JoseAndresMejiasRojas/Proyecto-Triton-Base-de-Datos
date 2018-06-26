USE Triton

DECLARE @Codigo_Atleta INTEGER
SET @Codigo_Atleta = dbo.ObtenerCodigo('Fanny@gmail.com')

/*
	RESULTADOS ESPERADOS ANTES DEL DELETE:

	(1 row affected)

	(1 row affected)

	(2 rows affected)

	(4 rows affected)

	(3 rows affected)
*/
SELECT *
FROM Atleta	
WHERE Codigo_Atleta_PK = @Codigo_Atleta

SELECT *
FROM Cobro
WHERE Codigo_Atleta_FK = @Codigo_Atleta

SELECT *
FROM Prueba_Fisica
WHERE Codigo_Atleta_FK = @Codigo_Atleta

SELECT *
FROM Bloque_Entrenamiento
WHERE Codigo_Atleta_FK = @Codigo_Atleta

SELECT *
FROM Compuesto
WHERE Codigo_Atleta_FK = @Codigo_Atleta

-----------------------------------------ELIMINO ATLETA--------------------------------------------------

--DELETE FROM Atleta
--WHERE Codigo_Atleta_PK = @Codigo_Atleta



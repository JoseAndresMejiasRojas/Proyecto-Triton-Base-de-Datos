-- Contar cuántas pruebas físicas han hechos los atletas.

CREATE PROC sp_cantidad_pruebas_fisicas AS
	SELECT a.Correo, a.Nombre + ' ' + a.Apellido1 + ' ' + a.Apellido2 AS 'Nombre', 'Número pruebas' = COUNT(p.Fecha_Prueba_PK)
	FROM Triton.dbo.Atleta a	JOIN Triton.dbo.Prueba_Fisica p ON a.Codigo_Atleta_PK = p.Codigo_Atleta_FK
	GROUP BY a.Correo, a.Nombre, a.Apellido1, a.Apellido2
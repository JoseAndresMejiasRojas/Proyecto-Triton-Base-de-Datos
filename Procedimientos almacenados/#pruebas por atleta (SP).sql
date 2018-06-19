-- Contar cuántas pruebas físicas han hechos los atletas.

CREATE PROC sp_cantidad_pruebas_fisicas AS
	SELECT a.Correo_PK, a.Nombre + ' ' + a.Apellido1 + ' ' + a.Apellido2 AS 'Nombre', COUNT(p.Fecha_Prueba_PK)
	FROM Triton.dbo.Atleta a	JOIN Triton.dbo.Prueba_Fisica p ON a.Correo_PK = p.Correo_FK
	GROUP BY a.Correo_PK, a.Nombre, a.Apellido1, a.Apellido2
USE Triton

UPDATE Bloque_Entrenamiento
SET  Rango_Horas = -1
WHERE Bloque_Entrenamiento.Numero_Entrenamiento_PK = 1

UPDATE Bloque_Entrenamiento
SET  Rango_Horas = 0
WHERE Bloque_Entrenamiento.Numero_Entrenamiento_PK = 1

UPDATE Bloque_Entrenamiento
SET  Rango_Horas = 24
WHERE Bloque_Entrenamiento.Numero_Entrenamiento_PK = 1


UPDATE Bloque_Entrenamiento
SET  Rango_Horas = 25
WHERE Bloque_Entrenamiento.Numero_Entrenamiento_PK = 1

UPDATE Bloque_Entrenamiento
SET  Rango_Horas = 1
WHERE Bloque_Entrenamiento.Numero_Entrenamiento_PK = 1

SELECT *
FROM Bloque_Entrenamiento
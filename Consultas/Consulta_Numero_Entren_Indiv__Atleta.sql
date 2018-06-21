USE triton 
SELECT A.Nombre AS 'Atleta', COUNT(DISTINCT E.Codigo_Entrenamiento_PK) AS 'Num. Entren. Individuales'
FROM Entrenamiento_Individual E, Compuesto C, Bloque_Entrenamiento B, Atleta A
WHERE E.Codigo_Entrenamiento_PK = C.Codigo_Entrenamiento_FK
AND B.Numero_Entrenamiento_PK = C.Numero_Entrenamiento_FK
AND A.Correo_PK = B.Correo_FK
AND A.Correo_PK = C.Correo_FK
GROUP BY A.Nombre

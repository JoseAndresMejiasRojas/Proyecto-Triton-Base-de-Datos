USE Triton 
SELECT A.Correo AS 'Atleta', COUNT(DISTINCT E.Codigo_Entrenamiento_PK) AS 'Num. Entren. Individuales'
FROM Entrenamiento_Individual E, Compuesto C, Bloque_Entrenamiento B, Atleta A
WHERE E.Codigo_Entrenamiento_PK = C.Codigo_Entrenamiento_FK
AND B.Numero_Bloque_PK = C.Numero_Bloque_FK
AND A.Codigo_Atleta_PK = B.Codigo_Atleta_FK
AND A.Codigo_Atleta_PK = C.Codigo_Atleta_FK
GROUP BY A.Correo

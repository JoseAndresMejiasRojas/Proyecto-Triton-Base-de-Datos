use triton 
select A.Nombre as 'Atleta', count(distinct E.Codigo_Entrenamiento_PK) as 'Num. Entren. Individuales'
from Entrenamiento_Individual E, Compuesto C, Bloque_Entrenamiento B, Atleta A
where E.Codigo_Entrenamiento_PK = C.Codigo_Entrenamiento_FK
and B.Numero_Entrenamiento_PK = C.Numero_Entrenamiento_FK
and A.Correo_PK = B.Correo_FK
and A.Correo_PK = C.Correo_FK
group by A.Nombre

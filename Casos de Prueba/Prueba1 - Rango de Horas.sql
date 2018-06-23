use triton

update Bloque_Entrenamiento
set  Rango_Horas =-1
where Bloque_Entrenamiento.Numero_Entrenamiento_PK =1

update Bloque_Entrenamiento
set  Rango_Horas =0
where Bloque_Entrenamiento.Numero_Entrenamiento_PK =1

update Bloque_Entrenamiento
set  Rango_Horas =24
where Bloque_Entrenamiento.Numero_Entrenamiento_PK =1


update Bloque_Entrenamiento
set  Rango_Horas =25
where Bloque_Entrenamiento.Numero_Entrenamiento_PK =1

update Bloque_Entrenamiento
set  Rango_Horas =1
where Bloque_Entrenamiento.Numero_Entrenamiento_PK =1

select *
from Bloque_Entrenamiento
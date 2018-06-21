use triton 
if  exists (
	select Cobro.ID_Factura_PK
	from Cobro join Cobro_Mensual
	on Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK) 
(select  Atleta.Nombre +'' + Atleta.Apellido1 + ''+ Atleta.Apellido2 as 'Atleta', Cobro.ID_Factura_PK as 'Factura',  Cobro_Mensual.Monto_Final as 'Monto Total Mensual'
from Cobro_Mensual join Cobro
on Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK
join Atleta
on Atleta.Correo_PK = Cobro.Correo_FK
); 
if exists (
	select Cobro.ID_Factura_PK
	from Cobro join Cobro_Individual
	on Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK) 
(select  Atleta.Nombre +'' + Atleta.Apellido1 + ''+ Atleta.Apellido2 as 'Atleta', Cobro.ID_Factura_PK as 'Factura',  Cobro_Individual.Monto_Total as 'Monto Total Individual'
from Cobro_Individual join Cobro
on Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK
join Atleta
on Atleta.Correo_PK = Cobro.Correo_FK
);





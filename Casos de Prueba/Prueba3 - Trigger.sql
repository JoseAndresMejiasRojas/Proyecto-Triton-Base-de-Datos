INSERT INTO Cobro	
VALUES
(10024333, dbo.ObtenerCodigo('Ana@gmail.com'),		'2018-01-01', '2018-02-01', 897845657897, '2028-02-01', 654, 45612,'2018-01-15', 75)

INSERT INTO Cobro_Mensual (ID_Factura_FK, Monto_Mensual)
VALUES 
(10024333, 60)

select *
from Cobro join	Cobro_Mensual on Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK
where ID_Factura_FK = 10024333


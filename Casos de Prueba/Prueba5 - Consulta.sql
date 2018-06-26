USE triton

IF  EXISTS 	(
	SELECT Cobro.ID_Factura_PK
	FROM Cobro JOIN Cobro_Mensual
	ON Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK) 
(SELECT  Atleta.Nombre +'' + Atleta.Apellido1 + ''+ Atleta.Apellido2 AS 'Atleta', Cobro.ID_Factura_PK AS 'Factura',  Cobro_Mensual.Monto_Final AS 'Monto Total Mensual'
FROM Cobro_Mensual JOIN Cobro
ON Cobro.ID_Factura_PK = Cobro_Mensual.ID_Factura_FK
JOIN Atleta
ON Atleta.Codigo_Atleta_PK = Cobro.Codigo_Atleta_FK
);

IF EXISTS (
	SELECT Cobro.ID_Factura_PK
	FROM Cobro JOIN Cobro_Individual
	ON Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK) 
(SELECT  Atleta.Nombre +'' + Atleta.Apellido1 + ''+ Atleta.Apellido2 AS 'Atleta', Cobro.ID_Factura_PK AS 'Factura',  Cobro_Individual.Monto_Total AS 'Monto Total Individual'
FROM Cobro_Individual JOIN Cobro
ON Cobro.ID_Factura_PK = Cobro_Individual.ID_Factura_FK
JOIN Atleta
ON Atleta.Codigo_Atleta_PK = Cobro.Codigo_Atleta_FK
);





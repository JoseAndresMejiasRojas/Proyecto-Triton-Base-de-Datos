USE Triton
 
INSERT INTO Compuesto
VALUES 
(11	,1		,1),--E1
(23	,dbo.ObtenerCodigo('Ana@gmail.com')		,4),--E4
(41	,dbo.ObtenerCodigo('Ana@gmail.com')		,5),--*
(42	,dbo.ObtenerCodigo('Ana@gmail.com')		,5),----*E5
(32	,dbo.ObtenerCodigo('Ana@gmail.com')		,5),---*
(11	,dbo.ObtenerCodigo('Ana@gmail.com')		,9),--*
(12	,dbo.ObtenerCodigo('Ana@gmail.com')		,9),----*E9
(13	,dbo.ObtenerCodigo('Ana@gmail.com')		,9),--*
(12	,dbo.ObtenerCodigo('Bruno@gmail.com')		,2),--*
(22	,dbo.ObtenerCodigo('Bruno@gmail.com')		,2),--*E2
(31	,dbo.ObtenerCodigo('Bruno@gmail.com')		,10),--*
(42	,dbo.ObtenerCodigo('Bruno@gmail.com')		,10),----*E10
(41	,dbo.ObtenerCodigo('Bruno@gmail.com')		,11),--*
(42	,dbo.ObtenerCodigo('Bruno@gmail.com')		,11),----*E11
(41 ,dbo.ObtenerCodigo('Carlos@gmail.com')		,5),--*
(42	,dbo.ObtenerCodigo('Carlos@gmail.com')		,5),----*E5
(32	,dbo.ObtenerCodigo('Carlos@gmail.com')		,5),--*
(11, dbo.ObtenerCodigo('Carlos@gmail.com')		,13),--*
(12, dbo.ObtenerCodigo('Carlos@gmail.com')		,13),--*E13
(23	,dbo.ObtenerCodigo('Daniel@gmail.com')		,4),--E4
(41	,dbo.ObtenerCodigo('Elka@gmail.com')		,5),--*
(42	,dbo.ObtenerCodigo('Elka@gmail.com')		,5),----*E5
(32	,dbo.ObtenerCodigo('Elka@gmail.com')		,5),--*
(21	,dbo.ObtenerCodigo('Elka@gmail.com')		,7),--*
(31, dbo.ObtenerCodigo('Elka@gmail.com')		,7),--*E7
(11, dbo.ObtenerCodigo('Elka@gmail.com')		,9),--*
(12, dbo.ObtenerCodigo('Elka@gmail.com')		,9),----*E9
(13, dbo.ObtenerCodigo('Elka@gmail.com')		,9),--*
(31 ,dbo.ObtenerCodigo('Elka@gmail.com')		,10),--*
(42 ,dbo.ObtenerCodigo('Elka@gmail.com')		,10),--*E10
(13	,dbo.ObtenerCodigo('Fanny@gmail.com')		,6),--*
(31	,dbo.ObtenerCodigo('Fanny@gmail.com')		,6),----*E6
(41	,dbo.ObtenerCodigo('Fanny@gmail.com')		,6)
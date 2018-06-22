CREATE FUNCTION ObtenerCodigo (@Correo VarChar(30))
RETURNS INTEGER
AS
BEGIN 
	DECLARE @Atlete_ID INTEGER
	
		set @Atlete_ID = COALESCE((Select Codigo_Atleta_PK
									FROM Atleta
									where Correo = @Correo),-1) --Menos uno si no existe
	Return @Atlete_ID
End;
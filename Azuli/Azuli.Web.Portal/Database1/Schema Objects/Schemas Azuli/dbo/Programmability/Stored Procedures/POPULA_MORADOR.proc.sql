﻿CREATE PROCEDURE [dbo].[POPULA_MORADOR]
@PROPRIETARIO_AP INT,
@PROPRIETARIO_BLOCO INT,
@SENHA VARCHAR(50)
AS
	
	BEGIN
		
	SELECT NOME_PROPRIETARIO1,NOME_PROPRIETARIO2,PROPRIETARIO_BLOCO,PROPRIETARIO_AP FROM Proprietario 
	WHERE  PROPRIETARIO_AP = @PROPRIETARIO_AP
	AND PROPRIETARIO_BLOCO = @PROPRIETARIO_BLOCO
	AND PASSWORD  = @SENHA

	END



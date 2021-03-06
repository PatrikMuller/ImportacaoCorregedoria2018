USE [Corregedoria2018]
GO
/****** Object:  StoredProcedure [dbo].[uspImportacao]    Script Date: 22/10/2018 13:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspImportacao]
AS
BEGIN


--#### INSERIR Município #############################
--INSERT INTO [dbo].[Municipio]([idMunicipio],[nome])
SELECT [id_municipio],[nome] FROM Ccg2009.Cadastro.Municipio


--#### INSERIR tipoProcesso ##########################
--INSERT INTO [dbo].[tipoProcesso]([idTipoProcesso],[nome],[sigla])
SELECT [id_tipo_processo],[nome],[sigla] FROM Ccg2009.Processo.tipoProcesso


--#### INSERIR Processo ##############################
--INSERT INTO [dbo].[Processo]([idTipoProcesso],[numeroProcesso],[anoProcesso],[dataInstauracao],[portariaInstauracao],[historico],[dataEncerramento],[idMunicipio])
SELECT [id_tipo_processo],[numero],[ano],[data_instauracao],[portaria_instautaracao],[historico],[data_encerramento],[id_municipio] FROM Ccg2009.Processo.Processo





--#### INSERIR Pessoa ##############################
--ALTER TABLE [dbo].[Pessoa] ADD TabelaOrigem VARCHAR(20) NULL, idOrigonal INT NULL
--INSERT INTO [dbo].[Pessoa]([tipoPessoa],[nome],[cpfcnpj],[rgie],[matricula])

--CPF Tratado
SELECT --DISTINCT 
	CASE LEN(RTRIM(cpfcnpj))
	WHEN 14 THEN 'F'
	WHEN 18 THEN 'J'
	END AS tipoPessoa, 
	
	UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) AS nomeTratado, 

	REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '') AS cpfcnpjTratado, 

	RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', ''))) AS rgTratado, 

	REPLACE(REPLACE(REPLACE(matricula, '.', ''), '-', ''), '/', '') AS matriculaTratado 
	  
	FROM Ccg2009.Cadastro.Acusado 
WHERE 
	RTRIM(nome) <> ''
AND	RTRIM(cpfcnpj) <> ''
AND	ISNUMERIC(REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '')) = 1
AND LEN(RTRIM(cpfcnpj)) IN (14, 18)
GROUP BY 
CASE LEN(RTRIM(cpfcnpj))
WHEN 14 THEN 'F'
WHEN 18 THEN 'J'
END, 
UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))), 
REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', ''), 
RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', ''))), 
REPLACE(REPLACE(REPLACE(matricula, '.', ''), '-', ''), '/', '') 
--Rows 1537
--(1537 row(s) affected)


--INSERT INTO [dbo].[Pessoa]([tipoPessoa],[nome],[cpfcnpj],[rgie],[matricula])
--CPF Tratado
SELECT
	CASE LEN(RTRIM(cpfcnpj))
		WHEN 14 THEN 'F'
		WHEN 18 THEN 'J'
		END AS tipoPessoa, 

	UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) AS nomeTratado, 

	REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '') AS cpfcnpjTratado, 

	RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', ''))) AS rgTratado,

	'000000000' AS Matricula

FROM Ccg2009.Cadastro.Testemunha
WHERE 
	RTRIM(nome) <> ''
AND	RTRIM(cpfcnpj) <> ''
AND LEN(RTRIM(cpfcnpj)) IN (14, 18)
GROUP BY 
CASE LEN(RTRIM(cpfcnpj))
WHEN 14 THEN 'F'
WHEN 18 THEN 'J'
END, 
UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))), 
REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', ''), 
RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', '')))
--Rows 537
--(537 row(s) affected)



--INSERT INTO [dbo].[Pessoa]([tipoPessoa],[nome],[cpfcnpj],[rgie],[matricula])
--SEM CpfCnpj
SELECT DISTINCT 
	CASE --UPPER(RTRIM(LTRIM(REPLACE(nome, '.', ''))))
	WHEN CharIndex('CFC', UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) , 1) > 0 THEN 'J'
	WHEN CharIndex('CONDUTORES', UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) , 1) > 0 THEN 'J'
	WHEN CharIndex('LTDA', UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) , 1) > 0 THEN 'J'
	WHEN CharIndex('DESPACHANTE', UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) , 1) > 0 THEN 'J'
	WHEN CharIndex('PLACAS', UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) , 1) > 0 THEN 'J' ELSE 'F'
	END AS tipoPessoa,
	 
	UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) AS nome, 

	cpfcnpj, 

	RTRIM(LTRIM(REPLACE(REPLACE(rg, ' ', ''), '.', ''))) AS RG, 

	matricula  
	
	FROM Ccg2009.Cadastro.Acusado 
WHERE 
	RTRIM(nome) <> ''
AND	RTRIM(cpfcnpj) = ''
AND LEN(RTRIM(cpfcnpj)) NOT IN (14, 18)
--Rows 392
--(392 row(s) affected)



--INSERT INTO [dbo].[Pessoa]([tipoPessoa],[nome],[cpfcnpj],[rgie],[matricula])

--SEM CpfCnpj
SELECT DISTINCT
			
	'F' AS tipoPessoa, 

	UPPER(RTRIM(LTRIM(REPLACE(nome, '.', '')))) AS nomeTratado, 

	REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '') AS cpfcnpjTratado, 

	RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', ''))) AS rgTratado,

	'000000000' AS Matricula

FROM Ccg2009.Cadastro.Testemunha
WHERE 
	RTRIM(nome) <> ''
AND	RTRIM(cpfcnpj) = ''
--Rows 40
--(40 row(s) affected)



--select * from pessoa

--#### INSERIR Testemunha ##############################
SELECT
	*, 
	
	(SELECT TOP 1 nome FROM Pessoa AS tIn 
	WHERE 
		LTRIM(RTRIM(tIn.cpfcnpj)) <> ''
	AND LTRIM(RTRIM(tIn.cpfcnpj)) <> '00000000000'
	--REPLACE(REPLACE(REPLACE(tIn.cpfcnpj, '.', ''), '-', ''), '/', '') = 
	AND tIn.cpfcnpj =
	CAST(REPLACE(REPLACE(REPLACE(ct.cpfcnpj, '.', ''), '-', ''), '/', '') 
	COLLATE SQL_Latin1_General_CP1_CI_AS as varchar(21))
	 
	ORDER BY idPessoa),
	
	(SELECT TOP 1 idPessoa FROM Pessoa AS tIn 
	WHERE 
		LTRIM(RTRIM(tIn.cpfcnpj)) <> ''
	AND LTRIM(RTRIM(tIn.cpfcnpj)) <> '00000000000'
	--REPLACE(REPLACE(REPLACE(tIn.cpfcnpj, '.', ''), '-', ''), '/', '') = 
	AND tIn.cpfcnpj =
	CAST(REPLACE(REPLACE(REPLACE(ct.cpfcnpj, '.', ''), '-', ''), '/', '') 
	COLLATE SQL_Latin1_General_CP1_CI_AS as varchar(21))
	 
	ORDER BY idPessoa)

FROM Ccg2009.Processo.Testemunha AS pt
INNER JOIN Ccg2009.Cadastro.Testemunha AS ct ON pt.id_testemunha = ct.id_testemunha
ORDER BY id_processo


--Msg 468, Level 16, State 9, Line 144
--Não foi possível resolver o conflito de agrupamento entre "SQL_Latin1_General_CP1_CI_AS" e "Latin1_General_CI_AS" na operação equal to.


--#### INSERIR Acusado ##############################
SELECT
	--pt.*, 
	--(SELECT TOP 1 nome FROM Ccg2009.Cadastro.Acusado AS tIn WHERE tIn.nome = ct.nome ORDER BY id_acusado),
	--(SELECT TOP 1 cpfcnpj FROM Ccg2009.Cadastro.Acusado AS tIn WHERE tIn.cpfcnpj = ct.cpfcnpj ORDER BY id_acusado)

	pt.id_processo, 
	(SELECT TOP 1 id_acusado FROM Ccg2009.Cadastro.Acusado AS tIn WHERE tIn.cpfcnpj = ct.cpfcnpj ORDER BY id_acusado) id_acusado

FROM Ccg2009.Processo.Acusado AS pt
INNER JOIN Ccg2009.Cadastro.Acusado AS ct ON pt.id_acusado = ct.id_acusado
WHERE 
	RTRIM(nome) <> ''
AND	RTRIM(cpfcnpj) <> ''
AND	ISNUMERIC(REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '')) = 1
AND LEN(RTRIM(cpfcnpj)) IN (14, 18)
ORDER BY id_processo



--SELECT
--	pt.*, 
--	(SELECT TOP 1 nome FROM Ccg2009.Cadastro.Acusado AS tIn WHERE tIn.nome = ct.nome ORDER BY id_acusado),
--	(SELECT TOP 1 cpfcnpj FROM Ccg2009.Cadastro.Acusado AS tIn WHERE tIn.cpfcnpj = ct.cpfcnpj ORDER BY id_acusado)

--FROM Ccg2009.Processo.Acusado AS pt
--INNER JOIN Ccg2009.Cadastro.Acusado AS ct ON pt.id_acusado = ct.id_acusado
--ORDER BY id_processo








END;
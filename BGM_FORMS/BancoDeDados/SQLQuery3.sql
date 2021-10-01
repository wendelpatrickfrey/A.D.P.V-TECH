  create table dbo.TerceiroBGM(
  idTerceiro int PRIMARY KEY IDENTITY(1,1) not null,
  Nome VARCHAR(50)  not null,
  CPF VARCHAR(13) not null,
  CNPJ VARCHAR(15) not null,
  Renavam VARCHAR(12) not null,
  CNH VARCHAR(12) not null,
  IDENDERECO INT NOT NULL,
  ID_TIPO INT NOT NULL,
  CONSTRAINT fk_idEndereco	FOREIGN KEY (idTerceiro) references DBO.ENDERECO_BGM (IDENDERECO),
  CONSTRAINT fk_idTipo FOREIGN KEY (idTerceiro) references  dbo.TIPOCONTATO (ID_TIPO)
  )

CREATE TABLE dbo.DescricaoOcorrencias(
 idDescricao int PRIMARY KEY IDENTITY(1,1) not null,
 DataDescricao VARCHAR(9) not null
)


create table dbo.OcorrenciasBGM(
	IdOcorrencias int not null IDENTITY(1,1),
	NumeroDaOcorrencia VARCHAR(20) not null,
	DataDaOcorrencia VARCHAR(9) not null,
	ValorDaOcorrencia MONEY  not null,
	idTerceiro int not null,
	idDescricao int not null,
	CONSTRAINT fk_idTerceiro FOREIGN KEY(idOcorrencias) references dbo.TerceiroBGM (idTerceiro),
	CONSTRAINT fk_idDescricao FOREIGN KEY(idOcorrencias) references dbo.DescricaoOcorrencias (idDescricao)
  )

create table dbo.CadastroBGM(
idCadastro int IDENTITY(1,1) primary key not null,
Nome VARCHAR(50) not null,
Usuario VARCHAR(50) not null,
Senha VARCHAR(50) not null,
Funcao bit not null
)

SELECT * FROM dbo.CadastroBGM
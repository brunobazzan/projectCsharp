CREATE TABLE USUARIOS(
CODIGO_USUARIO VARCHAR(10) PRIMARY KEY,
NOME_USUARIO VARCHAR(50),
SENHA_USUARIO VARCHAR(10)
)

CREATE TABLE LOCATARIOS(
CODIGO_LOCATARIO VARCHAR(20) PRIMARY KEY,
NOME_LOCATARIO VARCHAR(50),
TELEFONE_LOCATARIO VARCHAR(9),
ENDERECO_LOCATARIO VARCHAR(60),
EMAIL_LOCATARIO VARCHAR(20)
)

CREATE TABLE LIVROS(
CODIGO_LIVRO VARCHAR(12) PRIMARY KEY,
NOME_LIVRO VARCHAR(50),
GENERO VARCHAR(20),
SUBGENERO VARCHAR(30),
SUBGENERO_2 VARCHAR(30),
EDITORA VARCHAR(30)
)

CREATE TABLE TRANSACAO(
CODIGO_LIVRO VARCHAR(12),
CODIGO_LOCATARIO VARCHAR(20),
DATA_ENVIO DATETIME,
DATA_ENTREGA DATETIME
)
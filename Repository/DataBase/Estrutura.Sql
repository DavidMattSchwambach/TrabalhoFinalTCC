DROP TABLE IF EXISTS compras;
DROP TABLE IF EXISTS cartoes_credito; 
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS bebidas;
DROP TABLE IF EXISTS acessorios;
DROP TABLE IF EXISTS tipos;
DROP TABLE IF EXISTS marcas;
DROP TABLE IF EXISTS administradores;

CREATE TABLE administradores(
     id INT PRIMARY KEY IDENTITY(1,1),
	 login VARCHAR (50),
	 senha VARCHAR (25)
	 );

CREATE TABLE clientes(
     id INT PRIMARY KEY IDENTITY(1,1),
	 nome VARCHAR(100),
	 data_nascimento DATETIME2,
	 cpf VARCHAR(14),
	 telefone VARCHAR (9),
	 usuario VARCHAR (50),
	 email VARCHAR (50),
	 senha VARCHAR (25),

	 data_criacao DATETIME,
	 registro_ativo BIT
);

CREATE TABLE marcas(
     id INT PRIMARY KEY IDENTITY(1,1),	
	 nome VARCHAR (50),

	 data_criacao DATETIME,
	 registro_ativo BIT
);

CREATE TABLE tipos(
    id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),

	id_marca INT,
	FOREIGN KEY(id_marca) REFERENCES marcas(id),

	 data_criacao DATETIME,
	 registro_ativo BIT
	);

CREATE TABLE bebidas(
    id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (8,2),

	id_tipo INT,
	CONSTRAINT fk_tipo FOREIGN KEY (id_tipo) REFERENCES tipos(id),

	id_marca INT,
	CONSTRAINT fk_marca FOREIGN KEY (id_marca) REFERENCES marcas(id),

	 data_criacao DATETIME,
	 registro_ativo BIT
);

CREATE TABLE cartoes_credito(
    id INT PRIMARY KEY IDENTITY(1,1),
	numero DECIMAL(8,2),
	data_vencimento DATETIME2,
	cvv DECIMAL (3),

	id_cliente INT,
	FOREIGN KEY(id_cliente) REFERENCES clientes(id),

	 data_criacao DATETIME,
	 registro_ativo BIT
);

CREATE TABLE acessorios(
    id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR (50),
	preco DECIMAL (8,2),

	id_tipo INT,
	FOREIGN KEY(id_tipo) REFERENCES tipos(id),

	 data_criacao DATETIME,
	 registro_ativo BIT
);

CREATE TABLE compras(
    id INT PRIMARY KEY IDENTITY (1,1),
	valor DECIMAL(8,2),
	data_compra DATETIME,
			
	id_bebida INT,
	FOREIGN KEY(id_bebida) REFERENCES bebidas(id),

	id_cartao_credito INT,
	FOREIGN KEY(id_cartao_credito) REFERENCES cartoes_credito(id),


	id_acessorio INT,
	FOREIGN KEY(id_acessorio) REFERENCES acessorios(id),

	 data_criacao DATETIME,
	 registro_ativo BIT
);


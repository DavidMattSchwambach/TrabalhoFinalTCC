
CREATE TABLE clientes(
     id INT PRIMARY KEY IDENTITY(1,1),
	 nome VARCHAR(100),
	 data_nascimento DATETIME2,
	 cpf VARCHAR(14),
	 telefone VARCHAR (9),
	 email VARCHAR (50),
	 senha VARCHAR (25),
	 registro_ativo BIT
	 );

CREATE TABLE marcas(
     id INT PRIMARY KEY IDENTITY(1,1),
	 nome VARCHAR (50),
	 );

CREATE TABLE tipos(
    id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	FOREIGN KEY(id_marca) REFERENCES marcas(id)
	);

CREATE TABLE bebidas(
    id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (8,2),
	FOREIGN KEY (id_tipo) REFERENCES tipo(id)
	);


CREATE TABLE compras(
    id INT PRIMARY KEY IDENTITY (1,1),
	valor DECIMAL(8,2),
	data_compra DATETIME,
	FOREIGN KEY(id_cartao_credito) REFERENCES cartoes_credito(id),
	FOREIGN KEY(id_bebidas) REFERENCES bebidas(id),
	FOREIGN KEY(id_acessorios) REFERENCES acessorios(id)
	);

CREATE TABLE acessorios(
    id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR (50),
	preco DECIMAL (8,2),
	FOREIGN KEY(id_tipos) REFERENCES tipos(id)
	);

CREATE TABLE cartoes_credito(
    id INT PRIMARY KEY IDENTITY(1,1),
	numero DECIMAL(8,2),
	data_vencimento DATETIME2,
	cvv DECIMAL (3),
	FOREIGN KEY(id_clientes) REFERENCES clientes(id)
	);


	


     
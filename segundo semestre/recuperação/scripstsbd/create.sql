-- Crie o banco de dados "veiculos"
CREATE DATABASE veiculos;

-- Use o banco de dados "veiculos"
USE veiculos;

-- Crie a tabela "fabricante"
CREATE TABLE fabricante 
(
    IdFabricante INT PRIMARY KEY identity,
    nome VARCHAR(50) NOT NULL,
);

-- Crie a tabela "veiculo" com a chave estrangeira para "fabricante"
CREATE TABLE veiculo 
(
    IdVeiculo INT PRIMARY KEY identity,
    IdFabricante INT FOREIGN KEY (IdFabricante) REFERENCES fabricante(IdFabricante) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    preco FLOAT NOT NULL, 
);
--drop database veiculos

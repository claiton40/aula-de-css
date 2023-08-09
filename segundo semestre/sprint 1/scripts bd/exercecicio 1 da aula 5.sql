CREATE DATABASE EXERCICIO_1_1;

CREATE TABLE PESSOA
(
IdPessoa int primary key identity,
Nome varchar(50) NOT NULL,
Cnh varchar (10) NOT NULL UNIQUE
)

CREATE TABLE TELEFONE
(
IdTelefone int primary key identity,
IdPessoa int foreign key references PESSOA (IdPessoa) not null,
Numero varchar (20) not null
)

CREATE TABLE EMAIL
(
IdEmail int primary key identity,
IdPessoa int foreign key references PESSOA (IdPessoa) not null,
Email varchar (50) not null unique
)
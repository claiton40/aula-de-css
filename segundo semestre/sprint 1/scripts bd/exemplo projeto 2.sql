/*
--DDL data definition language.
-- criar banco
--DROP database[Event+_Tarde]
create database[Event+_Tarde]
-- criar tabelas, criar primeiro as que nao tem chave estrangeiras, ou tabelas primarias.
create table TipoDeUsuario
(
IdTipoDeUusario int primary key identity,
TituloTipoUsuario varchar(50) Not Null unique,
);
create table TiposDeEvento
(
IdTipodeEvento int primary key identity,
TituloTipoEvento varchar(20) not null UNIQUE
)
--Alterar campo TituloTipoEvento para UNIQUE
--alter table TiposDeEvento add unique(TituloTipoEvento);


create table Instiuicao
(
IdInstituicao int primary key identity,
CNPJ CHAR(14) Not Null unique,
Endereci varchar (200) Not Null,
NomeFantasia varchar(200) Not Null
)

create table Usuario
(
IdUsuario int primary key identity,
IdTipoDeUsuario int 
	Foreign key references TipoDeUsuario(IdTipoDeUusario) not null,
Nome varchar(50) not null,
Email varchar(50) not null unique,
Senha varchar(50) not null
)

create table Evento
(
IdEvento int primary key identity,
IdTipodeEvento  int 
	Foreign key references TiposDeEvento(IdTipodeEvento) not null,
IdInstituicao  int 
	Foreign key references Instiuicao(IdInstituicao) not null,
Nome varchar(50) not null,
Descricao varchar(100) not null unique,
DataEvento date null,
HorarioEvento Time not null
)

create table PresencaEvento
(
IdPresencaEvento int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario) not null,
IdEvento int foreign key references Evento(IdEvento) not null,
Situacao bit default(0)
)

create table ComentarioEvento
(
IdComentarioEvento int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario) not null,
IdEvento int foreign key references Evento(IdEvento) not null,
Descricao varchar (200),
Exibe bit default(0)
)


*/

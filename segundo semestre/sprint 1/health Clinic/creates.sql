--create database Health_Clinic

--use Health_Clinic

create table Usuario
(
	IdUsuario int primary key identity,
	Nome varchar(50) not null,
	Email varchar(50) not null,
	Senha varchar (8) not null
)

create table Unidade
(
	IdUnidade int primary key identity,
	Endereco varchar(50) not null,
	Telefone varchar(50) not null,
	EmailUnidade varchar (20) not null
)

create table Especialidade
(
	IdEspecialidade varchar (200) primary key identity,
	IdUnidade 
	int foreign key references Unidade(IdUnidade) NOT NULL,
	Especialidade varchar(100) not null,
)

 create table Paciente
(
	IdPaciente int primary key identity,
	IdUsuario int foreign key references ADM(IdUsuario) NOT NULL,
	Evolucao varchar(2000) not null,
)

create table Profissional
(
	IdProfissional int primary key identity,
	IdUsuario int foreign key references Usuario(IdUsuario) NOT NULL,
	IdEspecialidade 
		varchar (200)
		foreign key 
		references Especialidade(IdEspecialidade) NOT NULL,
	RegistroConselho varchar(30) not null,
)

create table Atendimento
(
	IdAtendimento int primary key identity
	IdUnidade 
	int
	foreign key references Unidade(IdUnidade) NOT NULL,
	IdPaciente 
	int
	foreign key references Paciente(IdPaciente) NOT NULL,
	IdProfissional
		int
		foreign key
		references Profissional(IdProfissional) NOT NULL,
	DiaAtendimento date not null,
	HoraAtendimento time not null
)


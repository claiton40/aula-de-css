--create database Health_Clinic

--create table ADM
--(
--	IdADM int primary key identity,
--	Email varchar(50) not null,
--	Senha varchar (8) not null
--)

--create table Especialidade
--(
--	IdEspecialidade int primary key identity,
--	IdADM int foreign key references ADM(IdADM) NOT NULL,
--	Especialidade varchar(100) not null,
--)

--create table Gestor
--(
--	IdGestor int primary key identity,
--	IdADM int foreign key references ADM(IdADM) NOT NULL,
--)

create table Unidade
(
	IdUnidade int primary key identity,
	IdADM int foreign key references ADM(IdADM) NOT NULL,
)
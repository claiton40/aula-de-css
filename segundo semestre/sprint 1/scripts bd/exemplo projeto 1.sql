/*
--DML Data Manipulation Language
insert into TipoDeUsuario (TituloTipoUsuario) values ('ADMIN'), ('COMUM')
insert into TiposDeEvento (TituloTipoEvento) values ('SQL Server')

 insert into Instiuicao (CNPJ, Endereci, NomeFantasia)
 values ('154544', 'rua', 'dev')
 

 insert into Usuario (IdTipoDeUsuario, Nome, Email, Senha)
 values ('1', 'jose', 'jose@jose.com', '1234liveira5')

 insert into Usuario (IdTipoDeUsuario, Nome, Email, Senha)
 values ('2', 'maria', 'maria@maria.com', '1234pereira5')
 

 insert into 
	Evento (IdTipodeEvento, IdInstituicao, Nome, Descricao, DataEvento, HorarioEvento)
 values 
	('1', '1', 'sql e top', 'seja top com sql', '2023-09-10', '15:30:00:00')
	*/

insert into PresencaEvento (IdUsuario,IdEvento)
	
 values 
	('1','2')
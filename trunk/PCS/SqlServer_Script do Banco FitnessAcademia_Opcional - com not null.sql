/*
create database bdFitnessAcademia
go
use bdFitnessAcademia
go
create table Cliente(codigo int identity(1,1), nome varchar(100) not null, CPF varchar(11), RG varchar(11) not null,
					DataNasc date not null, Logradouro varchar(100) not null, numLog varchar(15) not null,
					Complemento varchar(50), Bairro varchar(60) not null, Cidade varchar(60) not null,
					UF char(2) not null, CEP varchar(8) not null,
					EstCivil char(1) not null check(EstCivil='C' or EstCivil='S' or EstCivil='D' or EstCivil='V'), 
					Sexo char(1) not null check(sexo='M' or sexo='F' or sexo='O'), 
					Telefone varchar(11), Celular varchar(11), Email varchar(100), ValExameMedico Date,
					constraint cliente_PKcodigo primary key (codigo))
go
--select * from cliente
create table Exercicio(Codigo int identity(1, 1), Descricao varchar(100) not null,
						constraint Exercicio_PKcodigo primary key(codigo))
go

create table Objetivo(Codigo int identity(1,1), Descricao varchar(50) not null, 
						constraint objetivo_PKcodigo primary key(Codigo))
go
create table PlanoTreinamento(NumPlano int identity(1,1), codCli int not null, Data Date, codObjetivo int not null,
							constraint PlanoTreinamento_FKcodObjetivo foreign key(codObjetivo) references Objetivo(Codigo),
							constraint PlanoTreinamento_FKcodCli foreign key(codCli) references Cliente(Codigo),
							constraint PlanoTreinamento_PKnumPlanoCodCli primary key(NumPlano))
go
create table ExercicioDoPlano(numPlano int not null, seq int not null, codExercicio int not null,
							Series int not null, numRepeticoes int not null, peso real Default 0.0,
							constraint ExercicioDoPlano_FKcodExercicio foreign key(codExercicio) references Exercicio(Codigo),
							constraint ExercicioDoPlano_FKnumPlano foreign key(numPlano) references PlanoTreinamento(NumPlano),
							constraint ExercicioDoPlano_PKnumPlanoSeq primary key(numPlano, seq))
go
insert into objetivo(Descricao) values('Condicionamento físico')
insert into objetivo(Descricao) values('Hipertrofia')
insert into objetivo(Descricao) values('Emagrecer')
insert into objetivo(Descricao) values('Reabilitação física')
go

create procedure AddPlanoTreinamento
	@pCodCli int, 
	@pData Date, 
	@pCodObjetivo int, 
	@pNumPlano int = 0 out
	as
	set nocount on
	insert into PlanoTreinamento(codCli, Data, codObjetivo)
	values(@pCodCli, @pData, @pCodObjetivo)
	set @pNumPlano = SCOPE_IDENTITY()
return
go
insert into Exercicio values('Abdominal canivete')
insert into Exercicio values('Abdominal infra')
insert into Exercicio values('Abdução cross over')
insert into Exercicio values('Abdução em pé')
insert into Exercicio values('Agachamento em pé')
insert into Exercicio values('Agachamento na barra guiada')
insert into Exercicio values('Crucifixo')
go
insert into cliente(nome, cpf, rg, DataNasc, Logradouro, numLog, Bairro, Cidade, UF, CEP,
					 EstCivil, Sexo, telefone, Celular, Email, ValExameMedico)
			values('Mariana Lima', '11122233344', '324354245', '25/05/1979', 'Rua 27 de maio', '23', 'Santo Antônio',
					'Recife', 'PE', '50002654', 'S', 'F', '8134756895', '8199751423', 'mariana.lima@gmail.com', '05/08/2013')
go
*/
/*
--Para testar o método iniciarPlanoDeTreinamento do webService WebSrvPlano que chama 
----Fachada.obterInstancia().validarLiberacaoDePlanoDeTreinamento(); => OK
delete from ExercicioDoPlano
delete from PlanoTreinamento
delete from Exercicio where Codigo > 0
*/

select * from Cliente
select * from PlanoTreinamento as pt left outer join ExercicioDoPlano as ep on pt.NumPlano = ep.numPlano
select * from Objetivo
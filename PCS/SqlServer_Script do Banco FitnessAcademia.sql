/*create database FitnessAcademia 
go
use FitnessAcademia
create table Cliente(codigo int identity(1,1), nome varchar(100) not null, CPF varchar(11), RG varchar(11),
					DataNasc date not null, Logradouro varchar(100), numLog varchar(15),
					Complemento varchar(50), Bairro varchar(60), Cidade varchar(60), UF char(2), CEP varchar(8),
					EstCivil char(1), check(EstCivil='C' or EstCivil='S' or EstCivil='D' or EstCivil='V'), 
					Sexo char(1) check(sexo='M' or sexo='F' or sexo='O'), 
					Telefone varchar(11), Celular varchar(11), Email varchar(100), ValExameMedico Date,
					constraint cliente_PKcodigo primary key (codigo))
go
select * from cliente*/
--create table Exercicio(Codigo int identity(1, 1), Descricao varchar(100) not null,
--						constraint Exercicio_PKcodigo primary key(codigo))
--go

/*create table Objetivo(Codigo int identity(1,1), Nome varchar(50), 
						constraint objetivo_PKcodigo primary key(Codigo))
go
create table PlanoTreinamento(NumPlano int identity(1,1), codCli int not null, Data Date, Nivel int not null,
							codObjetivo int not null,
							constraint PlanoTreinamento_FKcodObjetivo foreign key(codObjetivo) references Objetivo(Codigo),
							constraint PlanoTreinamento_FKcodCli foreign key(codCli) references Cliente(Codigo),
							constraint PlanoTreinamento_PKnumPlanoCodCli primary key(NumPlano))
go
create table ExercicioDoPlano(numPlano int not null, seq int not null, codExercicio int not null,
							Series int not null, numRepeticoes int not null, peso numeric(3,3),
							constraint ExercicioDoPlano_FKcodExercicio foreign key(codExercicio) references Exercicio(Codigo),
							constraint ExercicioDoPlano_FKnumPlano foreign key(numPlano) references PlanoTreinamento(NumPlano),
							constraint ExercicioDoPlano_PKcodCliNumPlano primary key(numPlano, seq))*/
/*insert into objetivo(nome) values('Condicionamento físico')
insert into objetivo(nome) values('Hipertrofia')
insert into objetivo(nome) values('Emagrecer')
insert into objetivo(nome) values('Reabilitação física')
select * from objetivo*/

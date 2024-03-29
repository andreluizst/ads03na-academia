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

/*create table Objetivo(Codigo int identity(1,1), Descricao varchar(50), 
						constraint objetivo_PKcodigo primary key(Codigo))
go
create table PlanoTreinamento(NumPlano int identity(1,1), codCli int not null, Data Date, Nivel int not null,
							codObjetivo int not null,
							constraint PlanoTreinamento_FKcodObjetivo foreign key(codObjetivo) references Objetivo(Codigo),
							constraint PlanoTreinamento_FKcodCli foreign key(codCli) references Cliente(Codigo),
							constraint PlanoTreinamento_PKnumPlanoCodCli primary key(NumPlano))
go
create table ExercicioDoPlano(numPlano int not null, seq int not null, codExercicio int not null,
							Series int not null, numRepeticoes int not null, peso real,
							constraint ExercicioDoPlano_FKcodExercicio foreign key(codExercicio) references Exercicio(Codigo),
							constraint ExercicioDoPlano_FKnumPlano foreign key(numPlano) references PlanoTreinamento(NumPlano),
							constraint ExercicioDoPlano_PKcodCliNumPlano primary key(numPlano, seq))*/
/*insert into objetivo(nome) values('Condicionamento f�sico')
insert into objetivo(nome) values('Hipertrofia')
insert into objetivo(nome) values('Emagrecer')
insert into objetivo(nome) values('Reabilita��o f�sica')
select * from objetivo*/
--alter table PlanoTreinamento drop column nivel
/*create procedure AddPlanoTreinamento
	@pCodCli int, 
	@pData Date, 
	@pCodObjetivo int, 
	@pNumPlano int = 0 out
	as
	set nocount on
	insert into PlanoTreinamento(codCli, Data, codObjetivo)
	values(@pCodCli, @pData, @pCodObjetivo)
	set @pNumPlano = SCOPE_IDENTITY()
return*/
--insert into Exercicio values('Abdominal canivete')
--insert into Exercicio values('Abdominal infra')
--insert into Exercicio values('Abdu��o cross over')
--insert into Exercicio values('Abdu��o em p�')
--insert into Exercicio values('Agachamento em p�')
--insert into Exercicio values('Agachamento na barra guiada')
--insert into Exercicio values('Crucifixo')
--go
--insert into cliente(nome, cpf, rg, DataNasc, Logradouro, numLog, Bairro, Cidade, UF, CEP,
--					 EstCivil, Sexo, Tefone, Celular, Email, ValExameMedico)
--			values('Mariana Lima', '11122233344', '324354245', '25/05/1979', 'Rua 27 de maio', '23', 'Santo Ant�nio',
--					'Recife', 'PE', '50002654', 'S', 'F', '8134756895', '8199751423', 'mariana.lima@gmail.com', '05/08/2013')
--go
--alter table cliente add Telefone varchar(11)
--update cliente set telefone = Tefone
--alter table cliente drop column Tefone
/*
--Para testar o m�todo iniciarPlanoDeTreinamento do webService WebSrvPlano que chama 
----Fachada.obterInstancia().validarLiberacaoDePlanoDeTreinamento(); => OK
delete from ExercicioDoPlano
delete from PlanoTreinamento
delete from Exercicio where Codigo > 0
*/
/*
--
--**************** ATUALIZAR TABELA ExercicioDoPlano **************************
--
alter table ExercicioDoPlano drop column peso
go
alter table ExercicioDoPlano add peso real
go
update ExercicioDoPlano set peso = 0
go
update ExercicioDoPlano set peso = 3.5 where numPlano = 21
go
*/
--**************** FIM DA ATUALIZA��O DA TABELA ExercicioDoPlano **************************
select * from PlanoTreinamento where ((data >= '2013-05-01') and (data <= '2013-05-31')) and codCli = 2
select * from ExercicioDoPlano
select * from PlanoTreinamento as pt left outer join ExercicioDoPlano as ep on ep.numPlano = pt.NumPlano
select * from Cliente
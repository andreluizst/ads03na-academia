-- TESTE mestre / detalhe(com sequencia incrementada por trigger)

/*create table teste(id int identity(1,1), numero int)
create trigger testeAutoIncNumero on teste instead of insert
as 
	declare @num int
	set @num = (select max(numero) from teste)
	if @num > 0
		set @num = @num + 1
	else
		set @num = 1
	insert into teste(numero) values(@num)
insert into teste(numero) values(23)
select * from teste*/
--create table testeDetalhe(idTeste int not null, seq int not null)
--drop trigger testeAutoIncDetalhe
/*create trigger testeAutoIncDetalhe on testeDetalhe instead of insert
as
	declare @LastSeq int
	declare @id int
	set @id = (select idTeste from inserted)
	set @LastSeq = (select max(d.seq) from testeDetalhe as d where d.idTeste in (select idTeste from inserted))
	if @LastSeq > 0
		set @LastSeq = @LastSeq + 1
	else
		set @LastSeq = 1
	insert into testeDetalhe(idTeste, seq) values(@id, @LastSeq)
go*/
/*delete from testedetalhe where idteste = 2
go
insert into testeDetalhe(idTeste) values(1)
select * from testeDetalhe order by idteste, seq*/
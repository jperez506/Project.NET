create Database BaseRJJF;

use BaseRJJF;

create table TablaTroquel(
Nombre varchar(100),
Codigo varchar (100) primary key,
descripcion varchar (150),
caracteristicas varchar(150),
Material varchar(150),
FechaOrigen varchar(100),
FechaMantenimiento varchar(100),
Estado varchar(100)
)

drop table TablaTroquel;
drop table tablaCliente;
drop table TablaUsuario;

create table TablaCliente(
Cliente varchar(150),
NombreContacto varchar (150),
Cedula int primary key,
codigoTroquel varchar (100) 
)
create table TablaUsuario(
cedula int primary key,
Nombre varchar(100),
rol varchar (100),
FechaModificacion varchar(100),
Clave varchar(100)
)

insert into TablaCliente (Cliente,NombreContacto,Cedula,codigoTroquel)
values('Ramses','Ramses Estrada', 11611027,'kder');

insert into TablaUsuario
values(116110777,'RamsesEstrada','administrador','10/04/10', 1);
insert into TablaUsuario
values(1,'RamsesEstrada','Administrador','10/04/10', 1);
select * from tablaUsuario;

select * from TablaCliente;

insert into TablaTroquel
values('put','rfs99','madera','madera','materia','10/04/20','10/09/22','nuevo');

select * from TablaTroquel;


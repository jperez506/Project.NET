use BAseRJJF
create procedure sp_ConsultaCliente
as
select * from TablaCliente

Exec sp_ConsultaCliente

create procedure sp_ConsultaTroquel
as
select * from TablaTroquel

Exec sp_ConsultaTroquel


create procedure sp_ConsultaUsuario
as
select * from TablaUsuario

Exec sp_ConsultaUsuario

create procedure sp_CrearCliente

@Cliente varchar(150), @NombreContacto varchar(150),
@Cedula int,@CodigoTroquel varchar(100)
as
begin

insert into TablaCliente
values(@Cliente,@NombreContacto,@Cedula,
@CodigoTroquel)
end
go

exec sp_CrearCliente 'moises','aguilar',115151,'rfr4545';


create procedure sp_ModificarCliente

@Cliente varchar(150), @NombreContacto varchar(150),
@Cedula int,@CodigoTroquel varchar(100)
as
begin

update TablaCliente set  Cliente = @Cliente ,NombreContacto =@NombreContacto,codigoTroquel = @CodigoTroquel where Cedula = @Cedula;
end
go


exec sp_ModificarCliente 'wendy',116110727, 'dedfe7777' where = 'moises';


create procedure sp_EliminarCliente
@Cliente varchar(150), @NombreContacto varchar(150),
@Cedula int,@CodigoTroquel varchar(100)
as
begin
delete TablaCliente where Cedula= @Cedula;
end
go

create procedure sp_CrearUsuario
@Cedula int,@Nombre varchar(100),
@rol varchar(100), @FechaModificacion varchar(100),@Clave varchar(100)
as
begin
insert into TablaUsuario
values(@Cedula,@Nombre,@rol,@FechaModificacion,@Clave)
end
go

create procedure sp_ModificarUsuario
@Cedula int,@Nombre varchar(100),
@rol varchar(100), @FechaModificacion varchar(100),@Clave varchar(100)
as
begin
update TablaUsuario set Nombre=@Nombre , rol= @rol, FechaModificacion= @FechaModificacion, Clave = @Clave where cedula= @Cedula
end
go


create procedure sp_EliminarUsuario
@Cedula int,@Nombre varchar(100),
@rol varchar(100), @FechaModificacion varchar(100)
as
begin
delete TablaUsuario where cedula=@Cedula;
end
go

create procedure sp_CrearTroquel
@Nombre varchar (100),@Codigo varchar (100),
@descripcion varchar (150),@caracteristicas varchar (150),
@Material varchar (150),@FechaOrigen varchar(100),@FechaMantenimiento varchar(100),@Estado varchar (100)
as
begin
 insert into TablaTroquel
 values(@Nombre,@Codigo,@descripcion,@caracteristicas,@Material,@FechaOrigen,@FechaMantenimiento,@Estado)
 end
 go

 create procedure sp_ModificarTroquel
@Nombre varchar (100),@Codigo varchar (100),
@descripcion varchar (150),@caracteristicas varchar (150),
@Material varchar (150),@FechaOrigen varchar(100),@FechaMantenimiento varchar(100),@Estado varchar (100)
as
begin

update TablaTroquel set Nombre=@Nombre , descripcion=@descripcion ,caracteristicas=@caracteristicas , Material=@Material , FechaOrigen= @FechaOrigen,
FechaMantenimiento= @FechaMantenimiento where Codigo= @Codigo;
end
go

 create procedure sp_EliminarTroquel
@Nombre varchar (100),@Codigo varchar (100),
@descripcion varchar (150),@caracteristicas varchar (150),
@Material varchar (150),@FechaOrigen varchar(100),@FechaMantenimiento varchar(100),@Estado varchar (100)
as
begin
delete TablaTroquel where Codigo= @Codigo;
end
go

create procedure sp_ConsultaClienteCED
@Cedula int
as
begin
select * from TablaCliente where Cedula = @Cedula;
end
go

create procedure sp_ConsultaUsuarioCED
@Cedula int
as
begin
select * from TablaUsuario where Cedula = @Cedula;
end
go

create procedure sp_ConsultaTroquelCOD
@Codigo int
as
begin
select * from TablaTroquel where Codigo = @Codigo;
end
go
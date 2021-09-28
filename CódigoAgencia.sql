create database AgenciaAuto;

create table Usuarios(
idUsuarios int primary key auto_increment,
Nombre varchar(50),
Apellidop varchar(50),
Apellidom varchar(50),
Fechanacimiento varchar(50),
RFC varchar(50),
Contraseña varchar(50),
fkidAccesos varchar(50),
foreign key(fkidAccesos) references accesos(idAccesos));

create table Producto(
CodigoBarras varchar(50) primary key,
Nombre varchar(50),
Descripcion varchar(100),
Marca varchar(50));

create table Herramientas(
CodigoHerramienta varchar(50) primary key,
Nombre varchar(50),
Medida varchar(50),
Marca varchar(50),
Descripcion varchar(100));

create table Accesos(
idAccesos varchar(50) primary key,
Lectura boolean,
Estrictura boolean,
Eliminacion boolean,
Actualizacion boolean);

insert into Accesos values
('Administrador',true,true,true,true),
('Usuarios',true,true,false,false),
('Invitado',false,false,false,false);



create table paciente(
	idPaciente int identity primary key,
	nombres varchar(50),
	apellidos varchar(50),
	edad int,
	fechaNacimiento varchar(50),
	email varchar(50),
	telefono varchar(20)
)

create table test(
	idTest int identity primary key,
	idPaciente int,
	respuestas varchar(150)
	foreign key(idPaciente) references paciente(idPaciente)
)

create table diagnostico (
	idDiagnostico int identity primary key,
	puntuacion decimal(15,2),
	descripcion varchar(max),
	idPaciente int,
	idTest int
	foreign key(idPaciente) references paciente(idPaciente),
	foreign key(idTest) references test(idTest)

)




create proc [dbo].[insertarDiagnostico]
@puntuacion decimal(15,2),
@descripcion varchar(max),
@idPaciente int,
@idTest int
as
	insert into diagnostico(puntuacion, descripcion, idPaciente,idTest) values(@puntuacion,@descripcion, @idPaciente, @idTest)

create proc [dbo].[insertarTest]
@idPaciente int,
@respuesta varchar(150)
as
	insert into test(idPaciente, respuestas) values (@idPaciente, @respuesta)


create proc [dbo].[listar_pacientes]
as
select * from paciente
create proc [dbo].[listartests]
as
	select * from test



create table diagnostico (
	idDiagnostico int identity primary key,
	puntuacion decimal(15,2),
	descripcion varchar(max),
	idPaciente int,
	idTest int
	foreign key(idPaciente) references paciente(idPaciente),
	foreign key(idTest) references test(idTest)

)

create table paciente(
	idPaciente int identity primary key,
	nombres varchar(50),
	apellidos varchar(50),
	edad int,
	fechaNacimiento varchar(50),
	email varchar(50),
	telefono varchar(20)
)

create table test(
	idTest int identity primary key,
	idPaciente int,
	respuestas varchar(150)
	foreign key(idPaciente) references paciente(idPaciente)
)
create proc [dbo].[InsertarPaciente]
@idPaciente int output,
@nombres varchar(50),
@apellidos varchar(50),
@edad int,
@fechaNacimiento varchar(50),
@email varchar(50),
@telefono varchar(20)
as
	insert into paciente(nombres, apellidos, edad, fechaNacimiento, email, telefono) values (@nombres,@apellidos,@edad,@fechaNacimiento,@email,@telefono)
	set @idPaciente = @@IDENTITY


create proc traerDiagnostico
@idPaciente int,
@idtest int
as
select * from diagnostico 
where idPaciente = @idPaciente and @idtest = @idtest



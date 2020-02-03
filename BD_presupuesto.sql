--CREAMOS LA BASE DE DATOS
CREATE DATABASE Presupuesto;
GO

--USAMOS LA BASE DE DATOS
USE presupuesto;
GO

--CREAMOS LA TABLA QUE CONTENDRÀ LOS USUARIOS ADMITIDOS PARA INGRESAR AL SISTEMA.
CREATE TABLE usuarios
(usuario VARCHAR(25) NOT NULL,
contraseña VARCHAR(15) NOT NULL)
GO

--LE DEFINIMOS LA CLAVE PRIMARIA A LA TABLA ANTERIOR
ALTER TABLE usuarios
ADD PRIMARY KEY(usuario)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ LA INFORMACIÒN BÀSICA DE CADA PROYECTO.
CREATE TABLE proyectos
(numero_proceso VARCHAR(15) NOT NULL,
nombre VARCHAR(30) NOT NULL,
presupuesto FLOAT NOT NULL,
descripcion VARCHAR(50),
fecha_creacion datetime NOT NULL)
GO

--ASIGNAMOS LA CLAVE PRIMARIA PARA EVITAR DUPLICIDAD DE PROYECTOS Y PARA CREAR LAS RELACIONES CORRESPONDIENTES.
ALTER TABLE proyectos 
ADD PRIMARY KEY(numero_proceso)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ TODOS LOS ITEMS RELACIONADOS CON LA ALIMENTACIÒN.
CREATE TABLE alimentacion
(item VARCHAR(25) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(15) NOT NULL)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ TODO LO RELACIONADO CON RECURSOS HUMANOS.
CREATE TABLE recursos_humanos
(item VARCHAR(35) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
cant_meses INT NOT NULL,
numero_proceso VARCHAR(15) NOT NULL)
GO

--CREAMOS UNA TABLA PARA LOS MATERIALES
CREATE TABLE materiales
(item VARCHAR(35) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(15) NOT NULL)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ LA CATEGORÌA DE OTROS.
CREATE TABLE otros
(item VARCHAR(35) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(15) NOT NULL)
GO

-------------CREAMOS LAS RELACIONES ENTRE TABLAS CORRESPONDIENTES----------------------------------------------

--RELACION ENTRE PROYECTOS Y ALIMENTOS
ALTER TABLE alimentacion
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso)
GO

--CREAMOS RELACION ENTRE PROYECTOS Y RECURSO HUMANO
ALTER TABLE recursos_humanos
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso)
GO

--CREAMOS RELACION ENTRE PROYECTOS Y MATERIALES
ALTER TABLE materiales
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso)
GO

--CREAMOS LA RELACION ENTRE PROYECTOS Y OTROS
ALTER TABLE otros
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso)
GO



--CREAMOS LOS STORED PROCEDURE PARA GUARDAR LA INFORMACIÒN EN LA BASE DE DATOS--

--procedimiento para validar usuario
CREATE PROCEDURE validar_usuario
@usuario VARCHAR(25),
@contraseña VARCHAR(15)
AS
SELECT usuario,contraseña FROM usuarios WHERE usuario=@usuario AND contraseña=@contraseña
GO

--procedimiento almacenado para crear proyecto 
CREATE PROCEDURE crear_proyecto
@numero_proceso VARCHAR(15),
@nombre VARCHAR(30),
@presupuesto FLOAT,
@descripcion VARCHAR(50)
AS
INSERT INTO proyectos(numero_proceso,nombre,presupuesto,descripcion,fecha_creacion) VALUES (@numero_proceso,@nombre,@presupuesto,@descripcion,SYSDATETIME())
GO

--procedimiento almacenado para agregar items de alimentaciòn.
CREATE PROCEDURE agregar_alimento
@item VARCHAR(25),
@cantidad INT,
@valor FLOAT,
@numero_proceso VARCHAR(15)
AS
INSERT INTO alimentacion(item,cantidad,valor,numero_proceso) VALUES (@item,@cantidad,@valor,@numero_proceso)

--Procedimiento almacenado para listar proyectos por nombre.
CREATE PROCEDURE listar_nombre
@filtrar_nombre VARCHAR(30)
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos WHERE nombre like '%'+@filtrar_nombre+'%'

--procedimiento almacenado para mostrar proyectos
CREATE PROCEDURE listar_proceso
@filtrar_proceso VARCHAR(15)
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos WHERE numero_proceso like '%'+@filtrar_proceso+'%'

--procedimiento almacenado para listar presupuesto.
CREATE PROCEDURE listar_presupuesto
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos
--procedimiento almacenado para agregar items de recursos humanos

select * from proyectos
insert into recursos_humanos(item,cantidad,valor,cant_meses,numero_proceso) VALUES ('Geronimo',12,12500,5,'jk45')


select * from proyectos
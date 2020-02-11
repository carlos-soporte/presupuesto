USE MASTER
DROP DATABASE Presupuesto

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
(numero_proceso VARCHAR(25) NOT NULL,
nombre VARCHAR(30) NOT NULL,
presupuesto FLOAT NOT NULL,
descripcion VARCHAR(150),
fecha_creacion datetime NOT NULL)
GO

--ASIGNAMOS LA CLAVE PRIMARIA PARA EVITAR DUPLICIDAD DE PROYECTOS Y PARA CREAR LAS RELACIONES CORRESPONDIENTES.
ALTER TABLE proyectos 
ADD PRIMARY KEY(numero_proceso)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ TODOS LOS ITEMS RELACIONADOS CON LA ALIMENTACIÒN.
CREATE TABLE alimentacion
(id_alimento INT IDENTITY,
item VARCHAR(25) NOT NULL,
cantidad INT NOT NULL,
valor_oficial FLOAT,
valor_ofertado FLOAT,
C_Entregada INT,
C_Restante INT,
numero_proceso VARCHAR(25) NOT NULL)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ TODO LO RELACIONADO CON RECURSOS HUMANOS.
CREATE TABLE recursos_humanos
(id_recurso INT IDENTITY,
Cargo VARCHAR(30) NOT NULL,
N_Profesional VARCHAR(40) NOT NULL,
Tiempo_meses INT NOT NULL,
V_Oficial FLOAT NOT NULL,
V_Ofertado FLOAT NOT NULL,
Observaciones VARCHAR(100) NOT NULL,
numero_proceso VARCHAR(25) NOT NULL)
GO

--CREAMOS UNA TABLA PARA LOS MATERIALES
CREATE TABLE materiales
(id_material INT IDENTITY,
item VARCHAR(35) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(25) NOT NULL)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ LA CATEGORÌA DE OTROS.
CREATE TABLE otros
(id_otro  INT IDENTITY,
item VARCHAR(35) NOT NULL,
cantidad INT NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(25) NOT NULL)
GO

-------------CREAMOS LAS RELACIONES ENTRE TABLAS CORRESPONDIENTES----------------------------------------------


--RELACION ENTRE PROYECTOS Y ALIMENTOS
ALTER TABLE alimentacion
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso) ON DELETE CASCADE
GO

--CREAMOS RELACION ENTRE PROYECTOS Y RECURSO HUMANO
ALTER TABLE recursos_humanos
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso) ON DELETE CASCADE
GO

--CREAMOS RELACION ENTRE PROYECTOS Y MATERIALES
ALTER TABLE materiales
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso) ON DELETE CASCADE
GO

--CREAMOS LA RELACION ENTRE PROYECTOS Y OTROS
ALTER TABLE otros
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso) ON DELETE CASCADE
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
@numero_proceso VARCHAR(25),
@nombre VARCHAR(30),
@presupuesto FLOAT,
@descripcion VARCHAR(150)
AS
INSERT INTO proyectos(numero_proceso,nombre,presupuesto,descripcion,fecha_creacion) VALUES (@numero_proceso,@nombre,@presupuesto,@descripcion,SYSDATETIME())
GO



--Procedimiento almacenado para listar proyectos por nombre.
CREATE PROCEDURE listar_nombre
@filtrar_nombre VARCHAR(30)
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos WHERE nombre like '%'+@filtrar_nombre+'%'
GO

--procedimiento almacenado para mostrar proyectos
CREATE PROCEDURE listar_proceso
@filtrar_proceso VARCHAR(25)
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos WHERE numero_proceso like '%'+@filtrar_proceso+'%'
GO

--procedimiento almacenado para listar presupuesto.
CREATE PROCEDURE listar_presupuesto
AS
SELECT numero_proceso,nombre,presupuesto,descripcion,fecha_creacion FROM proyectos
GO

--procedimiento almacenado para eliminar proyectos
CREATE PROCEDURE eliminar_proyectos
@numero_proceso VARCHAR(25)
AS
DELETE FROM proyectos WHERE numero_proceso=@numero_proceso
GO

--procedimiento almacenado para modificar proyecto
CREATE PROCEDURE modificar_proyectos
@numero_proceso VARCHAR(25),
@nombre VARCHAR(30),
@presupuesto FLOAT,
@descripcion VARCHAR(150)
AS
UPDATE proyectos SET nombre=@nombre,presupuesto=@presupuesto,descripcion=@descripcion WHERE numero_proceso=@numero_proceso
GO

--procedimiento almacenado para agregar items de alimentaciòn.
CREATE PROCEDURE agregar_alimento
@item VARCHAR(25),
@cantidad INT,
@valor_oficial FLOAT,
@valor_ofertado FLOAT,
@C_Entregada INT,
@C_Restante INT,
@numero_proceso VARCHAR(25)
AS
INSERT INTO alimentacion(item,cantidad,valor_oficial,valor_ofertado,C_Entregada,C_Restante,numero_proceso) VALUES (@item,@cantidad,@valor_oficial,@valor_ofertado,@C_Entregada,@C_Restante,@numero_proceso)
GO

--Procedimiento almacenado para mostrar alimentos
CREATE PROCEDURE listar_alimentos
@numero_proceso VARCHAR(25)
AS
SELECT item,cantidad,valor_oficial,valor_ofertado,C_Entregada,C_Restante,numero_proceso FROM alimentacion WHERE numero_proceso=@numero_proceso
GO

--procedimiento almacenado para agregar items de recurso_humano
CREATE PROCEDURE agregar_recurso
@cargo varchar(30),
@profesional VARCHAR(30),
@meses INT,
@valor_oficial FLOAT,
@valor_ofertado FLOAT,
@observaciones	VARCHAR(100),
@numero_proceso VARCHAR(25)
AS
INSERT INTO recursos_humanos(Cargo,N_Profesional,Tiempo_meses,V_Oficial,V_Ofertado,Observaciones,numero_proceso) VALUES (@cargo,@profesional,@meses,@valor_oficial,@valor_ofertado,@observaciones,@numero_proceso)
GO
--procedimiento almacenado para listar items de recursos humanos.
CREATE PROCEDURE listar_recurso
@numero_proceso VARCHAR(25)
AS
SELECT Cargo,N_Profesional,Tiempo_meses,V_Oficial,V_Ofertado,Observaciones,numero_proceso from recursos_humanos WHERE numero_proceso=@numero_proceso
GO
--procedimiento almacenado para actualizar datos de recurso humano.
CREATE PROCEDURE modificar_recurso
@cargo VARCHAR(30),
@profesional VARCHAR(30),
@meses INT,
@valor_oficial FLOAT,
@valor_ofertado FLOAT,
@observacion Varchar(100),
@numero_proceso VARCHAR(25),
@id_recurso INT
AS
UPDATE recursos_humanos SET Cargo=@cargo,N_Profesional=@profesional,Tiempo_meses=@meses,V_Oficial=@valor_oficial,V_Ofertado=@valor_ofertado,Observaciones=@observacion WHERE numero_proceso=@numero_proceso	AND id_recurso=@id_recurso				
GO
select * from recursos_humanos



EXEC crear_proyecto '40001','caracterizacion','100','perragata'

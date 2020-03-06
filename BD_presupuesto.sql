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

--CREAMOS UNA TABLA QUE CONTENDRÀ TODO LO RELACIONADO CON RECURSOS HUMANOS.
CREATE TABLE recursos_humanos
(
id_recurso INT IDENTITY,
Cargo VARCHAR(30) NOT NULL,
N_Profesional VARCHAR(40) NOT NULL,
Tiempo_meses INT NOT NULL,
V_Oficial FLOAT NOT NULL,
V_Ofertado FLOAT NOT NULL,
Observaciones VARCHAR(100) NOT NULL,
numero_proceso VARCHAR(25) NOT NULL
)
GO

--CREAMOS UNA TABLA QUE CONTENDRÀ TODOS LOS ITEMS RELACIONADOS CON LA ALIMENTACIÒN.
CREATE TABLE alimentacion
(id_alimento INT IDENTITY,
item VARCHAR(25) NOT NULL,
cantidad INT NOT NULL,
valor_oficial FLOAT NOT NULL,
valor_ofertado FLOAT NOT NULL,
ValorOficialTotal FLOAT NOT NULL,
ValorOfertadoTotal FLOAT NOT NULL,
C_Entregada INT NOT NULL,
C_Restante INT NOT NULL,
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

--CREAMOS UNA TABLA QUE CONTENDRA EL VALOR ASIGNADO PARA CADA  ITEM.
CREATE TABLE asignar
(
nombre VARCHAR(25) NOT NULL,
valor FLOAT NOT NULL,
numero_proceso VARCHAR(25) NOT NULL
)
GO

--CREAMO LA RELACION ENTRE LAS TABLAS

ALTER TABLE asignar
ADD FOREIGN KEY(numero_proceso) REFERENCES proyectos(numero_proceso)ON DELETE CASCADE
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

-- CREAMOS PROCEDIMIENTO ALMACENADO PARA ALMACENAR ITEMS DE RECURSO
CREATE PROCEDURE asignar_pto
(
@nombre VARCHAR(25),
@valor FLOAT,
@numero_proceso VARCHAR(25)
)
AS
INSERT INTO asignar(nombre,valor,numero_proceso) VALUES(@nombre,@valor,@numero_proceso)
GO

--CREAMOS PROCEDIMIENTO ALMACENADO PARA LISTAR PTO OFFICIAL DE RECURSO
CREATE PROCEDURE listar_pto
(
@nombre VARCHAR(25),
@numero_proceso VARCHAR(25)
)
AS
SELECT valor FROM asignar WHERE numero_proceso=@numero_proceso and  nombre=@nombre
GO

--CREAMOS PROCEDIMIENTO ALMACENADO PARA MODIFICAR PTO DE RECURSO
CREATE PROCEDURE modificar_pto
(
@nombre VARCHAR(25),
@valor FLOAT,
@numero_proceso VARCHAR(25)
)
AS
UPDATE asignar SET nombre=@nombre,valor=@valor WHERE numero_proceso=@numero_proceso
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
SELECT id_recurso,Cargo,N_Profesional,Tiempo_meses,V_Oficial,V_Ofertado,Observaciones,numero_proceso from recursos_humanos WHERE numero_proceso=@numero_proceso
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

--procedimiento almacenado para eliminar datos de recurso humano.

CREATE PROCEDURE eliminar_recurso
@id_recurso INT,
@numero_proceso VARCHAR(25)
AS
DELETE FROM recursos_humanos WHERE id_recurso=@id_recurso and numero_proceso=@numero_proceso
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
INSERT INTO alimentacion(item,cantidad,valor_oficial,valor_ofertado,C_Entregada,C_Restante,ValorOficialTotal,ValorOfertadoTotal,numero_proceso) VALUES (@item,@cantidad,@valor_oficial,@valor_ofertado,@C_Entregada,@C_Restante,@cantidad*@valor_oficial,@cantidad*@valor_ofertado,@numero_proceso)
GO

--Procedimiento almacenado para mostrar alimentos
CREATE PROCEDURE listar_alimentos
@numero_proceso VARCHAR(25)
AS
SELECT id_alimento,item,cantidad,valor_oficial,valor_ofertado,ValorOficialTotal,ValorOfertadoTotal,C_Entregada,C_Restante,numero_proceso FROM alimentacion WHERE numero_proceso=@numero_proceso
GO

--Procedimiento almacenado para actualizar los alimentos
CREATE PROCEDURE ActualizarAlimento
@id_alimento INT,
@item VARCHAR(25),
@cantidad INT,
@valor_oficial FLOAT,
@valor_ofertado FLOAT,
@C_Entregada INT,
@C_Restante INT,
@numero_proceso VARCHAR(25)
AS
UPDATE alimentacion SET item=@item,cantidad=@cantidad,valor_oficial=@valor_oficial,valor_ofertado=@valor_ofertado,ValorOficialTotal=@cantidad*@valor_oficial,ValorOfertadoTotal=@cantidad*valor_ofertado,C_Entregada=@C_Entregada,C_Restante=@C_Restante WHERE numero_proceso=@numero_proceso AND id_alimento=@id_alimento
GO

--Procedimiento almacenado para eliminar los items de alimentos.
CREATE PROCEDURE EliminarAlimento
@id_alimento INT,
@numero_proceso VARCHAR(25)
AS
DELETE FROM alimentacion WHERE id_alimento=@id_alimento AND numero_proceso=@numero_proceso
GO





-----REGISTROS DE PRUEBAS


--se insertan usuarios
EXEC validar_usuario'duban',1234
GO
EXEC validar_usuario 'carlos',1234
GO

-- se crean  proyectos

EXEC crear_proyecto '4','caracterizacion','1','perragata'
EXEC crear_proyecto '41','perra','10','perrogata'
EXEC crear_proyecto '401','jabali','100','oso hormiguero'
EXEC crear_proyecto '4001','snake','1000','pez foca'
EXEC crear_proyecto '40001','spider','10000','iguana'
GO

-- items de recurso humano
EXEC agregar_recurso 'sistemas','culo',1,5,4,'hola bb','41'
EXEC agregar_recurso 'ciencias','mosca',2,50,20,'hola bb','41'
EXEC agregar_recurso 'sociales','hormiga',3,500,200,'hola bb','41'
EXEC agregar_recurso 'ingles','luna',4,5000,2000,'hola bb','41'
EXEC agregar_recurso 'calculo','paja',5,50000,20000,'hola bb','41'
GO

-- items de alimentacion

EXEC agregar_alimento'tuflor',1,11,5.5,100,8,'4'
EXEC agregar_alimento 'pera',10,22,11,200,4,'4'
EXEC agregar_alimento 'sol',101,33,16.5,300,2,'4'
EXEC agregar_alimento 'estrella',44,22,400,2000,1,'4'
EXEC agregar_alimento'planeta',90,45,500,15,7,'4'
GO



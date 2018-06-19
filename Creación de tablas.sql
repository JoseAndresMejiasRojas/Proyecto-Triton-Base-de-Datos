-- Creación de tablas

USE Triton


CREATE TABLE Atleta
( 
	Correo_PK			VARCHAR(30),
	Talla_Camiseta		VARCHAR(30),
	ZIP_Code			INTEGER,
	País				VARCHAR(30),
	Provincia			VARCHAR(30),
	Ciudad				VARCHAR(30),
	Redes_Sociales		VARCHAR(30),
	Fecha_Nacimiento	DATE,	
	Nombre				VARCHAR(50)	NOT NULL,
	Apellido1			VARCHAR(50)	NOT NULL,
	Apellido2			VARCHAR(50),
	Sexo				CHAR,
	Telefonos			VARCHAR(20),	-- OJO.
	Observaciones		VARCHAR(500),
	Modelo				VARCHAR(50),
	Marca				VARCHAR(50),
	Contraseña			VARCHAR(20)	NOT NULL,
	Inscripcion			INTEGER		NOT NULL

	CONSTRAINT PK_Correo_Atleta PRIMARY KEY (Correo_PK),
	CONSTRAINT CK_ZIP_Code_Atleta CHECK (ZIP_Code >= 10000 AND ZIP_CODE <= 99999),	-- 5 dígitos.
	CONSTRAINT CK_Inscripcion_Atleta CHECK (Inscripcion > 0)	
);

CREATE TABLE Prueba_Fisica
( 
	Correo_FK		VARCHAR(30),
	Fecha_Prueba_PK	DATE,
	Tipo_Prueba_PK	VARCHAR(50),
	Resultados		VARCHAR(500) NOT NULL	-- Si se crea la tupla, obligatoriamente se hizo una prueba, por lo que tiene que haber resultados.

	CONSTRAINT PK_Correo_Fecha_Prueba_Tipo_Prueba_Prueba_Fisica PRIMARY KEY (Correo_FK, Fecha_Prueba_PK, Tipo_Prueba_PK ),
	CONSTRAINT FK_Correo_Prueba_Fisica_Prueba_Fisica FOREIGN KEY (Correo_FK)	REFERENCES Atleta(Correo_PK)
		ON DELETE	CASCADE	-- Si se elimina el atleta, no hay porqué mantener las pruebas.
		ON UPDATE	CASCADE
);

CREATE TABLE Cobro
( 
	ID_Factura_PK			INTEGER,
	Correo_FK				VARCHAR(30) DEFAULT 'Atleta suprimido',
	Fecha_Pago				DATE		NOT NULL,
	Fecha_Finalización		DATE		NOT NULL,
	Número_Tarjeta			VARCHAR(16)	NOT NULL,
	Fecha_Vencimiento		DATE		NOT NULL,
	CVC						INTEGER		NOT NULL,
	Codigo_Descuento		INTEGER,
	Duracion_Descuento		DATE,
	Porcentaje_Descuento	INTEGER DEFAULT 0	-- CREO JEJE

	CONSTRAINT PK_ID_Factura_Cobro PRIMARY KEY (ID_Factura_PK),
	CONSTRAINT FK_Correo_Cobro FOREIGN KEY (Correo_FK) REFERENCES Atleta(Correo_PK)
		ON DELETE SET DEFAULT
		ON UPDATE CASCADE,
	CONSTRAINT CK_CVC_Cobro CHECK( CVC <= 999 AND CVC >= 0 ),
	CONSTRAINT CK_Porcentaje_Descuento_Cobro CHECK( Porcentaje_Descuento >= 0 AND  Porcentaje_Descuento <= 100 )
);

CREATE TABLE Cobro_Mensual
(
	ID_Factura_FK		INTEGER,
	Monto_Mensual	INTEGER	NOT NULL,
	Monto_Final		INTEGER NOT NULL

	CONSTRAINT PK_ID_Factura_Cobro_Mensual PRIMARY KEY (ID_Factura_FK),
	CONSTRAINT FK_ID_Factura_Cobro_Mensual FOREIGN KEY(ID_Factura_FK) REFERENCES Cobro(ID_Factura_PK)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT CK_Monto_Mensual_Cobro_Mensual CHECK( Monto_Mensual > 0 ),
	CONSTRAINT CK_Monto_Final_Cobro_Mensual CHECK( Monto_Final > 0 )
);

CREATE TABLE Cobro_Individual
(
	ID_Factura_FK		INTEGER,
	Monto_Semanal		INTEGER	NOT NULL,
	Monto_Total			INTEGER NOT NULL,
	Cantidad_Semanas	INTEGER NOT NULL,

	CONSTRAINT PK_ID_Factura_Cobro_Individual PRIMARY KEY (ID_Factura_FK),
	CONSTRAINT FK_ID_Factura_Cobro_Individual FOREIGN KEY(ID_Factura_FK) REFERENCES Cobro(ID_Factura_PK)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT CK_Monto_Semanal_Cobro_Individual CHECK( Monto_Semanal > 0 ),
	CONSTRAINT CK_Monto_Total_Cobro_Individual CHECK( Monto_Total > 0 ),
	CONSTRAINT CK_Cantidad_Semanas_Cobro_Individual CHECK( Cantidad_Semanas > 0 )
);

CREATE TABLE Bloque_Entrenamiento
(
	Correo_FK				VARCHAR(30),
	Numero_Entrenamiento_PK	INTEGER,
	Rango_Horas				FLOAT			NOT NULL,
	Descripcion				VARCHAR(500),
	Formulario				VARCHAR(500),
	Dia_Inicio				DATE			NOT NULL,

	CONSTRAINT PK_Correo_Numero_Entrenamiento_Bloque_Entrenamiento PRIMARY KEY (Correo_FK, Numero_Entrenamiento_PK),
	CONSTRAINT FK_Correo_Bloque_Entrenamiento FOREIGN KEY(Correo_FK) REFERENCES Atleta(Correo_PK)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT CK_Rango_Horas_Bloque_Entrenamiento CHECK (Rango_Horas > 24.0 AND Rango_Horas > 0.0)

);

CREATE TABLE Etiqueta
(
	Correo_FK				VARCHAR(30),
	Numero_Entrenamiento_FK	INTEGER,
	Etiqueta_PK				VARCHAR(50)

	CONSTRAINT PK_Correo_Numero_Entrenamiento_Etiqueta PRIMARY KEY (Correo_FK, Numero_Entrenamiento_FK, Etiqueta_PK), 
	CONSTRAINT FK_Correo_Numero_Entrenamiento_Etiqueta FOREIGN KEY (Correo_FK, Numero_Entrenamiento_FK) REFERENCES Bloque_Entrenamiento(Correo_FK, Numero_Entrenamiento_PK)
		ON DELETE CASCADE	-- OJO
		ON UPDATE CASCADE
);

CREATE TABLE Entrenamiento_Individual
(
	Codigo_Entrenamiento_PK	INTEGER,
	Deporte					VARCHAR(20)		NOT NULL,
	Rutina					VARCHAR(500)	NOT NULL,
	Nivel					VARCHAR(12)		NOT NULL

	CONSTRAINT PK_Codigo_Entrenamiento_Entrenamiento_Individual PRIMARY KEY(Codigo_Entrenamiento_PK)
);

CREATE TABLE Compuesto
(
	Codigo_Entrenamiento_FK	INTEGER,
	Correo_FK				VARCHAR(30),
	Numero_Entrenamiento_FK	INTEGER

	CONSTRAINT PK_Codigo_Entrenamiento_Correo_Numero_Entrenamiento_Compuesto PRIMARY KEY (Codigo_Entrenamiento_FK, Correo_FK, Numero_Entrenamiento_FK),
	CONSTRAINT FK_Correo_Numero_Entrenamiento_Compuesto FOREIGN KEY (Correo_FK, Numero_Entrenamiento_FK) REFERENCES Bloque_Entrenamiento(Correo_FK, Numero_Entrenamiento_PK)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FK_Codigo_Entrenamiento_Compuesto FOREIGN KEY (Codigo_Entrenamiento_FK) REFERENCES Entrenamiento_Individual(Codigo_Entrenamiento_PK)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
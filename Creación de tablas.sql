-- Creación de tablas

USE Triton


CREATE TABLE Atleta
(
	Codigo_Atleta_PK	INTEGER IDENTITY,	-- IDENTITY genera un valor único para cada tupla.  Por defecto inicia en 1. 
	Correo				VARCHAR(30)	UNIQUE,
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
	Telefonos			VARCHAR(20),
	Observaciones		VARCHAR(500),
	Modelo				VARCHAR(50),
	Marca				VARCHAR(50),
	Contraseña			VARCHAR(20)	NOT NULL,
	Inscripcion			MONEY		NOT NULL

	CONSTRAINT PK_Codigo_Atleta PRIMARY KEY (Codigo_Atleta_PK),
	CONSTRAINT CK_ZIP_Code_Atleta CHECK (ZIP_Code >= 10000 AND ZIP_CODE <= 99999),	-- 5 dígitos.
	CONSTRAINT CK_Inscripcion_Atleta CHECK (Inscripcion >= 0)	
);

CREATE TABLE Prueba_Fisica
( 
	Codigo_Atleta_FK	INTEGER,
	Fecha_Prueba_PK		DATE,
	Tipo_Prueba_PK		VARCHAR(50),
	Resultados			VARCHAR(500) NOT NULL	-- Si se crea la tupla, obligatoriamente se hizo una prueba, por lo que tiene que haber resultados.

	CONSTRAINT PK_Codigo_Fecha_Prueba_Tipo_Prueba_Prueba_Fisica PRIMARY KEY (Codigo_Atleta_FK, Fecha_Prueba_PK, Tipo_Prueba_PK ),
	CONSTRAINT FK_Codigo_Prueba_Fisica_Prueba_Fisica FOREIGN KEY (Codigo_Atleta_FK)	REFERENCES Atleta(Codigo_Atleta_PK)
		ON DELETE CASCADE	-- Si se elimina el atleta, no hay porqué mantener las pruebas (las pruebas son "únicas" para cada atleta)
		ON UPDATE CASCADE
);

CREATE TABLE Cobro
( 
	ID_Factura_PK			INTEGER,
	Codigo_Atleta_FK		INTEGER,		-- El -1 representa atleta fuera del sistema
	Fecha_Pago				DATE		NOT NULL,
	Fecha_Finalización		DATE		NOT NULL,
	Número_Tarjeta			VARCHAR(16)	NOT NULL,
	Fecha_Vencimiento		DATE		NOT NULL,
	CVC						INTEGER		NOT NULL,
	Codigo_Descuento		INTEGER,
	Duracion_Descuento		DATE,
	Porcentaje_Descuento	INTEGER

	CONSTRAINT PK_ID_Factura_Cobro PRIMARY KEY (ID_Factura_PK),
	CONSTRAINT FK_Codigo_Atleta_Cobro FOREIGN KEY (Codigo_Atleta_FK) REFERENCES Atleta(Codigo_Atleta_PK)
		ON DELETE SET NULL -- Si se elimina el atleta, se mantiene el cobro para tener un historial.
		ON UPDATE CASCADE,
	CONSTRAINT CK_CVC_Cobro CHECK( CVC <= 999 AND CVC >= 0 ),
	CONSTRAINT CK_Porcentaje_Descuento_Cobro CHECK( Porcentaje_Descuento >= 0 AND  Porcentaje_Descuento <= 100 )
);

CREATE TABLE Cobro_Mensual
(
	ID_Factura_FK	INTEGER,
	Monto_Mensual	MONEY	NOT NULL,
	Monto_Final		MONEY -- Derivado

	CONSTRAINT PK_ID_Factura_Cobro_Mensual PRIMARY KEY (ID_Factura_FK),
	CONSTRAINT FK_ID_Factura_Cobro_Mensual FOREIGN KEY(ID_Factura_FK) REFERENCES Cobro(ID_Factura_PK)
		ON DELETE CASCADE	-- Por ser un ISA total.
		ON UPDATE CASCADE,
	CONSTRAINT CK_Monto_Mensual_Cobro_Mensual CHECK( Monto_Mensual >= 0 ),
	CONSTRAINT CK_Monto_Final_Cobro_Mensual CHECK( Monto_Final >= 0 )
);

CREATE TABLE Cobro_Individual
(
	ID_Factura_FK		INTEGER,
	Monto_Semanal		MONEY	NOT NULL,
	Monto_Total			MONEY,				-- Derivado
	Cantidad_Semanas	INTEGER NOT NULL,

	CONSTRAINT PK_ID_Factura_Cobro_Individual PRIMARY KEY (ID_Factura_FK),
	CONSTRAINT FK_ID_Factura_Cobro_Individual FOREIGN KEY(ID_Factura_FK) REFERENCES Cobro(ID_Factura_PK)
		ON DELETE CASCADE	-- Por ser un ISA total.
		ON UPDATE CASCADE,
	CONSTRAINT CK_Monto_Semanal_Cobro_Individual CHECK( Monto_Semanal > 0 ),
	CONSTRAINT CK_Monto_Total_Cobro_Individual CHECK( Monto_Total > 0 ),
	CONSTRAINT CK_Cantidad_Semanas_Cobro_Individual CHECK( Cantidad_Semanas > 0 )
);

CREATE TABLE Bloque_Entrenamiento
(
	Codigo_Atleta_FK		INTEGER,
	Numero_Bloque_PK		INTEGER,
	Rango_Horas				FLOAT			NOT NULL,
	Descripcion				VARCHAR(500),
	Formulario				VARCHAR(500),
	Dia_Inicio				VARCHAR(10)		NOT NULL,

	CONSTRAINT PK_Codigo_Numero_Bloque_Bloque_Entrenamiento PRIMARY KEY (Codigo_Atleta_FK, Numero_Bloque_PK),
	CONSTRAINT FK_Codigo_Atleta_Bloque_Entrenamiento FOREIGN KEY(Codigo_Atleta_FK) REFERENCES Atleta(Codigo_Atleta_PK)
		ON DELETE CASCADE -- Los bloques son únicos para cada atleta.
		ON UPDATE CASCADE,
	CONSTRAINT CK_Rango_Horas_Bloque_Entrenamiento CHECK (Rango_Horas < 24.0 AND Rango_Horas > 0.0)

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
	Codigo_Atleta_FK		INTEGER,
	Numero_Bloque_FK	INTEGER

	CONSTRAINT PK_Codigo_Entrenamiento_Codigo_Atleta_Numero_Bloque_Compuesto PRIMARY KEY (Codigo_Entrenamiento_FK, Codigo_Atleta_FK, Numero_Bloque_FK),
	CONSTRAINT FK_Codigo_Atleta_Numero_Bloque_Compuesto FOREIGN KEY (Codigo_Atleta_FK, Numero_Bloque_FK) REFERENCES Bloque_Entrenamiento(Codigo_Atleta_FK, Numero_Bloque_PK)
		ON DELETE CASCADE -- Si se elimina el Bloque, hay que eliminar la "comunicación" con el entrenamiento individual.
		ON UPDATE CASCADE,
	CONSTRAINT FK_Codigo_Entrenamiento_Compuesto FOREIGN KEY (Codigo_Entrenamiento_FK) REFERENCES Entrenamiento_Individual(Codigo_Entrenamiento_PK)
		ON DELETE CASCADE -- Si se elimina el Entrenamiento, se elimina la "comunicación".
		ON UPDATE CASCADE
);

CREATE TABLE Etiqueta
(
	Etiqueta_PK				VARCHAR(50),
	Codigo_Entrenamiento_FK	INTEGER

	CONSTRAINT PK_Correo_Codigo_Entrenamiento_Etiqueta PRIMARY KEY (Etiqueta_PK, Codigo_Entrenamiento_FK), 
	CONSTRAINT FK_Etiqueta_Codigo_Entrenamiento FOREIGN KEY (Codigo_Entrenamiento_FK) REFERENCES Entrenamiento_Individual(Codigo_Entrenamiento_PK)
		ON DELETE CASCADE -- Al eliminarse el entrenamiento, la tupla relacionada a ese entrenamiento no tiene porqué existir.
		ON UPDATE CASCADE
);


CREATE TABLE aspirante
(
	Nombre varchar(50) NOT NULL,
	Sexo varchar(50) NOT NULL,
	Fecha date NOT NULL,
	Correo varchar(50) NOT NULL,
	Grado int NOT NULL,
	idPrograma int NOT NULL
);

CREATE TABLE Carreras
(
	idPrograma int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Programa varchar(50) NOT NULL
);

INSERT INTO Carreras
VALUES('Computacion');
INSERT INTO Carreras
VALUES('Mecatronica');
INSERT INTO Carreras
VALUES('Telecom');
INSERT INTO Carreras
VALUES('Industrial');
INSERT INTO Carreras
VALUES('Negocios');

--SELECT Carreras.Programa FROM Carreras
--SELECT aspirante.Nombre FROM aspirante
--SELECT aspirante.correo,aspirante.grado,Carreras.Programa FROM aspirante INNER JOIN Carreras ON Carreras.idPrograma = aspirante.idPrograma WHERE aspirante.nombre = 'victor'
--UPDATE aspirante SET aspirante.Correo = 'vosorniom@itam.com.mx',aspirante.idPrograma = 2,aspirante.Grado = 6 WHERE aspirante.Nombre ='victor'
--SELECT * FROM aspirante INNER JOIN Carreras ON Carreras.idPrograma = aspirante.idPrograma WHERE Carreras.Programa = 'industrial'
--SELECT aspirante.Nombre, aspirante.Sexo, aspirante.Fecha, aspirante.correo,aspirante.grado FROM aspirante INNER JOIN Carreras ON Carreras.idPrograma = aspirante.idPrograma WHERE Carreras.Programa = 'computacion'
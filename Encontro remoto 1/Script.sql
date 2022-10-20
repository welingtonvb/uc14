CREATE DATABASE Chapter;

USE Chapter;

CREATE TABLE Livros 
(
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);

INSERT INTO Livros VALUES ('Titulo A', 100, 1);
INSERT INTO Livros VALUES ('Titulo B', 200, 0);
INSERT INTO Livros VALUES ('Titulo C', 300, 0);

SELECT * FROM Livros;
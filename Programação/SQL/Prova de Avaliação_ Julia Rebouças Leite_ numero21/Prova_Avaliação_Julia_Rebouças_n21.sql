-- Grupo I--------------

-- Questao 1 ---------
CREATE DATABASE IF NOT EXISTS encomendas_online
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE encomendas_online;

 -- Questao 2 -------------
CREATE TABLE autores (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL
);

 -- Questao 3 ----------------
 CREATE TABLE livros (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Titulo VARCHAR(200) NOT NULL,
  AnoPublicacao YEAR DEFAULT NULL,
  Autor_ID INT,
  FOREIGN KEY (Autor_ID) REFERENCES autores(ID)
);

-- Questao 4 -----------------
CREATE INDEX idx_Titulo ON livros(Titulo);

-- Questao 5 ---------
ALTER TABLE livros ADD Categoria VARCHAR(100);
ALTER TABLE livros MODIFY AnoPublicacao INT;

-- Questao 6
ALTER TABLE livros DROP COLUMN Categoria;	

-- Questao 7
DROP TABLE IF EXISTS livros;
DROP DATABASE IF EXISTS biblioteca_digital;

-- Grupo 2 ---------------------

-- Questao 8
CREATE DATABASE IF NOT EXISTS biblioteca_digital
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE biblioteca_digital;

CREATE TABLE autores (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL
);

CREATE TABLE livros (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Titulo VARCHAR(200) NOT NULL,
  AnoPublicacao YEAR DEFAULT NULL,
  Autor_ID INT,
  FOREIGN KEY (Autor_ID) REFERENCES autores(ID)
);

-- Questao 9
INSERT INTO autores (Nome) VALUES
('José Saramago'),
('Sophia de Mello Breyner'),
('Eça de Queirós');

-- Questao 10
INSERT INTO livros (Titulo, AnoPublicacao, Autor_ID) VALUES
('Ensaio sobre a Cegueira', 1995, 1),
('A Menina do Mar', 1958, 2),
('Os Maias', 1888, 3);

-- Questao 11
UPDATE livros SET AnoPublicacao = 2000;

-- Questao 12
DELETE FROM livros
WHERE Autor_ID = (SELECT ID FROM autores WHERE Nome = 'Sophia de Mello Breyner');

-- Questao 13 
DELETE FROM autores
WHERE ID NOT IN (SELECT DISTINCT Autor_ID FROM livros WHERE Autor_ID IS NOT NULL);

-- GRUPO 3 - Sistema de Encomendas 

-- Questao 14
CREATE DATABASE IF NOT EXISTS encomendas_online
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE encomendas_online;

-- Questao 15
CREATE TABLE produtos (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Descricao VARCHAR(150) NOT NULL,
  Preco DECIMAL(10,2) NOT NULL,
  Stock INT DEFAULT 0
);

-- Questao 16
INSERT INTO produtos (Descricao, Preco, Stock) VALUES
('Power Bank', 25.50, 10),
('Cabo USB-C', 7.00, 50),
('Coluna Bluetooth', 59.90, 5);

-- Questao 17
UPDATE produtos
SET Stock = Stock + 20
WHERE Preco < 10.00;

-- Questao 18
DELETE FROM produtos
WHERE Stock < 6;

 






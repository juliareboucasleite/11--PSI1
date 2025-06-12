
-- Grupo I – Definição e Modificação de Estruturas

-- 1. Criar base de dados
CREATE DATABASE IF NOT EXISTS biblioteca_digital
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE biblioteca_digital;

-- 2. Criar tabela autores
CREATE TABLE autores (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL
);

-- 3. Criar tabela livros
CREATE TABLE livros (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Titulo VARCHAR(200) NOT NULL,
  AnoPublicacao YEAR DEFAULT NULL,
  Autor_ID INT,
  FOREIGN KEY (Autor_ID) REFERENCES autores(ID)
);

-- 4. Criar índice sobre o campo Titulo
CREATE INDEX idx_Titulo ON livros(Titulo);

-- 5. Modificar a tabela livros
ALTER TABLE livros ADD Categoria VARCHAR(100);
ALTER TABLE livros MODIFY AnoPublicacao INT;

-- 6. Eliminar o campo Categoria
ALTER TABLE livros DROP COLUMN Categoria;

-- 7. Eliminar a tabela livros e a base de dados
DROP TABLE IF EXISTS livros;
DROP DATABASE IF EXISTS biblioteca_digital;

-- Grupo II – Inserção, Atualização e Eliminação de Dados

-- 8. Recriar base de dados e tabelas
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

-- 9. Inserir autores
INSERT INTO autores (Nome) VALUES
('José Saramago'),
('Sophia de Mello Breyner'),
('Eça de Queirós');

-- 10. Inserir três livros
INSERT INTO livros (Titulo, AnoPublicacao, Autor_ID) VALUES
('Ensaio sobre a Cegueira', 1995, 1),
('A Menina do Mar', 1958, 2),
('Os Maias', 1888, 3);

-- 11. Atualizar AnoPublicacao de todos os livros
UPDATE livros SET AnoPublicacao = 2000;

-- 12. Eliminar livros cujo autor seja "Sophia de Mello Breyner"
DELETE FROM livros
WHERE Autor_ID = (SELECT ID FROM autores WHERE Nome = 'Sophia de Mello Breyner');

-- 13. Eliminar autores que não tenham livros associados
DELETE FROM autores
WHERE ID NOT IN (SELECT DISTINCT Autor_ID FROM livros WHERE Autor_ID IS NOT NULL);

-- Grupo III – Sistema de Encomendas

-- 14. Criar base de dados
CREATE DATABASE IF NOT EXISTS encomendas_online
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE encomendas_online;

-- 15. Criar tabela produtos
CREATE TABLE produtos (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Descricao VARCHAR(150) NOT NULL,
  Preco DECIMAL(10,2) NOT NULL,
  Stock INT DEFAULT 0
);

-- 16. Inserir produtos
INSERT INTO produtos (Descricao, Preco, Stock) VALUES
('Power Bank', 25.50, 10),
('Cabo USB-C', 7.00, 50),
('Coluna Bluetooth', 59.90, 5);

-- 17. Atualizar stock de produtos com preço inferior a 10€
UPDATE produtos
SET Stock = Stock + 20
WHERE Preco < 10.00;

-- 18. Eliminar produtos com stock inferior a 6
DELETE FROM produtos
WHERE Stock < 6;

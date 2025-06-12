
-- Criar base de dados
CREATE DATABASE IF NOT EXISTS aluguer_veiculos
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE aluguer_veiculos;

-- Tabela clientes
CREATE TABLE clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  nif VARCHAR(9) NOT NULL UNIQUE,
  telefone VARCHAR(15),
  carta_conducao VARCHAR(100),
  email VARCHAR(100),
  morada VARCHAR(255)
);

-- Tabela agencias
CREATE TABLE agencias (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  localizacao VARCHAR(100),
  contacto VARCHAR(50)
);

SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS funcionarios;
SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE funcionarios (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  agencia_de_atuacao VARCHAR(100)
);
DROP TABLE IF EXISTS registo_de_aluguer;
DROP TABLE IF EXISTS veiculo_seguro;
DROP TABLE IF EXISTS veiculos;
-- Tabela veiculos
CREATE TABLE veiculos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  matricula VARCHAR(15) NOT NULL UNIQUE,
  marca VARCHAR(50),
  modelo VARCHAR(50),
  ano INT,
  quilometragem INT,
  cor VARCHAR(30),
  preco_aluguer DECIMAL(8,2),
  estado_veiculo ENUM('Disponível', 'Alugado', 'Em manutenção'),
  categoria_do_veiculo ENUM('Urbano', 'Comercial', 'Eléctrico', 'Premium'),
  localizacao_id INT
);

-- Tabela localizacoes
CREATE TABLE localizacoes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  numero VARCHAR(10),
  codigo_postal VARCHAR(10),
  morada VARCHAR(255)
);

-- Chave estrangeira de localizacao em veiculos
ALTER TABLE veiculos
ADD FOREIGN KEY (localizacao_id) REFERENCES localizacoes(id);

-- Tabela registo_de_aluguer
CREATE TABLE registo_de_aluguer (
  id INT AUTO_INCREMENT PRIMARY KEY,
  data_inicio DATE NOT NULL,
  data_fim DATE NOT NULL,
  preco_total DECIMAL(8,2),
  cliente INT,
  veiculo INT,
  funcionario_responsavel INT,
  FOREIGN KEY (cliente) REFERENCES clientes(id),
  FOREIGN KEY (veiculo) REFERENCES veiculos(id),
  FOREIGN KEY (funcionario_responsavel) REFERENCES funcionarios(id)
);

-- Isso vai mostrar os nomes das colunas da tabela.
DESC registo_de_aluguer;

-- Inserção de dados fictícios

INSERT INTO agencias (nome, localizacao, contacto) VALUES
('Agência Central', 'Lisboa', '217000000'),
('Agência Norte', 'Porto', '222000000');

INSERT INTO localizacoes (numero, codigo_postal, morada) VALUES
('10', '1000-001', 'Av. da Liberdade, Lisboa'),
('22', '4000-002', 'Rua das Flores, Porto');

INSERT INTO clientes (nome, nif, telefone, email, morada, carta_conducao) VALUES
('João Silva', '123456789', '911111111', 'joao.silva@mail.com', 'Rua A, Lisboa', 'ABC12345'),
('Ana Costa', '987654321', '922222222', 'ana.costa@mail.com', 'Rua B, Porto', 'XYZ98765');

INSERT INTO funcionarios (nome, agencia_de_atuacao) VALUES
('Carlos Ferreira', 'Agência Central'),
('Marta Rodrigues', 'Agência Norte');

INSERT INTO veiculos (matricula, marca, modelo, ano, quilometragem, cor, preco_aluguer, estado_veiculo, categoria_do_veiculo, localizacao_id) VALUES
('AA-11-BB', 'Toyota', 'Yaris', 2020, 50000, 'Branco', 35.50, 'Disponível', 'Urbano', 1),
('CC-22-DD', 'BMW', 'X5', 2022, 20000, 'Preto', 85.00, 'Disponível', 'Premium', 2);

INSERT INTO registo_de_aluguer (data_inicio, data_fim, preco_total, cliente, veiculo, funcionario_responsavel) VALUES
('2024-06-10', '2024-06-15', 177.50, 1, 1, 1),
('2024-06-12', '2024-06-14', 170.00, 2, 2, 2);

INSERT INTO categoria_do_veiculo (tipo) VALUES
('Urbano'),
('Comercial'),
('Eléctrico'),
('Premium');

INSERT INTO estado_veiculo (estado) VALUES
('Disponível'),
('Alugado'),
('Em manutenção');

INSERT INTO seguros (designacao, custo) VALUES
('Seguro Básico', 25.00),
('Seguro Contra Todos os Riscos', 85.00),
('Seguro para Jovens Condutores', 60.00),
('Seguro Premium Plus', 110.00);



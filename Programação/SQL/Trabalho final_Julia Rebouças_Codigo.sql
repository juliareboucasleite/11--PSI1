
-- Criar base de dados
CREATE DATABASE IF NOT EXISTS aluguer_veiculos
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE aluguer_veiculos;

-- Tabela agencias
CREATE TABLE agencias (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  localizacao VARCHAR(100),
  contacto VARCHAR(50),
  horario VARCHAR(100),
  entrega_domicilio BOOLEAN
);

-- Tabela categorias
CREATE TABLE categorias (
  id INT AUTO_INCREMENT PRIMARY KEY,
  tipo VARCHAR(50) NOT NULL
);

-- Tabela seguros
CREATE TABLE seguros (
  id INT AUTO_INCREMENT PRIMARY KEY,
  designacao VARCHAR(100),
  custo DECIMAL(8,2),
  inclui_protecao_roubo BOOLEAN,
  inclui_protecao_danos BOOLEAN,
  franquia DECIMAL(8,2)
);

-- Tabela clientes
CREATE TABLE clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  nif VARCHAR(9) NOT NULL UNIQUE,
  telefone VARCHAR(15),
  email VARCHAR(100),
  morada VARCHAR(255),
  nivel_fidelidade ENUM('Standard', 'Privilege Club', 'Privilege Executive', 'Privilege Elite'),
  pontos_acumulados INT DEFAULT 0
);

-- Tabela funcionarios
CREATE TABLE funcionarios (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  agencia_id INT,
  FOREIGN KEY (agencia_id) REFERENCES agencias(id)
);

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
  tipo_transmissao ENUM('Manual', 'Automático'),
  tipo_combustivel ENUM('Gasolina', 'Diesel', 'Elétrico', 'Híbrido'),
  categoria_id INT,
  seguro_id INT,
  FOREIGN KEY (categoria_id) REFERENCES categorias(id),
  FOREIGN KEY (seguro_id) REFERENCES seguros(id)
);

-- Tabela registo_de_aluguer
CREATE TABLE registo_de_aluguer (
  id INT AUTO_INCREMENT PRIMARY KEY,
  data_inicio DATE NOT NULL,
  data_fim DATE NOT NULL,
  preco_total DECIMAL(8,2),
  cliente_id INT,
  veiculo_id INT,
  funcionario_id INT,
  tipo_periodo ENUM('Hora', 'Dia', 'Semana', 'Mês'),
  FOREIGN KEY (cliente_id) REFERENCES clientes(id),
  FOREIGN KEY (veiculo_id) REFERENCES veiculos(id),
  FOREIGN KEY (funcionario_id) REFERENCES funcionarios(id)
);

-- Tabela extras
CREATE TABLE extras (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(50) NOT NULL,
  categoria VARCHAR(50),
  custo DECIMAL(8,2)
);

-- Tabela associativa registo_extra
CREATE TABLE registo_extra (
  id INT AUTO_INCREMENT PRIMARY KEY,
  registo_id INT,
  extra_id INT,
  FOREIGN KEY (registo_id) REFERENCES registo_de_aluguer(id),
  FOREIGN KEY (extra_id) REFERENCES extras(id)
);


-- Inserção de Agências
INSERT INTO agencias (nome, localizacao, contacto, horario, entrega_domicilio) VALUES
('Agência Central', 'Lisboa', '217000000', '08:00-20:00', TRUE),
('Agência Norte', 'Porto', '222000000', '09:00-18:00', FALSE);

-- Inserção de Categorias
INSERT INTO categorias (tipo) VALUES
('Urbano'), ('Comercial'), ('Eléctrico'), ('Premium');

-- Inserção de Seguros
INSERT INTO seguros (designacao, custo, inclui_protecao_roubo, inclui_protecao_danos, franquia) VALUES
('Seguro Básico', 25.00, FALSE, TRUE, 1000.00),
('Seguro Contra Todos os Riscos', 85.00, TRUE, TRUE, 250.00),
('Seguro para Jovens Condutores', 60.00, TRUE, TRUE, 500.00),
('Seguro Premium Plus', 110.00, TRUE, TRUE, 0.00);

-- Inserção de Clientes
INSERT INTO clientes (nome, nif, telefone, email, morada, nivel_fidelidade, pontos_acumulados) VALUES
('João Silva', '123456789', '911111111', 'joao.silva@mail.com', 'Rua A, Lisboa', 'Privilege Club', 120),
('Ana Costa', '987654321', '922222222', 'ana.costa@mail.com', 'Rua B, Porto', 'Standard', 10);

-- Inserção de Funcionários
INSERT INTO funcionarios (nome, agencia_id) VALUES
('Carlos Ferreira', 1),
('Marta Rodrigues', 2);

-- Inserção de Veículos
INSERT INTO veiculos (matricula, marca, modelo, ano, quilometragem, cor, preco_aluguer, estado_veiculo, tipo_transmissao, tipo_combustivel, categoria_id, seguro_id) VALUES
('AA-11-BB', 'Toyota', 'Yaris', 2020, 50000, 'Branco', 35.50, 'Disponível', 'Manual', 'Gasolina', 1, 1),
('CC-22-DD', 'BMW', 'X5', 2022, 20000, 'Preto', 85.00, 'Disponível', 'Automático', 'Diesel', 4, 4);

-- Inserção de Registos de Aluguer
INSERT INTO registo_de_aluguer (data_inicio, data_fim, preco_total, cliente_id, veiculo_id, funcionario_id, tipo_periodo) VALUES
('2024-06-10', '2024-06-15', 177.50, 1, 1, 1, 'Dia'),
('2024-06-12', '2024-06-14', 170.00, 2, 2, 2, 'Dia');

-- Inserção de Extras
INSERT INTO extras (nome, categoria, custo) VALUES
('GPS', 'Conforto', 5.00),
('Cadeira de Bebé', 'Segurança', 7.50),
('Condutor Adicional', 'Serviço', 10.00),
('Cobertura de Pneus', 'Proteção', 12.00);

-- Inserção de Extras nos Aluguéis
INSERT INTO registo_extra (registo_id, extra_id) VALUES
(1, 1), (1, 3),
(2, 2), (2, 4);

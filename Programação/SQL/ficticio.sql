
-- Inserção de dados fictícios para teste
INSERT INTO agencias (nome, localizacao, contacto) VALUES
('Agência Central', 'Lisboa', '217000000'),
('Agência Norte', 'Porto', '222000000');

INSERT INTO clientes (nome, nif, telefone, email, morada) VALUES
('João Silva', '123456789', '911111111', 'joao.silva@mail.com', 'Rua A, Lisboa'),
('Ana Costa', '987654321', '922222222', 'ana.costa@mail.com', 'Rua B, Porto');

INSERT INTO funcionarios (nome, agencia_id) VALUES
('Carlos Ferreira', 1),
('Marta Rodrigues', 2);

INSERT INTO veiculos (matricula, marca, modelo, ano, quilometragem, cor, preco_aluguer, estado, categoria) VALUES
('AA-11-BB', 'Toyota', 'Yaris', 2020, 50000, 'Branco', 35.50, 'Disponível', 'Urbano'),
('CC-22-DD', 'BMW', 'X5', 2022, 20000, 'Preto', 85.00, 'Disponível', 'Premium');

INSERT INTO alugueres (data_inicio, data_fim, preco_total, cliente_id, veiculo_id, funcionario_id) VALUES
('2024-06-10', '2024-06-15', 177.50, 1, 1, 1),
('2024-06-12', '2024-06-14', 170.00, 2, 2, 2);

-- Inserir registros na tabela "fabricante"
INSERT INTO fabricante (nome) VALUES
('Toyota'),
('Honda'),
('Ford');

INSERT INTO veiculo (IdFabricante, modelo, preco) VALUES
(1, 'Corolla', 25000.00),
(2, 'Civic', 22000.00),
(3, 'F-150', 35000.00);
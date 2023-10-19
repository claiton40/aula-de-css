-- Inserir registros na tabela "fabricante"
INSERT INTO fabricante (IdFabricante,nome) VALUES
(newid(),'Toyota'),
(newid(),'Honda'),
(newid(),'Ford');

INSERT INTO veiculo (IdVeiculo, IdFabricante, modelo, preco) VALUES
(newId(),'22D7002C-D5FD-4DAD-B316-20DB27B3B10B', 'Corolla', 25000.00),
(newId(),'E66AF806-EB37-4EBF-A379-2910E16C1742', 'Civic', 22000.00),
(newId(),'7FBF33B7-AD43-4B78-BA95-CB1EF912B947', 'F-150', 35000.00);
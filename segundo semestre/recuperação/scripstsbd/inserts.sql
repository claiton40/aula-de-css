-- Inserir registros na tabela "fabricante"
INSERT INTO fabricante (IdFabricante,nome) VALUES
(newid(),'Toyota'),
(newid(),'Honda'),
(newid(),'Ford');

INSERT INTO veiculo (IdVeiculo, IdFabricante, modelo, preco) VALUES
(newId(),'E2173E22-A9A3-41F6-8E9A-75FD41C82EBD', 'Corolla', 25000.00),
(newId(),'49BD0FF1-E461-4509-A526-9FE4A8CAD83A', 'Civic', 22000.00),
(newId(),'8A86A44E-AECF-46D9-9CBE-ACA0505052C0', 'F-150', 35000.00);
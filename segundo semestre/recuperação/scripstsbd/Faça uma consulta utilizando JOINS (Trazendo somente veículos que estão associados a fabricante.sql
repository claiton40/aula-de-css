SELECT veiculo.IdVeiculo, veiculo.modelo, veiculo.preco, fabricante.nome
FROM veiculo
INNER JOIN fabricante ON veiculo.IdFabricante = fabricante.IdFabricante;
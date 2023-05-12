using interfaces;

Carrinho carrinho = new Carrinho();

Produto p1 = new Produto (1, "jogo tal", 52.90f);
Produto p2 = new Produto (2, "outro jogo", 52.90f);
Produto p3 = new Produto (3, "jogo pirata", 52.90f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.TotaCarrinho();
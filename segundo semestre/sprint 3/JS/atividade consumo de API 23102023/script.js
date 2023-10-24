

    const urlLocal = "http://localhost:3000/contatos"

        async function cadastrar(e) {
            e.preventDefault();
            const nome = document.getElementById('nome').value
            const sobrenome = document.getElementById('sobrenome').value
            const email = document.getElementById('email').value         
            const pais = document.getElementById('pais').value
            const ddd = document.getElementById('ddd').value
            const telefone = document.getElementById('telefone').value
            const cep = document.getElementById('cep').value
            const rua = document.getElementById('rua').value
            const numero = document.getElementById('numero').value
            const complemento = document.getElementById('complemento').value
            const bairro = document.getElementById('bairro').value
            const UF = document.getElementById('UF').value
            const cidade = document.getElementById('cidade').value
            const notas = document.getElementById('notas').value
            
            

            const objDados = { nome, sobrenome, email, pais, ddd,telefone, cep, rua,  numero, complemento, bairro, UF,  cidade, notas  }
            try {
                const promise = await fetch(urlLocal,
                    {
                        body: JSON.stringify(objDados),
                        headers: { "Content-Type": "application/json" },
                        method: "post"
                    })
                const retorno = await promise.json();
                console.log(retorno);
            } catch (error) {
                alert('deu ruim' + error)
            }
        }   


function exibirEndereco(endereco) {
            document.getElementById("not-found").innerHTML = ""
            document.getElementById("bairro").value = endereco.bairro
            document.getElementById("ddd").value = endereco.ddd
            document.getElementById("rua").value = endereco.logradouro
            document.getElementById("cidade").value = endereco.localidade
            document.getElementById("UF").value = endereco.uf
        }

async function chamarApi() {
            const cep = document.getElementById(
                "cep"
            ).value;

            try {
                const promise = await fetch(`https://viacep.com.br/ws/${cep}/json/`)
                const endereco = await promise.json();
                console.log(endereco);

                //exibir campos
                exibirEndereco(endereco)
            }
            catch (error) {
                document.getElementById("not-found").innerHTML = "CEP Invalido"
                document.getElementById("endereco").value = ""
                document.getElementById("telefone").value = ""
                document.getElementById("bairro").value = ""
                document.getElementById("cidade").value = ""
                document.getElementById("estado").value = ""
                console.log("Deu ruim na API")
            }

        }

        

        
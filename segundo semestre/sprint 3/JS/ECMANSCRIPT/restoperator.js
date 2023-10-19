const evento = {
    dataEvento: new Date(),
    descricao : "Venha aprender JavaScript e todo seu poder!!",
    titulo: "Mão na massa EcmaScript",
    presenca : true,
    comentario: "Gostei do evento"
}

const {dataEvento, descricao,...resto} = evento;

// console.log(`
//     Evento: ${titulo}
//     Descrição: ${descricao}
//     Data: ${dataEvento}
//     Presença: ${presenca ? "Confirmada": "Não confirmada"}
//     Comentário: ${comentario}
// `);

console.log(resto);
﻿using HealthClinic.Domains;

namespace HealthClinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);
        //void Deletar(Guid id);
        List<Especialidade> Listar();
        Especialidade BuscarPorId(Guid id);
        //void Atualizar(Guid id, Especialidade especialidade);
    }
}

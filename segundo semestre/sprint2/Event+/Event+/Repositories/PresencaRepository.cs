using Event_.Contexts;
using Event_.Domains;
using Event_.Interfaces;

namespace Event_.Repositories
{
    public class PresencaRepository : IPresencaEventoRepository
    {
        private readonly Event_Context _context;

        public PresencaRepository()
        {
            _context = new Event_Context();
        }

        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            try
            {
                PresencaEvento presencaEventoBuscado = _context.PresencaEvento.Find(id)!;

                if (presencaEventoBuscado != null)
                {
                    presencaEventoBuscado.Situacao = presencaEvento.Situacao;
                }

                _context.PresencaEvento.Update(presencaEventoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            try
            {
                return _context.PresencaEvento
                    .Select(p => new PresencaEvento
                    {
                        IdPresencaEvento = p.IdPresencaEvento,
                        Situacao = p.Situacao,

                        Evento = new Evento
                        {
                            DataEvento = p.Evento!.DataEvento,
                            NomeEvento = p.Evento.NomeEvento,
                            Descricao = p.Evento.Descricao,

                            Instituicao = new Instituicao
                            {
                                NomeFantasia = p.Evento.Instituicao!.NomeFantasia
                            }
                        }

                    }).FirstOrDefault(p => p.IdPresencaEvento == id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                PresencaEvento presencaEventoBuscado = _context.PresencaEvento.Find(id)!;

                if (presencaEventoBuscado != null)
                {
                    _context.PresencaEvento.Remove(presencaEventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inscrever(PresencaEvento inscricao)
        {
            try
            {
                _context.PresencaEvento.Add(inscricao);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEvento> Listar()
        {
            try
            {
                return _context.PresencaEvento.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEvento> ListarMinhas(Guid id)
        {
            return _context.PresencaEvento
                .Select(p => new PresencaEvento
                {
                    IdPresencaEvento = p.IdPresencaEvento,
                    Situacao = p.Situacao,

                    Evento = new Evento
                    {
                        DataEvento = p.Evento!.DataEvento,
                        NomeEvento = p.Evento.NomeEvento,
                        Descricao = p.Evento.Descricao,

                        Instituicao = new Instituicao
                        {
                            NomeFantasia = p.Evento.Instituicao!.NomeFantasia
                        }
                    }

                }).Where(p => p.IdUsuario == id).ToList();
        }
    }
}
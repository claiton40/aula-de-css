using Event_.Contexts;
using Event_.Domains;
using Event_.Interfaces;

namespace Event_.Repositories
{
    public class ComentariosEventoRepository : IComentarioEventoRepository
    {
        private readonly Event_Context _context;

        public ComentariosEventoRepository()
        {
            _context = new Event_Context();
        }

        public ComentarioEvento BuscarPorId(Guid id)
        {
            try
            {
                return _context.ComentarioEvento
                    .Select(c => new ComentarioEvento
                    {
                        Descricao = c.Descricao,
                        Exibe = c.Exibe,

                        Usuario = new Usuario
                        {
                            Nome = c.Usuario!.Nome
                        },

                        Evento = new Evento
                        {
                            NomeEvento = c.Evento!.NomeEvento,
                        }

                    }).FirstOrDefault(c => c.IdComentarioEvento == id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {
            try
            {
                _context.ComentarioEvento.Add(comentarioEvento);
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
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEvento.Find(id)!;

                if (comentarioEventoBuscado != null)
                {
                    _context.ComentarioEvento.Remove(comentarioEventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ComentarioEvento> Listar()
        {

            try
            {
                return _context.ComentarioEvento
                    .Select(c => new ComentarioEvento
                    {
                        Descricao = c.Descricao,
                        Exibe = c.Exibe,

                        Usuario = new Usuario
                        {
                            Nome = c.Usuario!.Nome
                        },

                        Evento = new Evento
                        {
                            NomeEvento = c.Evento!.NomeEvento,
                        }

                    }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

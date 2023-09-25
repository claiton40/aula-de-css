using Event_.Contexts;
using Event_.Domains;
using Event_.Interfaces;

namespace Event_.Repositories
{
    public class TiposEventoRepository : ITipoEventoRepository
    {
        private readonly Event_Context _context;

        public TiposEventoRepository()
        {
            _context = new Event_Context();
        }

        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            try
            {
                TiposEvento tipoBuscado = _context.TipoEvento.Find(id)!;

                if (tipoBuscado != null)
                {
                    tipoBuscado.Titulo = tipoEvento.Titulo;
                }

                _context.TipoEvento.Update(tipoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                return _context.TipoEvento.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TipoEvento tipoEvento)
        {
            try
            {
                _context.TipoEvento.Add(tipoEvento);

                _context.SaveChanges();
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
                TipoEvento tipoBuscado = _context.TipoEvento.Find(id)!;

                if (tipoBuscado != null)
                {
                    _context.TipoEvento.Remove(tipoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TipoEvento> Listar()
        {
            try
            {
                return _context.TipoEvento.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

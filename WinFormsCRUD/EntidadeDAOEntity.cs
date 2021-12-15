using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCRUD.Dados;
using WinFormsCRUD.Negocio;

namespace WinFormsCRUD
{
    class EntidadeDAOEntity : IEntidadeDAO, IDisposable
    {
        private EntidadeContext contexto;

        public EntidadeDAOEntity()
        {
            this.contexto = new EntidadeContext();
        }
        public void Adicionar(Entidade e)
        {
            contexto.Entidades.Add(e);
            contexto.SaveChanges();
        }

        public void Atualizar(Entidade e)
        {
            contexto.Entidades.Update(e);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Entidade> Entidades()
        {
            return contexto.Entidades.ToList();
        }

        public void Remover(Entidade e)
        {
            contexto.Entidades.Remove(e);
            contexto.SaveChanges();
        }
    }
}

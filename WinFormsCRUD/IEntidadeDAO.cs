using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCRUD.Negocio;

namespace WinFormsCRUD
{
    public interface IEntidadeDAO
    {
        void Adicionar(Entidade e);
        void Atualizar(Entidade e);
        void Remover(Entidade e);
        IList<Entidade> Entidades();

    }
}

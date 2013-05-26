using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACliente
{
    //Interface implementada pelas janelas de Propriedades dos objetos (que contêm os campos preenchidos ou a preencher).
    public interface IDialogo<T>
    {
        string Nome { get;}
        string Titulo { get; set; }
        void setObject(T obj);
        void salvar();
    }
}

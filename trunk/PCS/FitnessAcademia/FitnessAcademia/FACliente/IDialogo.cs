using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACliente
{
    public interface IDialogo<T>
    {
        string Nome { get;}
        string Titulo { get; set; }
        void setObject(T obj);
        void salvar();
    }
}

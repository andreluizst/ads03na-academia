using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroPesquisar:Exception
    {
        public ErroPesquisar()
            : base()
        {
        }

        public ErroPesquisar(String message)
            : base(message)
        {
        }

        public ErroPesquisar(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

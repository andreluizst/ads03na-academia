using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroInclusao:Exception
    {
        public ErroInclusao()
            : base()
        {
        }

        public ErroInclusao(String message)
            : base(message)
        {
        }

        public ErroInclusao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

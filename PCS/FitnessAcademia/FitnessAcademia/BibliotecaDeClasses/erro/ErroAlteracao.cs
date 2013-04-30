using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroAlteracao:Exception
    {
        public ErroAlteracao()
            : base()
        {
        }

        public ErroAlteracao(String message)
            : base(message)
        {
        }

        public ErroAlteracao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

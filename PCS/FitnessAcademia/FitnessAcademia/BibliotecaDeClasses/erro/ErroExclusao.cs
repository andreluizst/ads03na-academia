using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroExclusao:Exception
    {
        public ErroExclusao()
            : base()
        {
        }

        public ErroExclusao(String message)
            : base(message)
        {
        }

        public ErroExclusao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

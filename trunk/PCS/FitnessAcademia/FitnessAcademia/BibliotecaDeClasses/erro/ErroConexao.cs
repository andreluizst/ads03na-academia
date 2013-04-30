using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroConexao:Exception
    {
        public ErroConexao()
            : base()
        {
        }

        public ErroConexao(String message)
            : base(message)
        {
        }

        public ErroConexao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

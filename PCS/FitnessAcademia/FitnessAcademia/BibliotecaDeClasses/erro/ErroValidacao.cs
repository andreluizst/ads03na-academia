using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroValidacao : Exception
    {
        public ErroValidacao()
            : base()
        {
        }

        public ErroValidacao(String message)
            : base(message)
        {
        }

        public ErroValidacao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

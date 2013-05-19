using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.erro
{
    class ErroValidacao : Exception
    {
        private string local;

        public ErroValidacao()
            : base()
        {
        }

        public ErroValidacao(String message)
            : base(message)
        {
        }

        public ErroValidacao(String message, string local)
            : base(message)
        {
            this.local = local;
        }

        public ErroValidacao(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

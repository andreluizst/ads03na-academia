using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACliente
{
    public static class FiltrarMsgErroWebSrv
    {
        public static string execute(string msgErro)
        {
            string msg = msgErro;
            string[] vetor = msgErro.Split(':');
            int index = vetor[2].IndexOf("\n");
            msg = vetor[2].Substring(0, index);
            return msg;
        }
    }
}

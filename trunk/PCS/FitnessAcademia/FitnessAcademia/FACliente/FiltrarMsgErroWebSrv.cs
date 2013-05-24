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
            int idxInicio = 0;
            int idxFim = 0;
            idxInicio = msg.LastIndexOf("System.Exception:");
            idxFim = msg.IndexOf("\n");
            idxInicio += "System.Exception:".Length;
            msg = msg.Substring(idxInicio, idxFim - idxInicio);
            msg = msg.Replace('>', ' ');
            msg = msg.Replace('-', ':');
            /*string[] vetor = msgErro.Split(':');
            int index = vetor[2].IndexOf("\n");
            msg = vetor[2].Substring(0, index);*/
            return msg;
        }
    }
}

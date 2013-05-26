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
            string txtErroInclusao = "BibliotecaDeClasses.erro.ErroInclusao";
            string txtErroAlteracao = "BibliotecaDeClasses.erro.ErroAlteracao";
            string txtErroExclusao = "BibliotecaDeClasses.erro.ErroExclusao";
            string txtErroPesquisa = "BibliotecaDeClasses.erro.ErroPesquisar";
            int idxInicio = 0;
            int idxFim = 0;
            idxInicio = msg.LastIndexOf("System.Exception:");
            if (idxInicio >= 0)
            {
                idxFim = msg.IndexOf("\n");
                idxInicio += "System.Exception:".Length;
                msg = msg.Substring(idxInicio, idxFim - idxInicio);
                msg = msg.Replace('>', ' ');
                msg = msg.Replace('-', ':');
                return msg;
            }
            idxInicio = msg.LastIndexOf(txtErroInclusao);
            if (idxInicio >= 0)
            {
                idxFim = msg.IndexOf("\n");
                idxInicio += txtErroInclusao.Length + 2;
                msg = msg.Substring(idxInicio, idxFim - idxInicio).Replace('>', ' ').Replace('-', ':');
                return msg;
            }
            idxInicio = msg.LastIndexOf(txtErroAlteracao);
            if (idxInicio >= 0)
            {
                idxFim = msg.IndexOf("\n");
                idxInicio += txtErroAlteracao.Length + 2;
                msg = msg.Substring(idxInicio, idxFim - idxInicio).Replace('>', ' ').Replace('-', ':');
                return msg;
            }
            idxInicio = msg.LastIndexOf(txtErroExclusao);
            if (idxInicio >= 0)
            {
                idxFim = msg.IndexOf("\n");
                idxInicio += txtErroExclusao.Length + 2;
                msg = msg.Substring(idxInicio, idxFim - idxInicio).Replace('>', ' ').Replace('-', ':');
                return msg;
            }
            idxInicio = msg.LastIndexOf(txtErroPesquisa);
            if (idxInicio >= 0)
            {
                idxFim = msg.IndexOf("\n");
                idxInicio += txtErroPesquisa.Length + 2;
                msg = msg.Substring(idxInicio, idxFim - idxInicio).Replace('>', ' ').Replace('-', ':');
                return msg;
            }
            string[] vetor = msgErro.Split(':');
            int index = vetor[2].IndexOf("\n");
            msg = vetor[2].Substring(0, index);
            return msg;
        }
    }
}

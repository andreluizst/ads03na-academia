using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACliente
{
    public interface IActionsGui
    {
        void novo();
        void alterar();
        void excluir();
        void pesquisar();
        void fecharPesquisa();
        bool pesquisarExiste();
        void setOpenMenuShell(ToolStripMenuItem miOpenGui);
        //string getActivationName();
    }
}

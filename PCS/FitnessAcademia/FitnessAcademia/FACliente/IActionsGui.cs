using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACliente
{
    //Interface implementada pelas janelas filhas (MDIChildren) MDI para que possam interagir com a janela mãe MDI
    public interface IActionsGui
    {
        void novo();
        void alterar();
        void excluir();
        void pesquisar();
        void fecharPesquisa();
        bool pesquisarExiste();
        void setOpenMenuShell(ToolStripMenuItem miOpenGui);
        void setActionsMenuShell(ToolStripMenuItem mnNovo, 
            ToolStripMenuItem mnAlterar, ToolStripMenuItem mnExcluir);
        void updateActions();
        //string getActivationName();
    }
}

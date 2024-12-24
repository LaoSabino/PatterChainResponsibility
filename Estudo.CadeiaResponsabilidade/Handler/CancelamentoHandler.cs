using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Handler;

public class CancelamentoHandler : Handler
{
    public override void Handle(Pedido pedido)
    {
        if (pedido.Status == StatusType.Deletado)
        {

        }
        else
        {
            base.Handle(pedido);
        }
    }
}

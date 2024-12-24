using Estudo.CadeiaResponsabilidade.Interface;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Handler;

public class EmissaoHandler(IEmissaoService emissaoService) : Handler
{
    public override void Handle(Pedido pedido)
    {
        if (pedido.Status == StatusType.Emissao)
        {
            var status = emissaoService.Emissao(pedido);
            pedido.Status = StatusType.Cobrado;
        }
        else
        {
            base.Handle(pedido);
        }
    }
}

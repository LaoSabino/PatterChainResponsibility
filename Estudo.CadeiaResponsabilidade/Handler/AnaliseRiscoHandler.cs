using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Handler;

public class AnaliseRiscoHandler : Handler
{
    public override void Handle(Pedido pedido)
    {
        if (pedido.Status == StatusType.Analise)
        {
            //Chama serviço de análise de risco
        }
        else
        {
            base.Handle(pedido);
        }
    }
}

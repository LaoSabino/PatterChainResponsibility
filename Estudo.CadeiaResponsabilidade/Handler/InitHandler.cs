using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Handler;

public class InitHandler : Handler
{
    public override void Handle(Pedido pedido)
    {
        if (pedido.Status == StatusType.Criado)
        {
            pedido.Status = StatusType.Analise;
            pedido.Id = new Random().Next(1, 100);
        }
        else
        {
            base.Handle(pedido);
        }
    }
}

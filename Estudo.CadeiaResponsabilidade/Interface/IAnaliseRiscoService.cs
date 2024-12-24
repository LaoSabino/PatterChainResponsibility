using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Interface;

public interface IAnaliseRiscoService
{
    Task<StatusType> AnalisarRisco(Pedido pedido);
}

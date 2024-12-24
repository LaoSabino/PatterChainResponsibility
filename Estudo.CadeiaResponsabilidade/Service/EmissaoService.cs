using Estudo.CadeiaResponsabilidade.Interface;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Service;

public class EmissaoService : IEmissaoService
{
    public Task<StatusType> Emissao(Pedido pedido)
    {
        return Task.FromResult(StatusType.Cobrado);
    }
}

using Estudo.CadeiaResponsabilidade.Handler;
using Estudo.CadeiaResponsabilidade.Interface;
using Estudo.CadeiaResponsabilidade.Model;
using Estudo.CadeiaResponsabilidade.Service;

namespace Estudo.CadeiaResponsabilidade.Teste;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Test_Status_Emissao()
    {
        IEmissaoService emissaoService = new EmissaoService();
        var pedido = new Pedido { Status = StatusType.Emissao };
        var analiseRiscoHandler = new AnaliseRiscoHandler();
        var initHandler = new InitHandler();
        var cancelamentoHandler = new CancelamentoHandler();
        var emissaoHandler = new EmissaoHandler(emissaoService);

        initHandler.SetNext(analiseRiscoHandler);
        analiseRiscoHandler.SetNext(emissaoHandler);
        emissaoHandler.SetNext(cancelamentoHandler);
        initHandler.Handle(pedido);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Interface;

public interface IEmissaoService
{
    Task<StatusType> Emissao(Pedido pedido);
}

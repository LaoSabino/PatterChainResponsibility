using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Interface;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(Pedido pedido);
}


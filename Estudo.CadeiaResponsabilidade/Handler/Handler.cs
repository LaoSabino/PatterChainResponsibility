using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.CadeiaResponsabilidade.Interface;
using Estudo.CadeiaResponsabilidade.Model;

namespace Estudo.CadeiaResponsabilidade.Handler;

public abstract class Handler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }
        
    public virtual void Handle(Pedido pedido)
    {
        _nextHandler?.Handle(pedido);
    }
}

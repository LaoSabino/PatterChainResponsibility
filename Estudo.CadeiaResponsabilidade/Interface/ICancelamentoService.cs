using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CadeiaResponsabilidade.Interface;

public interface ICancelamentoService
{
    Task<bool> Cancelar(int id);
}

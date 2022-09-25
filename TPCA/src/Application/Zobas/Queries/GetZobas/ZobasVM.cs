using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCA.Application.TodoLists.Queries.GetTodos;

namespace TPCA.Application.Zobas.Queries.GetZobas;
public class ZobasVM
{
    public IList<ZobaDto> Zobas { get; set; } = new List<ZobaDto>();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCA.Application.Common.Mappings;
using TPCA.Domain.Entities;

namespace TPCA.Application.Zobas.Queries.GetZobas;
public class ZobaDto : IMapFrom<Zoba>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Description { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCA.Domain.Entities;
public class Zoba : BaseAuditableEntity
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Description { get; set; }
}

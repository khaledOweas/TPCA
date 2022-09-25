using TPCA.Application.Common.Interfaces;

namespace TPCA.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KStore.Application.Dapper.ViewModels;

namespace KStore.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}

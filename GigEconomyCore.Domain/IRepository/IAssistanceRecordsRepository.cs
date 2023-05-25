using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IAssistanceRecordsRepository
    {
        T_ASSISTANCE_RECORDS GetAssistanceRecordsById(int Id);

        T_ASSISTANCE_RECORDS AddAssistanceRecords(T_ASSISTANCE_RECORDS assistanceRecords);

        T_ASSISTANCE_RECORDS UpdateAssistanceRecords(T_ASSISTANCE_RECORDS assistanceRecords);

        T_ASSISTANCE_RECORDS DeleteAssistanceRecords(T_ASSISTANCE_RECORDS assistanceRecords);
    }
}

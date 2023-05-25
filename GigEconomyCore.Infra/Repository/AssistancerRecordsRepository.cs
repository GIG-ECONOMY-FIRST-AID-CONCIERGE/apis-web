using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Infra.Repository
{
    public class AssistanceRecordsRepository : IAssistanceRecordsRepository
    {
        private readonly DataContext _context;

        public AssistanceRecordsRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_ASSISTANCE_RECORDS AddAssistanceRecords(T_ASSISTANCE_RECORDS assistenceRecords)
        {
            _context.T_Assistance_Records.Add(assistenceRecords);
            _context.SaveChanges();
            return assistenceRecords;
        }

        public T_ASSISTANCE_RECORDS DeleteAssistanceRecords(T_ASSISTANCE_RECORDS assistenceRecords)
        {
            throw new NotImplementedException();
        }

        public T_ASSISTANCE_RECORDS GetAssistanceRecordsById(int Id)
        {
            return _context.T_Assistance_Records.Where(p => p.Id == Id).FirstOrDefault();
        }

        public T_ASSISTANCE_RECORDS UpdateAssistanceRecords(T_ASSISTANCE_RECORDS assistenceRecords)
        {
            throw new NotImplementedException();
        }
    }
}

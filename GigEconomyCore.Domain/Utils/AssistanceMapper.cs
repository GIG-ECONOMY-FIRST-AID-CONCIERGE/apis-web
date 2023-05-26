using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;
using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Utils
{
    public class AssistanceMapper
    {

        public T_ASSISTANCE Covert(Assistance assistance)
        {
            T_ASSISTANCE t_assistance = new T_ASSISTANCE();

            t_assistance.Id = assistance.Id;
            t_assistance.Name = assistance.Name;
            t_assistance.Description = assistance.Description;
            t_assistance.Type = (int)assistance.Type;
            t_assistance.SinisterCircumstances = assistance.SinisterCircumstances;
            t_assistance.Status = (int)assistance.Status;
            t_assistance.PartnerId = assistance.PartnerId;
            
            return t_assistance;
        }

        public Assistance Covert(T_ASSISTANCE t_assistance)
        {
            Assistance assistance = new Assistance();

            assistance.Id = t_assistance.Id;
            assistance.Name = t_assistance.Name;
            assistance.Description = t_assistance.Description;
            assistance.Type = (AssistanceType)t_assistance.Type;
            assistance.SinisterCircumstances = assistance.SinisterCircumstances;
            assistance.Status = (AssistanceStatus)t_assistance.Status;
            assistance.PartnerId = t_assistance.PartnerId;

            return assistance;
        }
    }
}

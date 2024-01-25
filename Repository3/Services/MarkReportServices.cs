using Repository.Service;
using Repository3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository3.Services
{
    public class MarkReportServices : ServiceBase<MarkReport>
    {
        public MarkReportServices(FileCsvContext context) : base(context)
        {
        }
    }
}

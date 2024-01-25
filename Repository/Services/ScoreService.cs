using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class ScoreService : ServiceBase<score>
    {
        protected ScoreService(FileCsvContext context) : base(context)
        {
        }
    }
}

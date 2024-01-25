using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class StudentService : ServiceBase<student>
    {
        private FileCsvContext _csvContext;
        public StudentService(FileCsvContext context) : base(context)
        {
            _csvContext = context;
        }

        public bool AddManyStudent(List<student> studentNames)
        {
            try
            {
                AddMany(studentNames);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}

using DataLayer;
using Modle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class StudentProcessor : IStudentProcessor
    {
        private readonly IStudentRepository repository;
        public StudentProcessor()
        {
            repository = new StudentRepository();
        }
        public void Save(StudentModel model)
        {
            repository.Save(new StudentEntity()
            {
                Name = model.Name,
                RollNo = model.RollNo
            });
        }
    }
}

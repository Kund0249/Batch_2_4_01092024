using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Class_Object
{
    public class Patient
    {
        //Data members
        private int _PatientId;
        private string _Name;
        private string _Gender;
        private string _Mobile;
        private string _Email;
        private string _Address;
        private string _DCode;

        //public void SetId(int id)
        //{
        //    if (id > 0)
        //        _PatientId = id;
        //    else
        //        throw new Exception("Invalid value for the property Id");
        //}

        //public int GetId()
        //{
        //    return _PatientId;
        //}


        //code
        public int PatientId
        {
            set
            {
                if (value > 0)
                    _PatientId = value;
                else
                    throw new Exception("Invalid value for the property PatientId");
            }
            get { return _PatientId; }
        }

        public string Name
        {
            set
            {
                if(!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                   _Name = value;
                else
                    throw new Exception("Invalid value for the property Name");
            }

            get
            {
                return _Name;
            }
        }

        public string Gender
        {
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) && (value.ToUpper() == "M" || value.ToUpper() == "F"))
                    _Gender = value;
                else
                    throw new Exception("Invalid value for the property Gender");
            }
            get
            {
                return _Gender;
            }
        }
    }
}

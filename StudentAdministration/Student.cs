using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministration
{
    public class Student
    {
        private string _name;
        private int _id;

        #region Constructor

        public Student(string name, int id)
        {
            _name = name;
            _id = id;
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Id
        {
            get { return _id; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"The student {Name} got Id {Id}";
        }

        #endregion

    }
}

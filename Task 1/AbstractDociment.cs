using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_1
{
   abstract class AbstractDocument
    {
        public abstract void Open();

        public abstract void Edit();

        public abstract void Save();
    }
}

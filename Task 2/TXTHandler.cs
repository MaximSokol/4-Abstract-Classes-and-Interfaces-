using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_2
{
    class TXTHandler : AbstracHandler
    {
        public override void Open()
        {
            Console.WriteLine("The document was opened in a TXT Format!");
        }
        //-----------------------------------------------------------------------

        public override void Create()
        {
            Console.WriteLine("The document was created in a TXT Format!");
        }
        //-----------------------------------------------------------------------

        public override void Change()
        {
            Console.WriteLine("The document was changed to a TXT Format!");
        }
        //-----------------------------------------------------------------------

        public override void Save()
        {
            Console.WriteLine("The document was saved in a TXT Format!\n");
        }
        //-----------------------------------------------------------------------
    }
}

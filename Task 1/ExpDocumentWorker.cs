using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_1
{
    class ExpDocumentWorker : AbstractDocument
    {
        public override void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        //------------------------------------

        public override void Edit()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        //------------------------------------

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в новом формате\n");
        }
        //------------------------------------}
    }
}

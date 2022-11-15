using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_1
{
    class ProDocumentWorker : AbstractDocument
    {
        public override void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        //---------------------------------

        public override void Edit()
        {
            Console.WriteLine("Документ отредактирован");
        }
        //---------------------------------

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в старом формате, " +
                "сохранение в остальных форматах доступно в версии Эксперт\n");
        }
        //---------------------------------
    }
}

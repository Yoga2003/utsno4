using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utsno4
{
    class Program
    {
        static void Main(string[] args)
        {
            dosen dosenku = new dosen();
            dosenku.attDosen("Kamarudin, M.kom", 12345);
            dosenku.addCourse("Pemrograman");
            dosenku.Tampilan();
            Console.ReadKey();
        }
    }
}

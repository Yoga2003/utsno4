using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utsno4
{
    class dosen
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int Nik { get; set; }
        public string gender { get; set; }
        public string course { get; set; }

        public dosen()
        {
            this.id = 1;
            this.nama = "";
            this.Nik = 12345;
            this.gender = "Laki-laki";
            this.course = "";
        }
        public void attDosen(string name, int nik)
        {
            this.nama = name;
            this.Nik = nik;
        }
        public void addCourse(string course)
        {
            this.course = course;
        }
        public void Tampilan()
        {
            Console.WriteLine("Id     = {0}", id);
            Console.WriteLine("Nama   = {0}", nama);
            Console.WriteLine("NIK    = {0}", Nik);
            Console.WriteLine("Gender = {0}", gender);
            Console.WriteLine("Course = {0}", course);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok8
{
    class mahasiswa_103022300052
    {
        public alamat address { get; set; }
        public matkul[] courses { get; set; }
       
        
            public string firstName { get; set; }
            public string lastName { get; set; }
        
        
        public string gender { get; set; }
        public int age { get; set; }

        public class matkul
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class alamat
        {
            public string city { get; set; }
            public string state { get; set; }
            public string streetAddress { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok8
{
    class datamahasiswa_103022300052
    {
        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022300052.json");

            mahasiswa_103022300052 data = JsonSerializer.Deserialize<mahasiswa_103022300052>(json);
            Console.WriteLine($"Nama {data.firstName} {data.lastName}" +
                $"umur dan gender  {data.gender} {data.age} + " +
                $"alamat {data.address.state} {data.address.city}");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"Mata Kuliah {course.code} {course.name}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok8
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    } 

    public class courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class umur
    {
        public int usia;
    }
    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<courses> courses { get; set; }
        public umur Umur { get; set; }   

    }
    internal class DataMahasiswa103022300116
    {

        public static void ReadJSON()
        {

            string filePath = "jurnal7_1_103022300116.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    DataMahasiswa mhs = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                    if (mhs != null)
                    {

                        Console.WriteLine($"Name: {mhs.firstName} {mhs.lastName}");
                        Console.WriteLine($"Gender: {mhs.gender}");
                        Console.WriteLine($"Age: {mhs.age}");
                        Console.WriteLine($"address: {mhs.address.streetAddress} ");
                        Console.WriteLine($"Daftar mata kuliah yang diambil: ");
                        for (int i = 0; i < mhs.courses.Count; i++)
                        {
                            Console.WriteLine($"MK {i + 1} {mhs.courses[i].code} - {mhs.courses[i].name}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Data Kosong");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error saat membaca atau parsing JSON:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("file JSON tidak ditemukan.");
            }
        }
    }
}

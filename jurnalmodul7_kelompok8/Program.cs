using System;
using System.IO;
using System.Text.Json;
using jurnalmodul7_kelompok8;

class Program
{
    
    static void Main(string[] args)
    {
        
        var mahasiswa = new datamahasiswa_103022300052();
        mahasiswa.ReadJSON();
        Console.ReadKey();
      
    }

}
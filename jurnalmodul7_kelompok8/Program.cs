﻿// See https://aka.ms/new-console-template for more information
using jurnalmodul7_kelompok8;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300004 obj = new DataMahasiswa103022300004();
        obj.ReadJSON();
        TeamMembers103022300004.ReadJSON();
    }
}

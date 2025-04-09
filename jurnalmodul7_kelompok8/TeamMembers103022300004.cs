using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok8
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    public class TeamMembers103022300004
    {
        public List<Member> members { get; set; }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_103022300004.json";
            string json = File.ReadAllText(filePath);

            TeamMembers103022300004 data = JsonSerializer.Deserialize<TeamMembers103022300004>(json);
            Console.WriteLine("List Team Member :");
            foreach (var member in data.members)
            {
                Console.WriteLine($"NIM {member.nim} Nama {member.firstName} {member.lastName} Umur {member.age} Gender {member.gender}");
            }
        }
    }

   
}

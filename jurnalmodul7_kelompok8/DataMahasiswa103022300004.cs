using System;
using System.Net;
using System.Text.Json;

public class DataMahasiswa103022300004
{
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string gender { get; set; }
	public int age { get; set; }
	public Address address { get; set; }
	public List<Course> courses { get; set; }

	public void ReadJSON()
	{
		string filePath = "jurnal7_1_103022300004.json";
		string json = File.ReadAllText(filePath);

		DataMahasiswa103022300004 data = JsonSerializer.Deserialize<DataMahasiswa103022300004>(json);
		Console.WriteLine($"Nama : {data.firstName} {data.lastName}");
		Console.WriteLine($"Gender : {data.gender}");
		Console.WriteLine($"Age : {data.age}");
		Console.WriteLine($"Address : {data.address.streetAddress} {data.address.city} {data.address.state}");
		foreach (var course in data.courses)
		{
			Console.WriteLine($"Course : {course.code} {course.name}");
		}
	}
}
public class Address
{
	public string streetAddress { get; set; }
	public string city { get; set; }
	public string state { get; set; }
}
public class Course
{
	public string code { get; set; }
	public string name { get; set; }
}


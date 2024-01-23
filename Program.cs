// See https://aka.ms/new-console-template for more information
using ConsoleAPp;
using LinqToDB;
using System;
using System.Collections;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


////Mail.SendEMail();

//////List<Emp> emps = new List<Emp>();
//////var r = emps.ToList();

////List<Employee> employees=null;
////employees=new List<Employee>() { new Employee{id=1,Names="Yuvan",job="Mobile App developer" },new Employee{ id=2,Names="Saravanan",job="Asp.net BackEnd Developer"} };

////var result = from obj in employees
////             where obj.Names.Contains('a')
////             select obj.Names;

////foreach (var res in result)
////{

////   // Console.WriteLine(res);

////}


////Employee[] emp= { new Employee() { id = 1, Names = "Thibsa", job = "Ase" }, new Employee() { id = 2, Names = "Rans", job = "dse" } };
////var s=emp.OrderBy(x=>x.Names).ToList();

////Employee[] emps = new Employee[5];
////emps=emp.Where(s=>s.Names.Contains('a')).ToArray();

//////var  bill = emp.Where(s => s.id == 2).FirstOrDefault();
//////Console.WriteLine(bill.Names);
//////; ; ; var result=from e in emps
//////select e.Names+ " "+e.id;
//////foreach ( var r in result) {
//////    Console.WriteLine(r); 
//////}
////IList<String> obj = new List<String>();
////obj.Add("MAni");
////obj.Add("ravi");
////obj.Add("Divya");
////obj.Add("Suresh");
////obj.Add("Pargi");
////var boolresult = obj.OfType<bool>();

////var r = from a in obj.OfType<string>()
////        select a;
////foreach (var a in k) { 
////Console.WriteLine(a.Names);   
////}
////IList<Student> studentList = new List<Student>() {
////        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
////        new Student() { StudentID = 1, StudentName = "John", Age = 18 },
////        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
////        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
////        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
////        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
////    };
////var result = studentList.GroupBy(x => x.StudentID);
////var i=studentList.ElementAt(0);
////Console.WriteLine(i.StudentName);
////foreach(var resultItem in result)
////{
////    //Console.WriteLine($"resultkey--> {resultItem.Key}");
////    foreach (var student in resultItem) { 
////     //Console.WriteLine(student.StudentName+"\n"+student.Age+"\n"+student.StudentID);
////    }
////}

////var res = new { id = 1, key = 2 };


//////Console.WriteLine(r);
////Console.WriteLine(res);
////IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
////Console.WriteLine(strList.Count);
//////Convert.ToInt32(Console.ReadLine());
////Console.WriteLine(strList.Max());
////for (int k = 0; k < strList.Count; k++) {
////    if (strList.ElementAt(k) == "One")
////    {
////        Console.WriteLine(k);
////    }
////}

////var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + "@(* . *)" + s2);
////Console.WriteLine(commaSeperatedString);



////Emp obj= new Emp();

////Console.WriteLine(obj.AddDigits(11));
////Console.WriteLine(obj.ToString());
////string userjson = HttpContext.User.Claims.First(c => c.Type == ClaimTypes.UserData).Value;

////Object user = System.Text.Json.JsonSerializer.Deserialize<Object>(userjson);

//int length = 9;

//string allowed = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//string s= new string(allowed
//    .OrderBy(o => Guid.NewGuid())
//    .Take(length)
//    .ToArray());
//Console.WriteLine(s);

//Random rnd = new Random();
//string password = "";

//for (int i = 0; i < 9; i++)
//{
//    int num = rnd.Next(allowed.Length);
//    password += allowed[num];

//}
//Console.WriteLine(password);
//var provider=MD5.Create();

//var salt = "!#@knx5K01-93-9-94-80-009876511 JJFDUD%^*^(^$(^GFCFTDT";
// var k=MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(salt+password));
////Console.WriteLine(k);


//byte[] bytes = provider.ComputeHash(Encoding.ASCII.GetBytes(salt + password));
//foreach(var i in k) { 
// Console.WriteLine(i);
//}
//string newpassword=BitConverter.ToString(k);
//Console.WriteLine(newpassword);


IList<string> keys = new List<string>();
keys.Add("Kings");
keys.Add("Kin");
keys.Add("ings");
keys.Add("ngs");

var mk = keys.OrderByDescending(keys => keys);
foreach (var key in mk) { 
Console.WriteLine(key);
}
Console.WriteLine(keys.Max());
IList<int> intList = new List<int> () { 10, 20, 30,90,23,3,2,2,2,1,0,123,19 };
var result= intList.OrderByDescending(x => x);
var resultss=result.Skip(2);

foreach (var i in resultss) { 
Console.WriteLine(i);
}


//to find the second  largerst

//IList<string> values = new List<string>();
//values.Add("Newpour");
//keys.Add("Kings");
//var result = keys.Join(keys, s => s, w => w ,(s, w) => s);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//var db = new DataContext("server=server.dsc.com;Database=tmz_nov2023;Userid=mysql;password=Sqldata@123");
//var resultoo = from a in db.GetTable < Member>()
//             where a.member_id==714
//             select a.role_id;
//foreach(var item in resultoo)
//{
//    Console.WriteLine("Role"+ item);
//}















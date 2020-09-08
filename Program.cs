using System;

namespace practica1
{
  class Program
  {
    struct person
    {
      public string firstname;
      public string secondname;
      int age;
    public person(string _firstname,string _secondname,int _age)
      {
        firstname = _firstname;
        secondname = _secondname;
        age = _age;
      }
     public override string ToString()
    {
      return firstname + " "+ secondname +" "+ age;
    }
   }
    static void Main(string[] args) {

    person p = new person("Tony", "Allen", 32);
    GC.Collect();
    Console.WriteLine(p);
  }
 }
}


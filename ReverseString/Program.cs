// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
class HelloWorld {
  static void Main() {
    string str=Console.ReadLine();
        Console.WriteLine($"Hi {str}");
        char[] ch=str.ToCharArray();
        Array.Reverse(ch);
        string strrev=new string(ch);
        Console.WriteLine(strrev);
  }
}

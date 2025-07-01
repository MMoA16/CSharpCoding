// using System;

// public class Test
// {
// 	public static void Main()
// 	{
//         // your code goes here
//         int t;
//         t=int.Parse(Console.ReadLine());
// 		while(t!=0){
// 		    string str1=Console.ReadLine();
// 		    string str2=Console.ReadLine();
// 		    char[] char1=str1.ToCharArray();
// 		    char[] char2=str2.ToCharArray();
// 		    char[] char3=new char[5];
// 		    for(int i=0;i<5;i++){
// 		        if(char1[i]==char2[i]){
// 		            char3[i]='G';
// 		        }
// 		        else{
// 		            char3[i]='B';
// 		        }
// 		    }
//             string str=new string(char3);
// 		    Console.WriteLine(str);
// 		    t--;
// 		}
// 	}
// }

using System;

public class Test
{
	public static void Main()
	{
        // your code goes here
        int t=int.Parse(Console.ReadLine());
        while(t!=0){
            int n=int.Parse(Console.ReadLine());
            string str=Console.ReadLine();
            str.Replace("00","A");
            str.Replace("01","T");
            str.Replace("10","C");
            str.Replace("11","G'");
            Console.WriteLine(str);
            t--;
        }
		
	}
}
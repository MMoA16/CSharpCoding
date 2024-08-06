using System;

string str1=Console.ReadLine();

string str2=Console.ReadLine();
int[] arr= new int[200];
int[] arr1 = new int[200];
int flag=0;
if(str1.Length!=str2.Length){
    Console.WriteLine("False");
}else{
    for(int i=0;i<str1.Length;i++){
        arr[str1[i]]=arr[str1[i]]+1;
    }
    for(int i=0;i<str2.Length;i++){
        arr1[str2[i]]=arr1[str2[i]]+1;
    }
    for(int i=0;i<200;i++){
        if(arr[i]!=arr1[i]){
            flag=1;
        }
    }
    if(flag==0)
        Console.WriteLine("True");
    else
        Console.WriteLine("False");
}
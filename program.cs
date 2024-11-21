using System;
namespace dars_10;
class Program{
    static void Main(string[] args){
        Console.WriteLine("hello world");
        if(true)
            Console.WriteLine("Hello");
        else
            Console.WriteLine("Bye");
        for(int i = 0; i < 10; i++){
            System.Console.WriteLine(i);
        }
        while(true)
        {
            int i = 0;
            System.Console.WriteLine(i);
            i++;
            if(i == 10) break;
        }
    }
}
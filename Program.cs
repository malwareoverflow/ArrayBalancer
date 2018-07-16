using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore
{


    class Program
    {


        static bool Areallequal(int[] array){
for(int i=0;i<array.Length;i++){
    if(array[0]!=array[i]){
return false;

    }

}
 return true;
        }
        static bool islargegreaterthanall(int[] array,int indexoflarge){
for(int i=0;i<array.Length;i++){
    if(array[indexoflarge]<array[i]){
return false;
    }
        }
            return true;
        }
 static void Checkisbalancable(ref int[] array){
int Max = array.Max();

int indexofLarge = array.ToList().IndexOf(Max);
int arraystart=0;
int arrayend=array.Length-1;
Console.WriteLine("Max={0}  Largeindex = {1}",Max,indexofLarge);
while(islargegreaterthanall(array,indexofLarge))
{
if(arraystart!=indexofLarge)
{
     foreach(var x in indexsofsmallest(array))
       {
        Max-=1;
array[indexofLarge]=Max;
array[x]+=1;
       }


}
 if(Areallequal(array)){

       Console.WriteLine("dividable");
       return;
   }
if(arraystart<arrayend){
    arraystart++;
}
else{
    arraystart=0;
}
   
}
Console.WriteLine("Not dividable");

} 
    
                  
        static void Main(string[] args)
        {
             int[] array= { 2,0,32,3,4,0,1};
    
      
            Checkisbalancable(ref array);
            Print(array);

            Console.ReadLine();
        }

        
private static List<int> indexsofsmallest(int[] array){
    List<int> indexes = new List<int>();
    int Min = array.Min();
for(int i=0;i<array.Length;i++){
if(array[i]==Min){

    indexes.Add(i);
}


}
return  indexes;


}
       
        private static void Print(int[] array){

            for(int i=0;i<array.Length;i++)
            {
Console.WriteLine(array[i]);
    
            }

        }
    }
}

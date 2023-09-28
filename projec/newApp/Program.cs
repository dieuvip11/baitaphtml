﻿using newApp.models;

int n;
System.Console.WriteLine("n = ");
n = Convert.ToInt32(Console.ReadLine());
int[ ] intArray = new int[ n ] ;

for (int i = 0; i <intArray.Length; i++)
{
    
    intArray[i] = i/2;

}

for (int i = 0; i< intArray.Length; i++){
    System.Console.WriteLine("Mang["+i+"]= " + intArray[i]);
}
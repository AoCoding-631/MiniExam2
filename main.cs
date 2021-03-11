using System;

class MainClass {
  public static int CylinderVolume(int radius, int height)//Input
  {  
    double volume = 3.14 * radius * height;//Logic 

    return volume;//Output
   
  }

  public static double DetermineHypotenuse(int side1,int side2)
  {

    double hypotenuse = Math.Sqrt((side1 * side1) + (side2*side2));//logic

    return hypotenuse;//output
  }


  public static void Main (string[] args) 
  {   
    int radius,height;
    int side1,side2;
    int CylinderVolume;
    double DetermineHypotenuse;
    double hypotenuse,volume;
    
    Console.WriteLine("Enter radius and height for cylinder");
    radius = Convert.ToInt32(Console.ReadLine());
    height = Convert.ToInt32(Console.ReadLine());  
    volume = CylinderVolume(radius,height);//Call the function Volume with input 

    Console.WriteLine("Enter hypotenuse for triangle");
    side1 = Convert.ToInt32(Console.ReadLine());
    side2 = Convert.ToInt32(Console.ReadLine());  
    hypotenuse = DetermineHypotenuse(side1,side2);//Call the function hypotenuse with input

    double totalVolume = CylinderVolume(volume);
    Console.WriteLine("Total volume of cylinder = " + totalVolume);
    
    double totaSides = DetermineHypotenuse(side1,side2);
    Console.WriteLine("Total hypotenuse of triangle = " + totaSides);
    

  }
}
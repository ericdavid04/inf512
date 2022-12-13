using System;

namespace PROGRAMAS{

public class Airaconditioning{


       //Atributte
       private double SpeedFan = 1.00;
       private double Temp = 17.00;
       private string[] Stat = {"stand-by","Switched-on"};
       private string Brand = "";
      
      //Method
      public string encender(){
      
      return Stat[1];
      }

      public void apagar(){


      }

      public void DownTemp(){


      }
      
      public void UpperTemp(){


      }

      public void DownSpeedFan(){

      }

      public void UpperSpeedFan(){


      }



}

      public class Tester{

          static void Main(string[] args){
 
         //Console.Write("\n ingrese la marca deseada:");
         Airaconditioning Objet = new Airaconditioning();

          Console.ReadKey();

        }

     }

}
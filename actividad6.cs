using System;
using System.Collections.Generic;


namespace actividad6{

public class  G : F{


    private int s=9998833;

    
public G (string x, double y, long z, byte w, int t) : base(x, y, z, w)  {


     s=t;

}

public override void verObjeto(){

	Console.WriteLine("X: " + base.getX());

	Console.WriteLine("Y: "+ base.getY());

	Console.WriteLine("Z: "+ base.getZ());

	Console.WriteLine("W: "+ base.getW());

	Console.WriteLine("S: "+ s);
	
}
}

}

public abstract class F {
 

 private string x = "Ferreiras, Castro";

 private double y = 12.34;
 
private long z = 987364354;
 
protected byte w = 34;
  

 

public F ( string X, double Y, long Z, byte W)  { 
 
this.w = W;
	
this.x = X;

this.y = Y;

this.z = Z;
}

public string getX(){

	return x;
	
}
	
public double getY(){
	
	return y;

}

public long getZ(){

return z;

}


public byte getW(){

return w;
		
}
public abstract void verObjeto();

}
//tester.cs


namespace actividad6{

	

 public class tester{
	
   

 public static void Main(string [] args){
	
 G ver =  new G ("Ferreiras, Castro",12.34,987364354,34,9998833);
		
 ver.verObjeto();		
 
 
}
}

}
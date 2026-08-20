using System;

namespace SnakeGame
{

   public class Punto
  {
    public int X { get; set; }
    public int Y { get; set; }

   public Punto(int x, int y)
 
   {
     X = x;
     Y = y;
    }
   
     public void Dibuja(string simbolo)
    {
     Console.SetCursorPosition(X, Y);
     Console.Write(simbolo);
    }
 
    public void Borrar()
     {
   
      Console.SetCursorPosition(X, Y);
      Console.Write(' ');
    }
  }
}




























}
  
  
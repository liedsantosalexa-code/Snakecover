using System;

namespace SnakeGame
{

   Public class Punto
  {
    public int X { get; set; }
    public int Y { get; set; }

   public Punto(int x, int y)
 
   {
     X = x;
     Y = y;
    }
   
   public void Dibuja(char simbolo)
   {
     Console.SetCursorPosition(X, Y);
     Console.Write(Simbolo);
    }
 
   public void Borrar()
    {
   
      Console.SetCursorPosition(X, Y);
      Console.Write(' ');
    }
  }
}




























}
  
  
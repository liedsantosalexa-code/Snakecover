using System;

namespace SnakeGame
{
 
  public class Tablero

  {
   
    public int Ancho { get; }
    public int Alto { get; }

 
   public Tablero(int ancho, int alto)
  {
  
    Ancho = ancho; 
    Alto = alto;  
   }

   public void DibujaBordes()

 {
    Console.Clear();
    for(int x = 0; x <Ancho; x++)
    {
      new Punto(x,0).Dibuja("█");
      new Punto(x, Alto-1).Dibuja("█");

     }
     
      for(int y = 0; y <Alto; y++)

     {
       new Punto(0, y).Dibuja("█");
       new Punto(Ancho-1, y).Dibuja("█");

      }
    }
  }
}
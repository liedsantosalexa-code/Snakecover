using System;

namespace SnakeGame
{
 
  public class Tablero

  {
   
    public int Ancho { get; }
    public int Largo { get; }

 
   public Tableto(int ancho, int alto)
  {
  
    Ancho = ancho; 
    Alto = alto;  
   }

   public void DibujarBordes()

 {
    Console.Clear();
    for(int x = 0; x <Ancho; x++)
    {
      new Punto(x,0).Dibujar('█');
      new Punto(x, Alto-1).Dibujar('█');

     }
     
      for(int y = 0; y <Alto; y++)

     {
       new Punto(0, y).Dibujar('█');
       new Punto(Ancho-1, y).Dibujar('█');

      }
    }
  }
}





















}
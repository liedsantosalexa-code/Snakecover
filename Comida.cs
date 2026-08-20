using System;

namespace SnakeGame

{
   public class Comida
 { 
  public Punto Posicion { get; private set; }
  private Random random = new Random();

 public void GenerarNueva(int anchoMapa, int altoMapa)
  {
     if (Posicion !=null)

     {
       Posicion.Borrar();
     }

     int x = random.Next(1, anchoMapa -1);
     int y = random.Next(1, altoMapa -1);

    Posicion = new Punto (x, y);
    Posicion.Dibuja("○");
  }

 }

}
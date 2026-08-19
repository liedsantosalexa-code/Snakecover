using System;

namespace SnakeGame

{
   public class Comida
 { 
  public Punto Posicion { get; Private set; }
  private Random random = new Random();

 Public void GenerarNueva(int anchoMapa, int altoMapa)
  {
     int x = random.next(1, anchoMapa -1);
     int y = random.next(1, altoMapa -1);

    Posicion = new Punto (x, y);
    Posicion.Dibujar('🍓');
  }

 }

}
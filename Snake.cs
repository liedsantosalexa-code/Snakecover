using System;
using System.Collections.Generic;

namespace SnakeGame

{
 Public class Snake
 {
   public Queue<Punto>Cuerpo { get; private set; }
   public Punto Cabeza { get; private set; }
 
  
 public string Direccion { get; set; } = "DERECHA";

 public Snake(int xInicial, int yInicial)
  {
    
   Cuerpo = new Queue<Punto>();  
   Cabeza = new Punto(xInicial, yInicial);

   Cuerpo.Enqueue(Cabeza);
   Cabeza.Dibujar('█');
  }

  public void Mover(bool comio)

  {
    int nuevoX = Cabeza.X
    int nuevoY = Cabeza.Y;

   if(Direccion == "DERECHA")nuevoX++
   else if(Direccion == "IZQUIERDA")nuevoX--;
   else if(Direccion == "ARRIBA")nuevoY--;
   else if(Direccion == "ABAJO")nuevoY++;

  Cabeza = new Punto(nuevoX, nuevoY);
  Cabeza.Dibujar('█');
  Cuerpo.Enqueue(Cabeza);

    if (!comio)
   {
   

     Punto colaVieja = Cuerpo.Dequeue();
     colaVieja.Borrar();

   }

 }

  Public boll ChocoConPared(int anchoMapa, int altoMapa)

 {
   return Cabeza.X <= 0 || Cabeza.X >= anchoMapa -1 ||
   Cabeza.Y <= 0 || Cabeza.Y >= altoMapa -1;
 }

 Public bool ChocoConCuerpo()

 {
    int coincidencias = 0;
    foreach (var parte in Cuerpo)
   { 
     if(parte.X == Cabeza.X && parte.Y == Cabeza.Y)
      { 
        
         coincidencias++;
       
      }
   


       }
         return coincidencias > 1; 
 

  }
 }
}









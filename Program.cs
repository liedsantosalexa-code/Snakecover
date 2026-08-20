using System;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            int ancho = 40;
            int alto = 40;
       
          while (true)
         {

            Tablero tablero = new Tablero(ancho, alto);
            tablero.DibujaBordes();

            Snake snake = new Snake(10, 10);

            Comida comida = new Comida();
            comida.GenerarNueva(ancho, alto);

            int puntaje = 0;
            bool jugando = true;

            while (jugando)
            {
                if (Console.KeyAvailable)
                {
                    var tecla = Console.ReadKey(true).Key;

                    if (tecla == ConsoleKey.W && snake.Direccion != "ABAJO")
                        snake.Direccion = "ARRIBA";
                    else if (tecla == ConsoleKey.Z && snake.Direccion != "ARRIBA")
                        snake.Direccion = "ABAJO";
                    else if (tecla == ConsoleKey.A && snake.Direccion != "DERECHA")
                        snake.Direccion = "IZQUIERDA";
                    else if (tecla == ConsoleKey.D && snake.Direccion != "IZQUIERDA")
                        snake.Direccion = "DERECHA";
                }

                bool comio = (snake.Cabeza.X == comida.Posicion.X && 
                              snake.Cabeza.Y == comida.Posicion.Y);

                if (comio)
                {
                    puntaje += 10;
                    comida.GenerarNueva(ancho, alto);
                }

                snake.Mover(comio);

                if (snake.ChocoConPared(ancho, alto) || snake.ChocoConCuerpo())
                {
                    jugando = false;
                }

                Thread.Sleep(150);
            }
            Console.SetCursorPosition(2, alto / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"¡GAME OVER! Puntaje final: {puntaje} | Presiona ENTER para reiniciar");
            Console.ResetColor();
           

          while (Console.ReadKey(true).Key != ConsoleKey.Enter){}
        }
       }
    }
}
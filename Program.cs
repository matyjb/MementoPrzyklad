using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardCaretaker boardCaretaker = new BoardCaretaker();
            string info = "";
            while(true) {
                Console.Clear();
                Console.WriteLine(board);
                Console.WriteLine(info);
                Console.WriteLine("aktualny gracz: " + board.NextPlayer);
                Console.Write("Podaj pozycje ruchu: ");
                string komenda = Console.ReadLine();
                int pozycja;
                info = "";
                try {
                    pozycja = Convert.ToInt32(komenda);
                    BoardMemento memento = board.CreateMemento();
                    if(!board.PlaceAt((pozycja - 1) % 3, (pozycja - 1) / 3)) {
                        info = "Wybierz inne pole";
                    } else {
                        boardCaretaker.AddMemento(memento);
                    }
                } catch(Exception ex){}
                if(komenda == "back" && !boardCaretaker.IsMementosEmpty) {
                    board.RestoreMemento(boardCaretaker.GetLastMemento());
                }
            }
        }
    }
}

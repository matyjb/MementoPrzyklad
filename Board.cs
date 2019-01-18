using System;

namespace Memento {
  class Board {
      private char[,] Fields {get; set;}
      public char NextPlayer {get; private set;}

      public BoardMemento CreateMemento() {
        return new BoardMemento(Fields, NextPlayer);
      }

      public void RestoreMemento(BoardMemento m) {
        Fields = m.Fields;
        NextPlayer = m.NextPlayer;
      }

      public Board() {
        Fields = new char[3,3]{{' ',' ',' '},{' ',' ',' '},{' ',' ',' '}};
        NextPlayer = 'O';
      }

      public bool PlaceAt(int x, int y) {
        if(Fields[y,x] == ' ') {
          Fields[y,x] = NextPlayer;
          NextPlayer = NextPlayer == 'O' ? 'X' : 'O';
          return true;
        } else {
          return false;
        }
      }

      public override string ToString() {
        string result = "";
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                result += " " + this.Fields[i,j] + " ";
                if(j != 2) result += "|";
            }
            if(i != 2) result += Environment.NewLine + "---+---+---" + Environment.NewLine;              
        }
        return result;
      }
  }
}

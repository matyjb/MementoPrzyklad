namespace Memento {
  class BoardMemento {
      public char[,] Fields {get;}
      public char NextPlayer {get;}

      public BoardMemento(char[,] fields, char nextPlayer) {
          Fields = (char[,])fields.Clone();
          NextPlayer = nextPlayer;
      }
  }
}
using System;
using System.Collections.Generic;

namespace Memento {
  class BoardCaretaker {
    private Stack<BoardMemento> mementos = new Stack<BoardMemento>();

    public bool IsMementosEmpty {get => mementos.Count == 0;}

    public void AddMemento(BoardMemento m) {
        mementos.Push(m);
    }

    public BoardMemento GetLastMemento() {
        return mementos.Pop();
    }
  }
}

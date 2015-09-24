using System;

namespace Memento.Structural
{
  // MainApp startup class for Structural 
  // Memento Design Pattern.
  class MainApp
  {
     // Entry point into console application.
    static void Main()
    {
      Originator o = new Originator();
      o.State = "On";

      // Store internal state
      Caretaker c = new Caretaker();
      c.Memento = o.CreateMemento();

      // Continue changing originator
      o.State = "Off";

      // Restore saved state
      o.SetMemento(c.Memento);

      // Wait for user
      Console.ReadKey();
    }
  }

  // The 'Originator' class
  class Originator
  {
    private string _state;

    // Property
    public string State
    {
      get { return _state; }
      set
      {
        _state = value;
        Console.WriteLine("State = " + _state);
      }
    }

    // Creates memento 
    public Memento CreateMemento()
    {
      return (new Memento(_state));
    }

    // Restores original state
    public void SetMemento(Memento memento)
    {
      Console.WriteLine("Restoring state...");
      State = memento.State;
    }
  }

  // The 'Memento' class
  class Memento
  {
    private string _state;

    // Constructor
    public Memento(string state) {
      this._state = state;
    }

    // Gets or sets state
    public string State
    {
      get { return _state; }
    }
  }

  // The 'Caretaker' class
  class Caretaker
  {
    private Memento _memento;

    // Gets or sets memento
    public Memento Memento
    {
      set { _memento = value; }
      get { return _memento; }
    }
  }
}
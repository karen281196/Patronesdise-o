using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create a tree structure 
      CompositeElement root =
        new CompositeElement("Picture");
      root.Add(new PrimitiveElement("Red Line"));
      root.Add(new PrimitiveElement("Blue Circle"));
      root.Add(new PrimitiveElement("Green Box"));
 
      // Create a branch
      CompositeElement comp =
        new CompositeElement("Two Circles");
      comp.Add(new PrimitiveElement("Black Circle"));
      comp.Add(new PrimitiveElement("White Circle"));
      root.Add(comp);
 
      // Add and remove a PrimitiveElement
      PrimitiveElement pe =
        new PrimitiveElement("Yellow Line");
      root.Add(pe);
      root.Remove(pe);
 
      // Recursively display nodes
      root.Display(1);
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Component' Treenode
  /// </summary>
  abstract class DrawingElement
  {
    protected string _name;
 
    // Constructor
    public DrawingElement(string name)
    {
      this._name = name;
    }
 
    public abstract void Add(DrawingElement d);
    public abstract void Remove(DrawingElement d);
    public abstract void Display(int indent);
  }
 
  /// <summary>
  /// The 'Leaf' class
  /// </summary>

        }
    

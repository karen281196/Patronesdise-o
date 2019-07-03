using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class AmericaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Wolf();
    }
  }
 
  /// <summary>
  /// The 'AbstractProductA' abstract class
  /// </summary>
  abstract class Herbivore
  {
  }
 
  /// <summary>
  /// The 'AbstractProductB' abstract class
  /// </summary>
  abstract class Carnivore
  {
    public abstract void Eat(Herbivore h);
  }
 
  /// <summary>
  /// The 'ProductA1' class
  /// </summary>
  class Wildebeest : Herbivore
  {
  }
 
  /// <summary>
  /// The 'ProductB1' class
  /// </summary>
}

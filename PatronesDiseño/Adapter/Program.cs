using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
    static void Main()
    {
      // Non-adapted chemical compound
      Compound unknown = new Compound("Unknown");
      unknown.Display();
 
      // Adapted chemical compounds
      Compound water = new RichCompound("Water");
      water.Display();
 
      Compound benzene = new RichCompound("Benzene");
      benzene.Display();
 
      Compound ethanol = new RichCompound("Ethanol");
      ethanol.Display();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Target' class
  /// </summary>
        }
    

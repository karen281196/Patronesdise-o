using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
    {
      Employee employee = element as Employee;
 
      // Provide 3 extra vacation days
      employee.VacationDays += 3;
      Console.WriteLine("{0} {1}'s new vacation days: {2}",
        employee.GetType().Name, employee.Name,
        employee.VacationDays);
    }
  }
 
  /// <summary>
  /// The 'Element' abstract class
  /// </summary>
  abstract class Element
  {
    public abstract void Accept(IVisitor visitor);
  }
 
  /// <summary>
  /// The 'ConcreteElement' class
  /// </summary>
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CharacterFactory
    {
         private Dictionary<char, Character> _characters =
      new Dictionary<char, Character>();
 
    public Character GetCharacter(char key)
    {
      // Uses "lazy initialization"
      Character character = null;
      if (_characters.ContainsKey(key))
      {
        character = _characters[key];
      }
      else
      {
        switch (key)
        {
          case 'A': character = new CharacterA(); break;
          case 'B': character = new CharacterB(); break;
          //...
          case 'Z': character = new CharacterZ(); break;
        }
        _characters.Add(key, character);
      }
      return character;
    }
  }
 
  /// <summary>
  /// The 'Flyweight' abstract class
  /// </summary>
  abstract class Character
  {
    protected char symbol;
    protected int width;
    protected int height;
    protected int ascent;
    protected int descent;
    protected int pointSize;
 
    public abstract void Display(int pointSize);
  }
 
  /// <summary>
  /// A 'ConcreteFlyweight' class
  /// </summary>
    }


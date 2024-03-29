﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
     /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create IBM stock and attach investors
      IBM ibm = new IBM("IBM", 120.00);
      ibm.Attach(new Investor("Sorros"));
      ibm.Attach(new Investor("Berkshire"));
 
      // Fluctuating prices will notify investors
      ibm.Price = 120.10;
      ibm.Price = 121.00;
      ibm.Price = 120.50;
      ibm.Price = 120.75;
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject' abstract class
  /// </summary>
  abstract class Stock
  {
    private string _symbol;
    private double _price;
    private List<IInvestor> _investors = new List<IInvestor>();
 
    // Constructor
    public Stock(string symbol, double price)
    {
      this._symbol = symbol;
      this._price = price;
    }
 
    public void Attach(IInvestor investor)
    {
      _investors.Add(investor);
    }
 
    public void Detach(IInvestor investor)
    {
      _investors.Remove(investor);
    }
 
    public void Notify()
    {
      foreach (IInvestor investor in _investors)
      {
        investor.Update(this);
      }
 
      Console.WriteLine("");
    }
 
    // Gets or sets the price
    public double Price
    {
      get { return _price; }
      set
      {
        if (_price != value)
        {
          _price = value;
          Notify();
        }
      }
    }
 
    // Gets the symbol
    public string Symbol
    {
      get { return _symbol; }
    }
  }
 
  /// <summary>
  /// The 'ConcreteSubject' class
  /// </summary>
  class IBM : Stock
  {
    // Constructor
    public IBM(string symbol, double price)
      : base(symbol, price)
    {
    }
  }
 
  /// <summary>
  /// The 'Observer' interface
  /// </summary>
  interface IInvestor
  {
    void Update(Stock stock);
  }
 
  /// <summary>
  /// The 'ConcreteObserver' class
  /// </summary>
        }
    
using System.Collections.Generic;
using System;

namespace BabySitter.Models
{
  public class Baby
  {
    private string _babyName;
    // private int _babyAge;
    // private string _babyParent;
    private static List<Baby> _instances = new List<Baby> {};

    //also want to bulid an Object to save babys'perference like ways to comfort/favorite food/drink/toys/book/diaper frenquency/habit to sleep

    public Baby (string babyName)
    {
      _babyName = babyName;
      // _babyAge = babyAge;
      // _babyParent = babyParent;
    }
    public string GetBabyName()
    {
      return _babyName;
    }
    // public int GetBabyAge()
    // {
    //   return _babyAge;
    // }
    // public string GetBabyParent()
    // {
    //   return _babyParent;
    // }

    public void SetBabyName(string newBabyName)
    {
      _babyName = newBabyName;
      // _babyAge = newBabyAge;
      // _babyParent = newBabyParent;
    }
    public static List<Baby> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}

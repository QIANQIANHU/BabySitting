using System.Collections.Generic;
using System;

namespace BabySitter.Models
{
  public class Baby
  {
    private string _babyName;
    private int _babyAge;
    private string _babyParent;
    private int _id;
    private static List<Baby> _instances = new List<Baby> {};

    //also want to bulid an Object to save babys'perference like ways to comfort/favorite food/drink/toys/book/diaper frenquency/habit to sleep

    public Baby (string babyName, int babyAge, string babyParent)
    {
      _babyName = babyName;
      _babyAge = babyAge;
      _babyParent = babyParent;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetBabyName()
    {
      return _babyName;
    }
    public int GetBabyAge()
    {
      return _babyAge;
    }
    public string GetBabyParent()
    {
      return _babyParent;
    }
    public int GetId()
    {
      return _id;
    }

    public void SetBabyName(string newBabyName, int newBabyAge, string newBabyParent)
    {
      _babyName = newBabyName;
      _babyAge = newBabyAge;
      _babyParent = newBabyParent;
    }

    public static List<Baby> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Baby Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

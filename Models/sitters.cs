using System.Collections.Generic;

namespace BabySitter.Models
{
  public class Sitter
  {
    private static List<Sitter> _instances = new List<Sitter> {};
    private string _name;
    private int _id;
    private List<Baby> _babies;

    public Sitter(string sitterName)
    {
      _name = sitterName;
      _instances.Add(this);
      _id = _instances.Count;
      _babies = new List<Baby>{};
    }

    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Sitter> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
     _instances.Clear();
    }
    public static Sitter Find (int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

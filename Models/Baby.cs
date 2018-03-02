namespace BabySitter.Models
{
  public class Baby
  {
    private string _babyName;
    private int _babyAge;
    private string _babyParent;
    //also want to bulid an Object to save babys'perference like ways to comfort/favorite food/drink/toys/book/diaper frenquency/habit to sleep

    public Baby (string babyName, int babyAge, string babyParent)
    {
      _babyName = babyName;
      _babyAge = babyAge;
      _babyParent = babyParent;

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

    public void SetBabyName(string newBabyName, int newBabyAge, string newBabyParent)
    {
      _babyName = newBabyName;
      _babyAge = newBabyAge;
      _babyParent = newBabyParent;
    }
  }
}

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Colgate", 100, 0);
        Console.WriteLine(player1.Life);
    }
}

abstract public class Human {
  private int _life;
  private string _name;

  public Human(string name, int life) {
    _name = name;
    _life = life;
  }
  public int Life {
    get { return _life; }
    set { _life = value; }
  }
}

public class Player : Human {
  private int _score;

  public Player(string name, int life, int score) : base(name, life) {
    _score = score;
  }
  public int Score {
    get { return _score; }
    set { _score = value; }
  }
} 
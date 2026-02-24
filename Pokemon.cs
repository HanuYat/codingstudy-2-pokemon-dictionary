class Pokemon
{
    private string _name;
    private int _attack;
    private int _defence;
    private string _type;
    private readonly int _maxHp;
    private static int _pokemonCount;

    public Pokemon(string name, int maxHp, int attack, int defence, string type)
    {
        _name = name;
        _maxHp = maxHp;
        _attack = attack;
        _defence = defence;
        _type = type;
    }

    public void ShowInfo()
    {
        if (_maxHp < 0)
        {
            Console.WriteLine("0보다 작은 숫자는 불가 합니다.");
        }

        else
        {
            Console.WriteLine($"[{_type}] {_name}: HP({_maxHp}), 공격력({_attack}), 방어력({_defence})");
            _pokemonCount++;
        }
    }

    public static void TotalCount()
    {
        Console.WriteLine($"총 포켓몬 마리 수: {_pokemonCount}");
    }
}
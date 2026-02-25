
// 포켓몬 클래스 생성
class Pokemon
{
    private string _name; // 포켓몬 이름
    private int _attack;  // 포켓몬 공격력
    private int _defence; // 포켓몬 방어력
    private string _type; // 포켓몬 타입
    private readonly int _maxHp; // 포켓몬 최대 체력

    private static int _pokemonCount; // 총 도감에 있는 포켓몬의 마릿수

    // static 생성자로 포켓몬 마릿수를 초기화
    static Pokemon()
    {
        _pokemonCount = 0;
    }

    // 인스턴스 생성자로 나머지 포켓몬 정보들을 초기화
    public Pokemon(string name, int maxHp, int attack, int defence, string type)
    {
        _name = name;
        _maxHp = maxHp;
        _attack = attack;
        _defence = defence;
        _type = type;
    }

    // 포켓몬의 정보 출력 (만약 최대 체력을 음수로 정했을 경우 경고문 출력)
    public void PrintStats()
    {
        if (_maxHp < 0)
        {
            Console.WriteLine("0보다 작은 숫자는 불가 합니다.");
        }

        else
        {
            Console.WriteLine($"[{_type}] {_name, 3}( HP: {_maxHp, 3}, 공격력: {_attack, 3}, 방어력: {_defence, 3} )");
            _pokemonCount++;
        }
    }

    // static 메서드로 총 포켓몬 마릿수를 출력
    public static void TotalCount()
    {
        Console.WriteLine($"총 포켓몬 마리 수: {_pokemonCount}");
    }
}
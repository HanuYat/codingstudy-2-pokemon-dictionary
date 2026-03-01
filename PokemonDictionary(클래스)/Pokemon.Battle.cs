using System.Collections;

partial class Pokemon
{
    private int _currentHealth; //포켓몬의 현재 체력
    private static bool _isBattleEnd = false;  //배틀이 끝났는지에 대한 여부

    public static void Battle(Pokemon pokemon1, Pokemon pokemon2) // 총 포켓몬 배틀의 진행(반복문)
    {
        Console.WriteLine("=== 포켓몬 배틀 시작 ===");
        Console.WriteLine($"    {pokemon1._name} vs {pokemon2._name}");
        Console.WriteLine("------------------------");

        while (_isBattleEnd == false)
        {
            pokemon1.Attack(pokemon1, pokemon2);
            pokemon2.TakeDamage(pokemon1.TotalDamage(pokemon1._attack, pokemon2._defence), pokemon2);
            Console.WriteLine();
            if (_isBattleEnd == false)
            {
                pokemon2.Attack(pokemon2, pokemon1);
                pokemon1.TakeDamage(pokemon2.TotalDamage(pokemon2._attack, pokemon1._defence), pokemon1);
                Console.WriteLine();
            }
        }
    }

    public void Attack(Pokemon pokemon1, Pokemon pokemon2) // 포켓몬이 데미지를 받는 상황
    {
        Console.WriteLine($"{pokemon1._name}공격! → {pokemon2._name}");
        Console.WriteLine($"{pokemon2._name}이(가) {pokemon1._name}에게 {TotalDamage(pokemon1._attack, pokemon2._defence)}데미지를 받았습니다!");
    }

    public void TakeDamage(int damage, Pokemon pokemon)
    {     
        Console.Write($"{pokemon._name} 체력: ");
        pokemon._currentHealth -= damage;

        if (pokemon._currentHealth <= 0) // 포켓몬의 체력이 0이하가 되었을때 배틀 종료
        {
            pokemon._currentHealth = 0;
            _isBattleEnd = true;
            Console.Write(pokemon._currentHealth);
            Console.WriteLine();
            Console.WriteLine($"{pokemon._name}이(가) 쓰러졌습니다!");
            return;
        }

        Console.Write(pokemon._currentHealth);
            Console.WriteLine();
    }

    public int TotalDamage(int attack, int defence)
    {
        return (attack * (100 - defence) / 100) / 2;
    }
}
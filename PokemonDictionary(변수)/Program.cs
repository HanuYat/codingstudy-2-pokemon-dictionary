using System.Xml.Linq;

string poke1_name = "피카츄", poke2_name = "파이리", poke3_name = "꼬부기", poke4_name = "이상해씨", poke5_name = "잠만보";
int poke1_hp = 35, poke2_hp = 39, poke3_hp = 44, poke4_hp = 45, poke5_hp = 160;
int poke1_attack = 55, poke2_attack = 52, poke3_attack = 48, poke4_attack = 49, poke5_attack = 110;
int poke1_defence = 40, poke2_defence = 43, poke3_defence = 65, poke4_defence = 49, poke5_defence = 65;
string poke1_type = "전기", poke2_type = "불", poke3_type = "물", poke4_type = "풀", poke5_type = "노말";
int totalCount = 5;

Console.WriteLine($"[{poke1_type}] {poke1_name,3}( HP: {poke1_hp,3}, 공격력: {poke1_attack,3}, 방어력: {poke1_defence,3} )");
Console.WriteLine($"[{poke2_type}] {poke2_name,3}( HP: {poke2_hp,3}, 공격력: {poke2_attack,3}, 방어력: {poke2_defence,3} )");
Console.WriteLine($"[{poke3_type}] {poke3_name,3}( HP: {poke3_hp,3}, 공격력: {poke3_attack,3}, 방어력: {poke3_defence,3} )");
Console.WriteLine($"[{poke4_type}] {poke4_name,3}( HP: {poke4_hp,3}, 공격력: {poke4_attack,3}, 방어력: {poke4_defence,3} )");
Console.WriteLine($"[{poke5_type}] {poke5_name,3}( HP: {poke5_hp,3}, 공격력: {poke5_attack,3}, 방어력: {poke5_defence,3} )");
Console.WriteLine("---------------------");
Console.WriteLine($"총 포켓몬 마리 수: {totalCount}");
Pokemon pokemon1 = new Pokemon("피카츄", 35, 55, 40, "전기");
Pokemon pokemon2 = new Pokemon("파이리", 39, 52, 43, "불꽃");
Pokemon pokemon3 = new Pokemon("꼬부기", 44, 48, 65, "물");
Pokemon pokemon4 = new Pokemon("이상해씨", 45, 49, 49, "풀");
Pokemon pokemon5 = new Pokemon("잠만보", 160, 110, 65, "노말");

pokemon1.PrintStats();
pokemon2.PrintStats();
pokemon3.PrintStats();
pokemon4.PrintStats();
pokemon5.PrintStats();
Console.WriteLine("---------------------");
Pokemon.TotalCount();
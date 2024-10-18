string enemyName = "";

List<string> names = ["Micke", "Lena", "Joel", "Alexander"];

names.Add("Martin");
names.Remove("Joel");
names.RemoveAt(0);

if (names.Contains("Alexander") == true)
{
  Console.WriteLine("yay, alexander!");
}


int i = Random.Shared.Next(names.Count);
enemyName = names[i];

Console.WriteLine(enemyName);

/*
List<>
[]
Count
Add, Remoeve, RemoveAt
*/


// names[1] = "Nicholas";

// for (int i = 0; i < names.Count; i++)
// {
//   Console.WriteLine(names[i]);
// }


Console.ReadLine();
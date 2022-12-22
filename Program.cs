string[] array = { "Hello", "2", "World", "Dog", "134", "1567", "35", "computer science", "Russia", "Denmark", "Kazan", "Cat" };
string[] newArray = new string[array.Length];
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Изначальный массив: ");
Console.WriteLine("-----------------------------------------------------");
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------");
for(int i=0; i<array.Length; i++) {
    if(array[i].Length <= 3) {
        newArray[i] = array[i];
    }
}
newArray = newArray.Where(x => x != null).ToArray();
Console.WriteLine("Новый массив: ");
Console.WriteLine("-----------------------------------------------------");
Console.Write(string.Join(", ", newArray));
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------");
//Talelr LINQ
//Ejercicios con enteros
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("\n---------------Ejercicios con enteros-----------------\n");
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// ● Filtrar y mostrar solo los números pares de la lista numbers.
Console.WriteLine("1. Los numeros pares de la lista son: ");
var pares = numbers.Where(number => number %2 == 0);

foreach (var number in pares)
{
    Console.WriteLine(number);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.

var impares= numbers.Where(number => number %2 != 0);
var sumaImpar = impares.Sum();
Console.WriteLine($"2. La suma de los números impares es: {sumaImpar}");

// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
Console.WriteLine("3. Los numeros mayores que 5 en orden descendente son: ");
var mayores5 = numbers.Where(number => number >5).OrderByDescending(number => number);
foreach (var number in mayores5)
{
    Console.WriteLine(number);
}

// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
var menores3 = numbers.Count(number => number <= 3);

Console.WriteLine($"4. La cantidad de numeros menores o iguales a 3 son: {menores3}");

// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
Console.WriteLine("5. Los de la lista multiplicados por 2 son: ");
var mult = numbers.Select(number => number * 2);

foreach (var number in mult)
{
    Console.WriteLine(number);
}

//Ejercicios con Strings
Console.WriteLine("\n---------------Ejercicios con strings-----------------\n");

List<string> names = new(){ "Alice", "Bob", "Charlie", "David","Eve" };

// ● Ordenar los nombres en la lista names alfabéticamente.
var orderNames = names.OrderBy(name => name);
Console.WriteLine("1. Los nombres ordenados alfabéticamente son: ");

foreach (var name in orderNames)
{
    Console.WriteLine(name);
}

// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
var nameA = names.Where(name => name.StartsWith('A'));
Console.WriteLine("2. Los nombres que empiezan con la letra 'A' son: ");

foreach (var name in nameA)
{
    Console.WriteLine(name);
}

// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
var longNames = names.Count(name => name.Length > 5);
Console.WriteLine($"3. La cantidad de nombres con más de 5 caracteres son: {longNames}");

// ● Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
var concatNames = string.Join(" ", names);
Console.WriteLine($"4. Los nombres concatenados son: {concatNames}");

// ● Encontrar y mostrar el nombre más largo en la lista names.

var longestName = names.OrderBy(name => name.Length).Last();
Console.WriteLine($"5. El nombre más largo es: {longestName}");

//Ejercicios con String parte 2
Console.WriteLine("\n---------------Ejercicios con strings parte 2-----------------\n");

List<string> words = new(){ "apple", "banana", "cherry", "date", "elderberry" };

// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
var word = words.All(word => word.Length > 3);
Console.WriteLine($"1. Todas las palabras tienen más de 3 caracteres: {word}");

// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
var firstB = words.FirstOrDefault(word => word.StartsWith('b'));
Console.WriteLine($"2. La primera palabra que empieza con la letra 'b' es: {firstB}");

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
var countE = words.Count(word => word.Contains('e'));
Console.WriteLine($"3. La cantidad de palabras que contienen la letra 'e' es: {countE}");

// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
var toUpper = words.Select(word => word.ToUpper());
Console.WriteLine("4. Las palabras en mayúsculas son: ");

foreach (var word1 in toUpper)
{
    Console.WriteLine(word1);
}

// ● Verificar si alguna palabra en la lista words termina con la letra 'y'

var wordY = words.Any(word => word.EndsWith('y'));
Console.WriteLine($"5. Alguna palabra termina con la letra 'y': {wordY}");
//Ejercicios con 2 listas enteras
List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
Console.WriteLine("\n---------------Ejercicios con listas enteras parte 2-----------------\n");

// ● Combinar y ordenar las listas data y moreData de forma ascendente.
var combineData = data.Concat(moreData).OrderBy(number => number);
Console.WriteLine("1. Las listas combinadas y ordenadas ascendentemente son: ");

foreach (var number in combineData)
{
    Console.WriteLine(number);
}

// ● Calcular la suma de todos los números pares en la lista data.
var sumaPares = data.Where(number => number %2 == 0).Sum();
Console.WriteLine($"2. La suma de los números pares en la lista data es: {sumaPares}");

// ● Encontrar el número más grande en la lista data.
var maxNumber = data.Max();
Console.WriteLine($"3. El número más grande en la lista data es: {maxNumber}");

// ● Unir las listas data y moreData, eliminando los elementos duplicados.
var deleteR = data.Union(moreData);
Console.WriteLine("4. Las listas combinadas y sin duplicados son: ");

foreach (var number in deleteR)
{
    Console.WriteLine(number);
}

// ● Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.
var prom = moreData.Where(number => number > moreData.Average());
Console.WriteLine("5. Los números en data que son mayores que el promedio de moreData son: ");

foreach (var number in prom)
{
    Console.WriteLine(number);
}
 

// ● Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).
var numerosPrimos = moreData.Count(n => revisarPrimo(n));
Console.WriteLine($"Numeros primos: {numerosPrimos}");

static bool revisarPrimo(int number)
{
    if (number <= 1 || (number % 2 == 0 && number != 2)) return false;
    for (int i = 3; i < Math.Sqrt(number); i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
}



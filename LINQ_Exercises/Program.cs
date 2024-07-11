
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//● Filtrar y mostrar solo los números pares de la lista numbers.
// var filterParNumbers = numbers.Where(num => num % 2 == 0);

// Console.WriteLine(string.Join("\n",filterParNumbers));

//● Usando LINQ, calcular la suma de todos los números impares en la lista numbers
// var inparSum = numbers.Where(num => num % 2 != 0).Sum();

// Console.WriteLine(string.Join("\n",inparSum));

//● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
// var descMajorThan5 = numbers.Where(num => num > 5).OrderByDescending(num => num);

// Console.WriteLine(string.Join("\n",descMajorThan5));

//● Contar cuántos números son menores o iguales a 3 en la lista numbers.
// var countMinorThan3 = numbers.Where(num => num <= 3).Count();

// Console.WriteLine(string.Join("\n",countMinorThan3));

//● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
// var multiplyX2 = numbers.Select(num => num * num);

// Console.WriteLine(string.Join("\n",multiplyX2));

List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

//● Ordenar los nombres en la lista names alfabéticamente.
// var orderAlfabetic = names.OrderBy(name => name);

// Console.WriteLine(string.Join("\n",orderAlfabetic));

//● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
// var startWithA = names.Where(name => name.StartsWith("A"));

// Console.WriteLine(string.Join("\n",startWithA));

//● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
// var names5Char = names.Where(name => name.Length > 5).Count();

// Console.WriteLine(string.Join("\n",names5Char));

//● Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
// var concatNames = string.Join(" ",names);

// Console.WriteLine($"Los nombres separados por espacios son --> {concatNames}");

//● Encontrar y mostrar el nombre más largo en la lista names.
// var longName = names.OrderByDescending(name => name.Length).First();

// Console.WriteLine($"Nombre más largo: {longName}");

List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

//● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
// var major3Char = words.All(word => word.Length >3);

// Console.WriteLine(string.Join("\n",major3Char));

//● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
// var findFirstWord = words.Where(word => word.StartsWith("b"));

// Console.WriteLine(string.Join("\n",findFirstWord));

//● Contar cuántas palabras en la lista words contienen la letra 'e'.
// var countWordsContain = words.Where(word => word.Contains("e")).Count();

// Console.WriteLine(string.Join("\n",countWordsContain));

//● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
// var wordToUpper = words.Select(word => word.ToUpper());

// Console.WriteLine(string.Join("\n",wordToUpper));

//● Verificar si alguna palabra en la lista words termina con la letra 'y'
// var verifyLastLetter = words.Where(word => word.EndsWith("y")).Count();

// Console.WriteLine($"{verifyLastLetter} Palabras finalizan con la letra 'y'");

List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9, 20 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

//● Combinar y ordenar las listas data y moreData de forma ascendente.
// var orderAsc = data.Concat(moreData).OrderBy(orderAsc => orderAsc);

// Console.WriteLine(string.Join("\n",orderAsc));

//● Calcular la suma de todos los números pares en la lista data.
// var sumParNumbers = data.Where(num => num % 2 == 0).Sum();

// Console.WriteLine($"LA SUMA DE LOS NUMEROS PARES EN LA LISTA DATA ES --> {sumParNumbers}");

//● Encontrar el número más grande en la lista data.
// var longerNumber = data.Max();

// Console.WriteLine($"EL NUMERO MAS GRANDE DE LA LISTA DATA ES --> {longerNumber}");

//● Unir las listas data y moreData, eliminando los elementos duplicados.
// var concatListDistinct = data.Concat(moreData).Distinct();//ToString() para que funcione con el Join del console

// // Console.WriteLine(string.Join(",",concatListDistinct));

// foreach (var i in concatListDistinct)
// {
//     Console.WriteLine(i);

// }

//● Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.
// var majorAvgMoreData = data.Where(num => num > moreData.Average());

// Console.WriteLine(string.Join(",",majorAvgMoreData));

//● Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).
// static bool EsPrimo(int numero)
// {
//     if (numero <= 1)
//         return false;

//     if (numero == 2)
//         return true;

//     if (numero % 2 == 0)
//         return false;

//     for (int i = 3; i * i <= numero; i += 2)
//     {
//         if (numero % i == 0)
//             return false;
//     }

//     return true;
// }

// int conteoPrimos = moreData.Count(EsPrimo);

// Console.WriteLine($"Cantidad de números primos en moreData: {conteoPrimos}");





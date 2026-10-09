// System.Console.WriteLine("Шаг 2");
// int[] scores = [5, 4, 3, 5, 4];
// int scoresLen = scores.Length;

// System.Console.WriteLine($"Первый элемент: {scores[0]}");
// System.Console.WriteLine($"Последний элемент: {scores[scoresLen - 1]}");
// scores[0] = 2;
// System.Console.WriteLine($"Весь массив: {string.Join(", ", scores)}");

// System.Console.WriteLine();
// System.Console.WriteLine("Шаг 3");
// System.Console.WriteLine("Перебор через for");
// // for удобнее foreach, т.к. мы можем получить помимо самого значения ещё и индекс элемента в массиве
// for (int i = 0; i < scoresLen; i++) {
//     System.Console.WriteLine($"Индекс {i}: {scores[i]}");
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Перебор через foreach");
// foreach (int score in scores) {
//     System.Console.WriteLine(score);
// }

System.Console.WriteLine("Шаг 4");
int[] numbers = [10, 20, 30];

for (int i = 0; i < numbers.Length; i++) {
    System.Console.WriteLine(numbers[i]);
}
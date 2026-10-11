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

// System.Console.WriteLine("Шаг 4");
// int[] numbers = [10, 20, 30];

// for (int i = 0; i < numbers.Length; i++) {
//     System.Console.WriteLine(numbers[i]);
// }

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime;

// System.Console.WriteLine("Шаг 5");
// void ChangeFirst(int[] array) {
//     array[0] = 100;
// }

// int[] squares = [1, 4, 9, 16, 25];

// ChangeFirst(squares);
// System.Console.WriteLine($"Массив: {string.Join(", ", squares)}");

// System.Console.WriteLine();
// System.Console.WriteLine("Шаг 6");
// // Массив - это ссылочный тип, поэтому при передачи параметра копируется ссылка на массив, а не его копия. Из-за этого изменение элементов в методе меняет изначальный массив
// void Multiple(int[] array) {
//     for (int i = 0; i < array.Length; i++) {
//         array[i] *= 2;
//     }
// }

// int[] days = [1, 2, 3, 4, 5, 6, 7];
// System.Console.WriteLine($"Массив: {string.Join(", ", days)}");
// Multiple(days);
// System.Console.WriteLine($"Массив, умноженный на 2: {string.Join(", ", days)}");

// System.Console.WriteLine();
// System.Console.WriteLine("Шаг 7");
// void Stats(int[] array, ref int sum, ref double average, ref int max, ref int min) {
//     foreach (int element in array) {
//         sum += element;

//         if (max < element) max = element;
//         if (min > element) min = element;
//     }

//     average = (int)((double)sum / array.Length * 100) / 100.0;
// }

// int[] data = [7, -3, 12, 0, 5, 9, -8];
// int sum1 = 0;
// int max1 = data[0];
// int min1 = data[0];
// double average1 = 0;

// Stats(data, ref sum1, ref average1, ref max1, ref min1);

// System.Console.WriteLine($"Сумма: {sum1}");
// System.Console.WriteLine($"Среднее значение: {average1}");
// System.Console.WriteLine($"Максимальный элемент: {max1}");
// System.Console.WriteLine($"Минимальный элемент: {min1}");

// System.Console.WriteLine();
// int[] negative = [-5, -2, -9];
// int sum2 = 0;
// double average2 = 0;
// // Если max начать с 0, то ни одно значение из массива negative не будет больше, чем он. Программа будет выводит ложную информацию (max = 0)
// int max2 = negative[0];
// int min2 = negative[0];

// Stats(negative, ref sum2, ref average2, ref max2, ref min2);

// System.Console.WriteLine($"Сумма: {sum2}");
// System.Console.WriteLine($"Среднее значение: {average2}");
// System.Console.WriteLine($"Максимальный элемент: {max2}");
// System.Console.WriteLine($"Минимальный элемент: {min2}");

// System.Console.WriteLine();
// System.Console.WriteLine("Шаг 9");

// bool isValidSize;
// int size;
// do {
//     Console.Write("Размер массива: ");
//     isValidSize = int.TryParse(Console.ReadLine(), out size);

//     if (!isValidSize || size < 0) {
//         System.Console.WriteLine("Неверный ввод. Попробуйте снова");
//         System.Console.WriteLine();
//     }
// } while (!isValidSize || size < 0);

// int[] array = new int[size];

// System.Console.WriteLine();
// for (int i = 0; i < size; i++) {
//     bool isValidElement;
//     int element;
//     do {
//         Console.Write($"Элемент {i + 1}: ");
//         isValidElement = int.TryParse(Console.ReadLine(), out element);

//         if (!isValidElement) {
//             System.Console.WriteLine("Неверный ввод. Попробуйте снова");
//             System.Console.WriteLine();
//         }
//     } while (!isValidElement);

//     array[i] = element;
// }

// System.Console.WriteLine();
// System.Console.WriteLine($"Массив: {string.Join(", ", array)}");

// System.Console.WriteLine("Результаты тренировок");
// void isValid(string message, out int num) {
//     bool isValid;
//     do {
//         Console.Write(message);
//         isValid = int.TryParse(Console.ReadLine(), out num);

//         if (!isValid || num < 0) {
//             System.Console.WriteLine("Неверный ввод. Попробуйте снова");
//             System.Console.WriteLine();
//         }
//     } while (!isValid || num < 0);
// }

// void Statistics(in int[] array, int limit, out int max, out int min, out int notBelowLimit, out double average) {
//     int sum = 0;
//     notBelowLimit = 0;
//     max = array[0];
//     min = array[0];

//     foreach (int element in array) {
//         sum += element;

//         if (max < element) max = element;
//         if (min > element) min = element;
//         if (element >= limit) notBelowLimit += 1;
//     }
//     average = Round((double) sum / array.Length);
// }

// double Round(double num) {
//     num *= 100;
//     return (int)num / 100.0;
// }

// System.Console.WriteLine();
// isValid("Сколько результатов? ", out int count);

// int[] results = new int[count];

// for (int i = 0; i < count; i++) {
//     isValid($"Результат {i + 1}: ", out int result);

//     results[i] = result;
// }

// isValid("Порог: ", out int limit);

// System.Console.WriteLine();
// System.Console.WriteLine("Результаты:");
// for (int i = 0; i < count; i++) {
//     System.Console.WriteLine($"{i}: {results[i]}");
// }

// Statistics(in results, limit, out int max, out int min, out int notBelowLimit, out double average);

// System.Console.WriteLine();
// System.Console.WriteLine($"Среднее: {average}");
// System.Console.WriteLine($"Лучший результат: {max}");
// System.Console.WriteLine($"Худший результат: {min}");
// System.Console.WriteLine($"Результатов не ниже {limit}: {notBelowLimit}");

System.Console.WriteLine("Разворот массива");
void Reverse (int[] array) {
    int size = array.Length;
    int num1;
    int num2;
    for (int i = 0; i < (size / 2); i++) {
        num1 = array[i];
        num2 = array[size - (i + 1)];

        array[i] = num2;
        array[size - (i + 1)] = num1;
    }
}

int[] numbers1 = [1, 2, 3, 4, 5];
System.Console.WriteLine($"Массив: {string.Join(", ", numbers1)}");
Reverse(numbers1);
System.Console.WriteLine($"Перевёрнутый массив: {string.Join(", ", numbers1)}");

System.Console.WriteLine();
System.Console.WriteLine("Поиск элемента");
int FindIndex(int[] array, int target) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == target) return i;
    }
    return -1;
}

int[] numbers2 = [2, 8, 4, 3, 2, 4];
System.Console.WriteLine($"Массив: {string.Join(", ", numbers2)}");

var target1 = 3;
var target2 = 4;
var target3 = 5;
System.Console.WriteLine($"Индекс элемента {target1}: {FindIndex(numbers2, target1)}");
System.Console.WriteLine($"Индекс элемента {target2}: {FindIndex(numbers2, target2)}");
System.Console.WriteLine($"Индекс элемента {target3}: {FindIndex(numbers2, target3)}");

System.Console.WriteLine();
System.Console.WriteLine("Второй по величине");
bool TrySecondMax(int[] array, out int max2) {
    int max1 = array[0];
    max2 = array[0];

    foreach (int num in array) {
        if (max1 < num) {
            max2 = max1;
            max1 = num;
        }
    }

    // В случае с массивом с одинаковыми элементами или массивом состоящим из одного элемента метод будет возвращать false, а в max2 будет передаваться значение первого элемента массива
    if (max1 == max2) {
        return false;
    }
    return true;
}

int[] numbers3 = [5, 9, 9, 3];
System.Console.WriteLine($"Массив: {string.Join(", ", numbers3)}");
bool HasSecondMax1 = TrySecondMax(numbers3, out int secondMax1);
if (HasSecondMax1) System.Console.WriteLine($"Второе по величине: {secondMax1}");
else System.Console.WriteLine("Второго по величине значения нет");

int[] numbers4 = [4, 4, 4];
System.Console.WriteLine($"Массив: {string.Join(", ", numbers4)}");
bool HasSecondMax2 = TrySecondMax(numbers4, out int secondMax2);
if (HasSecondMax2) System.Console.WriteLine($"Второе по величине: {secondMax2}");
else System.Console.WriteLine("Второго по величине значения нет");



using System.Collections.Generic;
using System.Collections;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace TRPZ_Laba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            WriteBeginningText();
            int TaskNum = 0;
            TaskNum = SelectFromRange(1, 5);
            switch (TaskNum)
            {
                case 1:
                    Console.WriteLine("Starting task 1");
                    Task1();
                    break;
                case 2:
                    Console.WriteLine("Starting task 2");
                    Task2();
                    break;
                case 3:
                    Console.WriteLine("Starting task 3");
                    Task3();
                    break;
                case 4:
                    Console.WriteLine("Starting task 4");
                    Task4();
                    break;
                case 5:
                    Console.WriteLine("Stopping program execution");
                    return;
            }
        }

        static void WriteBeginningText()
        {
            Console.WriteLine("Select task number:");
            Console.WriteLine("1: Fill square matrix of size [n,n]");
            Console.WriteLine("2: Working with 1 collection");
            Console.WriteLine("3: Working with 4 different collections");
            Console.WriteLine("4: Ввести речення. Визначити слова, що починаються і закінчуються на літери, значення яких вводимо з клавіатури. Надрукувати їх та визначити кількість голосних в кожному.");
            Console.WriteLine("5: Quit application");
        }

        static int SelectFromRange(int MinNum, int MaxNum)
        {

            int TaskNum = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value < MinNum || value > MaxNum)
                    {
                        Console.WriteLine($"Wrong input! Please write numbers from {MinNum} to {MaxNum} inclusive");
                    }
                    else
                    {
                        TaskNum = value;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Wrong input! Please write numbers from {MinNum} to {MaxNum} inclusive");
                }
            } while (true);
            return TaskNum;
        }

        static void WriteMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Task1()
        {
            Console.Write("Write the width of a square matrix: ");
            int width = SelectFromRange(1, int.MaxValue);
            int[,] matrix = new int[width, width];

            while (true)
            {
                Console.WriteLine("Write task number:");
                Console.WriteLine("1: Fill matrix with random values");
                Console.WriteLine("2: Set all matrix fields to '1'");
                Console.WriteLine("3: Create a rombus of '0' in the center of the matrix");
                Console.WriteLine("4: Back to main menu");
                switch (SelectFromRange(1, 4))
                {
                    case 1:
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                int RandInt = new Random().Next(1, 10000);
                                matrix[i, j] = RandInt;
                            }
                        }
                        WriteMatrix(matrix);
                        break;
                    case 2:
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = 1;
                            }
                        }
                        WriteMatrix(matrix);
                        break;
                    case 3:
                        int SmallIndex, BigIndex;
                        if (matrix.GetLength(0) >= 4)
                        {
                            if (matrix.GetLength(0)%2 == 0)
                            {
                                SmallIndex = matrix.GetLength(0)/2-1;
                                BigIndex = matrix.GetLength(0)/2;
                            }
                            else
                            {
                                BigIndex = SmallIndex = matrix.GetLength(0) / 2;
                            }
                            for (int i = 0; i <= matrix.GetLength(0)/2; i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    if(j>= SmallIndex && j <= BigIndex)
                                    {
                                        matrix[i, j] = 0;
                                        matrix[matrix.GetLength(0) - 1 - i, j] = 0;
                                    }
                                }
                                SmallIndex--; BigIndex++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Matrix too small");
                        }
                        WriteMatrix(matrix);
                        break;
                    case 4:
                        Console.Clear();
                        MainMenu();
                        return;
                }
            }
        }

        static void Task2()
        {
            List<Student> studentList = new List<Student>();

            while (true)
            {
                Console.WriteLine("Write task number:");
                Console.WriteLine("1: Clear student list");
                Console.WriteLine("2: Add student to list");
                Console.WriteLine("3: Delete student by index");
                Console.WriteLine("4: Show student list");
                Console.WriteLine("5: Order students alphabetically");
                Console.WriteLine("6: Order students alphabetically reverced");
                Console.WriteLine("7: Back to main menu");
                switch (SelectFromRange(1, 7))
                {
                    case 1:
                        studentList.Clear();
                        break;
                    case 2:
                        Console.Write("Write student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Write student surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Write student group: ");
                        string group = Console.ReadLine();
                        studentList.Add(new Student(name, surname, group));
                        WriteStudentList(studentList);
                        break;
                    case 3:
                        WriteStudentList(studentList);
                        Console.Write("Write the ID of the student: ");
                        int index = SelectFromRange(1, studentList.Count);
                        studentList.RemoveAt(index - 1);
                        WriteStudentList(studentList);
                        break;
                    case 4:
                        WriteStudentList(studentList);
                        break;
                    case 5:
                        studentList = studentList.OrderBy(o => o.Name).ToList();
                        WriteStudentList(studentList);
                        break;
                    case 6:
                        studentList = studentList.OrderByDescending(o => o.Name).ToList();
                        WriteStudentList(studentList);
                        break;
                    case 7:
                        Console.Clear();
                        MainMenu();
                        return;
                }
            }
        }

        static void Task3()
        {
            List<int> arrayList = new List<int>();
            SortedList<int, int> sortedList = new SortedList<int, int>();
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int SelectedCollection = ChooseCollection();
            while (true)
            {
                Console.WriteLine("Select collection:");
                Console.WriteLine("1: Add element");
                Console.WriteLine("2: View all elements");
                Console.WriteLine("3: Choose another collection");
                Console.WriteLine("4: Back to main menu");
                int selectedTask = SelectFromRange(1, 4);
                if (selectedTask == 1)
                {
                    Console.Write("Write integer to add to collection: ");
                    int RandInt = SelectFromRange(0,int.MaxValue);
                    switch (SelectedCollection)
                    {
                        case 1:
                            Console.WriteLine("Added " + RandInt + " to ArrayList");
                            arrayList.Add(RandInt);
                            break;
                        case 2:
                            Console.WriteLine("Added pair ("+ (sortedList.Count + 1) + ";" + RandInt + ") to sortedList");
                            sortedList.Add(sortedList.Count+1, RandInt);
                            break;
                        case 3:
                            Console.WriteLine("Added " + RandInt + " to Stack");
                            stack.Push(RandInt);
                            break;
                        case 4:
                            Console.WriteLine("Added pair (" + (dictionary.Count + 1) + ";" + RandInt + ") to Dictionary");
                            dictionary.Add(dictionary.Count + 1, RandInt);
                            break;
                    }
                }
                if (selectedTask == 2)
                {
                    switch (SelectedCollection)
                    {
                        case 1:
                            Console.Write("Writing all items in ArrayList: ");
                            foreach (var item in arrayList)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write("Writing all items in SortedList: ");
                            foreach (var item in sortedList)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Write("Writing all items in Stack: ");
                            foreach (var item in stack)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.Write("Writing all items in Dictionary: ");
                            foreach (var item in dictionary)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                if (selectedTask == 3)
                {
                    SelectedCollection = ChooseCollection();
                }
                if (selectedTask == 4)
                {
                    Console.Clear();
                    MainMenu();
                    return;
                }
            }
        }

        static void Task4()
        {
            while (true)
            {
            Console.WriteLine("Напишіть номер завдання:");
            Console.WriteLine("1: Ввести речення і визначити слова, що починаються і закінчуються на вказані літери");
            Console.WriteLine("2: Повернутись на головне меню");
            int selectedTask = SelectFromRange(1, 2);
            switch (selectedTask)
            {
                case 1:
                    Console.Write("Введіть речення: ");
                    string sentence = Console.ReadLine();

                    Console.Write("Введіть літеру, з якої мають починатися слова: ");
                    char startLetter = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    Console.Write("Введіть літеру, на яку мають закінчуватися слова: ");
                    char endLetter = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    string vowels = "аеєиіїоуюяaeiou";  // Голосні букви

                    // Розбиваємо речення на слова
                    string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    List<string> matchedWords = new List<string>();

                    foreach (string word in words)
                    {
                        // Видаляємо всі символи, які не є літерами
                        string cleanWord = Regex.Replace(word, @"[^a-zA-Zа-яА-ЯіїєІЇЄ]", "").ToLower();

                        if (cleanWord.Length > 1 && cleanWord.StartsWith(startLetter) && cleanWord.EndsWith(endLetter))
                        {
                            matchedWords.Add(cleanWord);
                        }
                    }

                    if (matchedWords.Count > 0)
                    {
                        Console.WriteLine("Знайдені слова:");
                        foreach (string word in matchedWords)
                        {
                            int vowelCount = word.Count(c => vowels.Contains(c));  // Рахуємо голосні
                            Console.WriteLine($"Слово: {word}, Кількість голосних: {vowelCount}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Не знайдено слів, що починаються та закінчуються на вказані літери.");
                    }
                    break;
                case 2:
                    Console.Clear();
                    MainMenu();
                    return;
            }
        }
    }

    static int ChooseCollection()
        {
            int SelectedCollection = 0;
            Console.WriteLine("Select collection:");
            Console.WriteLine("1: ArrayList");
            Console.WriteLine("2: SortedList");
            Console.WriteLine("3: Stack");
            Console.WriteLine("4: Dictionary");
            Console.WriteLine("5: Back to main menu");
            switch (SelectFromRange(1, 5))
            {
                case 1:
                    SelectedCollection = 1;
                    break;
                case 2:
                    SelectedCollection = 2;
                    break;
                case 3:
                    SelectedCollection = 3;
                    break;
                case 4:
                    SelectedCollection = 4;
                    break;
            }
            return SelectedCollection;
        }
        static void WriteStudentList(List<Student> StudentList)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                Console.WriteLine("Id: " + (i+1) + "; Name: " + StudentList[i].Name + "; Surname: " + StudentList[i].Surname + "; Group: " + StudentList[i].Group);
            }
        }

    }

    public class Student
    {
        public string Name, Surname, Group;
        public Student(string name, string surname, string group)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
        }
    }
}
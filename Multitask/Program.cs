﻿/* Структура программы
Приветствие
Ввод команды
    Ввод числа
    Ввод символа
        Помощь
        Выход
        Изменение входных парметров выбранной минипрограммы
        Ошибка если нет символов
Запуск программы
    Номер программы
Метод Введение данных
Метод Начального запуска программы
*/

// Метод ввода номера программы
void Enterprogram()
{
    Console.WriteLine("Чтобы вызвать помощь в строке введите 'h'");
    Console.WriteLine();
    System.Threading.Thread.Sleep(500);
    bool exit = false;
    while (exit == false)
    {
        Console.Clear();
        string comm = String.Empty;
        string[] command = { "Введите команду" };
        InputData(command, "string");

        bool check = int.TryParse(command[0], out int number);
        if (check == false) comm = command[0].ToUpper();
        switch (check)
        {
            case true:
                Console.Write("Загружаю");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                Console.WriteLine();
                string[] newProgram = { "Запустить заново? Y/N" };
                do
                {
                    System.Threading.Thread.Sleep(500);
                    ChooseProgramm(command[0]);
                    Console.WriteLine();
                    InputData(newProgram, "String");
                } while (ToBoolean(newProgram[0]));
                break;
            case false:
                switch (comm)
                {
                    case "Q":
                        exit = true;
                        break;
                    case "H":
                        Console.WriteLine("Чтобы включить программу введите ее номер и нажмите Enter. Например: Для программы под номером 20, введите '20'");
                        break;
                    default:
                        Console.WriteLine("Ошибка, повторите запрос");
                        break;
                }
                break;
        }
    }
}

// Метод выбора решения программы по введенному значению
void ChooseProgramm(string task)
{
    switch (task)
    {
        case "0":
            Programm000();
            break;
        case "18":
            Programm018();
            break;
        case "19":
            Programm019();
            break;
        case "20":
            Programm020();
            break;
        case "21":
            Programm021();
            break;
        case "22":
            Programm022();
            break;
        case "23":
            Programm023();
            break;
        case "24":
            Programm024();
            break;
        case "25":
            Programm025();
            break;
        case "26":
            Programm026();
            break;
        case "27":
            Programm027028();
            break;
        case "28":
            Programm027028();
            break;
        case "29":
            Programm029();
            break;
        case "30":
            Programm030();
            break;
        case "31":
            Programm031();
            break;
        case "32":
            Programm032();
            break;
        case "33":
            Programm033();
            break;
        case "34":
            Programm034();
            break;
        case "35":
            Programm035();
            break;
        case "36":
            Programm036();
            break;
        case "37":
            Programm037();
            break;
        case "38":
            Programm038();
            break;
        case "39":
            Programm039();
            break;
        case "40":
            Programm040();
            break;
        case "41":
            Programm041();
            break;
        case "42":
            Programm042();
            break;
        case "43":
            Programm043();
            break;
        case "44":
            Programm044();
            break;
        case "45":
            Programm045();
            break;
        case "46":
            Programm046();
            break;
        case "47":
            Programm047();
            break;
        case "48":
            Programm048();
            break;
        case "49":
            Programm049();
            break;
        case "50":
            Programm050();
            break;
        case "51":
            Programm051();
            break;
        case "52":
            Programm052();
            break;
        case "53":
            Programm053();
            break;
        case "54":
            Programm054();
            break;
        case "57":
            Programm057();
            break;
        case "58":
            Programm058();
            break;
        case "64":
            Programm064();
            break;
        case "65":
            Programm065();
            break;
        case "66":
            Programm066();
            break;
        case "67":
            Programm067();
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

void Start(string[] inputSet, ref string[] inputArr)
{
    Console.Clear();
    Console.WriteLine(inputSet[0]);
    System.Threading.Thread.Sleep(2000);
    int lengSet = inputSet.Length;
    int lengNew = inputArr.Length;
    bool inputresult = Double.TryParse(inputArr[0], out double outnumb);
    string set = inputSet[1].ToUpper();
    switch (set)
    {
        case "RANDOM":
            if (!inputresult) InputData(inputArr, inputSet[2]);
            Random(ref inputArr);
            break;
        case "ENTER":
            InputData(inputArr, inputSet[2]);
            break;
        case "IMPORT":
            if (FindSymbol(inputArr[0], ':', out int pos) && pos == 3) InputData(inputArr, inputSet[2]);
            GetImportData(inputArr[0]);
            break;
        case "DEFAULT":
            InputData(inputArr, inputSet[2]);
            CreateArrayRangeInt32(ref inputArr);
            break;
        default:
            Console.WriteLine("Error, check kind of method input: Random, Enter, Default, Import");
            break;
    }
}

void Random(ref string[] inputArr)
{
    bool boolMinVal = Int32.TryParse(inputArr[0], out int outnumber1);
    bool boolMaxVal = Int32.TryParse(inputArr[1], out int outnumber2);
    int countNewArr = Int32.TryParse(inputArr[2], out int outnumber3) ? Convert.ToInt32(outnumber3) : 1;
    Random rand = new Random();
    if (boolMinVal && boolMaxVal)
    {
        int minVal = Convert.ToInt32(inputArr[0]);
        int maxVal = Convert.ToInt32(inputArr[1]);
        Array.Resize(ref inputArr, countNewArr);
        if (maxVal == minVal) maxVal = minVal + 1;
        for (int i = 0; i < countNewArr; i++) inputArr[i] = Convert.ToString(rand.Next(minVal, maxVal));
    }
    else
    {
        int countMinNumbValue = GetIntergerNumericalPosition(inputArr[0]);
        int countMaxNumbValue = GetIntergerNumericalPosition(inputArr[1]);
        int countRange = countMinNumbValue < countMaxNumbValue ? countMaxNumbValue : countMinNumbValue;
        double minValue = Convert.ToDouble(inputArr[0]);
        double maxValue = Convert.ToDouble(inputArr[1]);
        Array.Resize(ref inputArr, countNewArr);
        double range = maxValue - minValue != 0 ? maxValue - minValue : maxValue;
        double numb = 0;
        for (int i = 0; i < countNewArr; i++)
        {
            numb = Math.Round(rand.NextDouble(), countRange);
            numb *= range;
            numb += minValue;
            inputArr[i] = Convert.ToString(Math.Round(numb));
        }
    }
}

int GetIntergerNumericalPosition(string numb)
{
    int position = numb.Length;
    position = FindSymbol(numb, '.', out int posit1) ? position = posit1 - 1 : position;
    position = FindSymbol(numb, '-', out int posit2) ? position = position - 1 : position;
    return position;
}

bool FindSymbol(string inputNumb, char needSymbol, out int position)
{
    bool boolPosition = false;
    position = -1;
    for (int i = 0; i < inputNumb.Length; i++) if (inputNumb[i] == needSymbol) { boolPosition = true; position = i; break; }
    return boolPosition;
}

string[] GetImportData(string place)
{
    string[] input = System.IO.File.ReadAllLines(place);
    return input;
}

// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
void InputData(string[] inputArr, string tool)
{
    string[] toolArr = MakeStringToStringArray(tool, ',');
    int countOrder = int.MaxValue;
    if (toolArr.Length > 1) { countOrder = int.TryParse(toolArr[toolArr.Length - 1], out int inputCount) ? inputCount : countOrder; }
    string toolUpper = toolArr[0].ToUpper();
    string inputdata = String.Empty;
    for (int inputI = 0; inputI < inputArr.Length; inputI++)
    {
        if (!Double.TryParse(inputArr[inputI], out double outnumber))
        {
            bool conduction = false;
            do
            {
                do
                {
                    Console.WriteLine(inputArr[inputI]);
                    inputdata = Console.ReadLine()!;
                }
                while (String.IsNullOrEmpty(inputdata) || !(GetIntergerNumericalPosition(inputdata) <= countOrder));

                switch (toolUpper)
                {
                    case "STRING":
                        conduction = false;
                        break;
                    case "DOUBLE":
                        conduction = !(Double.TryParse(inputdata, out double outnumber1));
                        break;
                    case "INT32":
                        conduction = !(Int32.TryParse(inputdata, out int outnumber2));
                        break;
                    case "INT64":
                        conduction = !(Int64.TryParse(inputdata, out long outnumber3));
                        break;
                    case "INT32RANGE":
                        conduction = !(Int32.TryParse(inputdata, out int outnumber4) && outnumber4 < int.MaxValue / 2 && outnumber4 > int.MinValue / 2);
                        break;
                    case "PLACE":
                        conduction = !(FindSymbol(inputArr[inputI], '.', out int c));
                        inputdata = "@" + $"{inputdata}";
                        break;
                    default:
                        Console.WriteLine("Uncorrect indefy format, please enter correct format of input values");
                        conduction = false;
                        break;
                }
            } while (conduction);
            inputArr[inputI] = inputdata;
        }
    }
}

bool CheckConditionForNumb(string c1, string c2, int Ncompare)
{
    bool CC = false;
    var nc1 = Int32.TryParse(c1, out int result1) ? Convert.ToInt32(c1) : Convert.ToDouble(c1);
    var nc2 = Int32.TryParse(c2, out int result2) ? Convert.ToInt32(c2) : Convert.ToDouble(c2);

    switch (Ncompare)
    {
        case 1:
            CC = nc1 < nc2 ? true : false;
            break;
        case 2:
            CC = nc1 <= nc2 ? true : false;
            break;
        case 3:
            CC = nc1 != nc2 ? true : false;
            break;
        case 4:
            CC = nc1 == nc2 ? true : false;
            break;
        case 5:
            CC = nc1 % nc2 == 0 ? true : false;
            break;
        case 6:
            CC = nc1 > nc2 ? true : false;
            break;
        default:
            Console.WriteLine("Uncorrect indentify CheckCondition Method. Check correct condition.");
            break;
    }
    return CC;
}

bool ToBoolean(string input)
{
    string[] trueStrings = { "1", "y", "yes", "true", "t", "верно", "д", "da", "d", "истина" };
    string[] falseStrings = { "0", "n", "no", "false", "f", "не верно", "н", "net", "ложь" };

    if (trueStrings.Contains(input.ToLower(), StringComparer.OrdinalIgnoreCase))
        return true;
    else if (falseStrings.Contains(input.ToLower(), StringComparer.OrdinalIgnoreCase))
        return false;
    else
    {
        Console.WriteLine("Uncorrect indentify boolean arguments, try again");
        return false;
    }
}

void WriteResult(string conductionResult, string result, int toolwrite)
{
    switch (toolwrite)
    {
        case 0:
            Console.WriteLine($"Result for {conductionResult} = {result}");
            break;
        case 1:
            Console.WriteLine($"Result for {conductionResult} not = {result}");
            break;
    }
}

int[] ToIntArray(string[] remakearray)
{
    int[] newarr = Array.ConvertAll<string, int>(remakearray, int.Parse);
    return newarr;
}

double[] ToDoubleArray(string[] remakearray)
{
    double[] newarr = remakearray.Select<string, double>(s => Double.Parse(s)).ToArray<double>();
    return newarr;
}

int[] ToIntArrayFromString(string inputStr)
{
    int leng = inputStr.Length;
    int[] outputArr;
    if (inputStr[0] == '-')
    {
        outputArr = new int[leng - 1];
        for (int i = 1; i < leng; i++) outputArr[i - 1] = int.Parse(inputStr[i].ToString());
    }
    else
    {
        outputArr = new int[leng];
        for (int i = 0; i < leng; i++) outputArr[i] = int.Parse(inputStr[i].ToString());
    }
    return outputArr;
}

double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
void CreateArrayDoubleRange(double[] doubleArray, string minCount, string maxCount)
{
    int minCAI = Convert.ToInt32(minCount);
    int maxCAI = Convert.ToInt32(maxCount);
    int CountIndex = (maxCAI - minCAI) / (doubleArray.Length - 1);
    doubleArray[0] = minCAI;
    for (int iCAI = 1; iCAI < doubleArray.Length; iCAI++) doubleArray[iCAI] += CountIndex;
}

void CreateArrayRangeInt32(ref string[] inputArr)
{
    int minCAI = Convert.ToInt32(inputArr[0]);
    int maxCAI = Convert.ToInt32(inputArr[1]);
    int RangeIndex = Convert.ToInt32(maxCAI - minCAI);
    Array.Resize(ref inputArr, RangeIndex);
    for (uint iCAI = 0; iCAI < inputArr.Length; iCAI++) inputArr[iCAI] = Convert.ToString(minCAI++);
}

string CreateStringAsArray(double[] doubleArr)
{
    string newString = String.Empty;
    for (int iCAS = 0; iCAS < doubleArr.Length; iCAS++) newString += $"{doubleArr[iCAS]} ";
    return newString;
}

string Reverse(string inputReverse)
{
    string outputReverse = String.Empty;
    for (int ir = inputReverse.Length - 1; ir >= 0; ir--)
    {
        outputReverse += inputReverse[ir];
    }
    return outputReverse;
}

string[] MakeStringToStringArray(string separateArr, char separateChar)
{
    string[] newSA = new string[1];
    string result = string.Empty;
    int countArr = 1;
    for (int iSA = 0, jSA = 0; iSA < separateArr.Length; iSA++)
    {
        if (separateArr[iSA] == separateChar)
        {
            Array.Resize(ref newSA, countArr + 1);
            newSA[jSA++] = result;
            result = string.Empty;
        }
        else result += $"{separateArr[iSA]}";
    }
    newSA[newSA.Length - 1] = result;
    return newSA;
}

string StringResult(string[] printarr)
{
    return string.Join(" ", printarr);
}

void PrintArrayIntoConsole(string[] printarr, int printset)
{
    switch (printset)
    {
        case 0:
            Console.WriteLine(string.Join(" ", printarr));
            break;
        case 1:
            foreach (string print in printarr) Console.WriteLine(print);
            break;
    }
}

void Int2DArray(string[] inputArr, out int[,] newArr)
{
    newArr = new int[Convert.ToInt32(inputArr[0]), Convert.ToInt32(inputArr[1])];
    int min2D = Convert.ToInt32(inputArr[2]);
    int max2D = Convert.ToInt32(inputArr[3]) + 1;
    Random rand = new Random();
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i, j] = rand.Next(min2D, max2D);
        }
    }
}

int[,] FrameworkTo2DArray(string intro)
{
    string[] start = { intro, "Enter", "Int32" };
    string[] currArr = { "5", "5", "0", "10" };
    Start(start, ref currArr);
    Int2DArray(currArr, out int[,] Arr2D);
    Print2DArray(Arr2D);
    return Arr2D;
}

List<double> FrameworkTo2DArray2(string intro, string[] currArr, int toolTask, out int[,] Arr2D)
{
    string[] start = { intro, "Enter", "Int32" };
    List<double> resultArr = new List<double>();
    Start(start, ref currArr);
    Int2DArray(currArr, out Arr2D);
    Print2DArray(Arr2D);
    ForProgramm2DArr(Arr2D, resultArr, toolTask);
    return resultArr;
}

void Print2DArray(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++) Console.Write("{0}   ", newArr[i, j]);
        Console.WriteLine();
    }
}


void Programm000()
{

    // string[] settings5 = { "Приветствие", "IMPORT", "PLACE" };
    // string[] Arr5 = { @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt" };
    // Start(settings, Arr5);
    // Console.WriteLine(Arr5[0][0] + Arr5[0][1] + Arr5[0][2]);
    // Console.ReadKey();

    // int j0 = 0;
    // if (CheckConditionForNumb(arr0[j0], arr0[j0 + 1], 1)) Console.WriteLine($"Число {arr0[0]} меньше числа {arr0[1]}");
    // else { Console.WriteLine($"Число {arr0[0]} больше числа {arr0[1]}"); }
}

void Programm018()
{
    string[] start18 = { "Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y", "Enter", "string" };
    string[] currArr18 = { "Введите первое условие", "Введите второе условие" };
    Start(start18, ref currArr18);

    if (!(ToBoolean(currArr18[0]) || ToBoolean(currArr18[1])) == (!ToBoolean(currArr18[0]) && !ToBoolean(currArr18[1]))) Console.WriteLine($"Выражение (!( x || y)) истинно к (!x && !y)");
    else { Console.WriteLine($"Выражение (!( x || y)) ложно к (!x && !y)"); }
}

void Programm019()
{
    string[] start19 = { "Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0", "Enter", "double" };
    string[] currArr19 = { "Введите координаты x", "Введите координаты y" };
    Start(start19, ref currArr19);
    string[] workarr19 = { "0" };

    bool checkX = CheckConditionForNumb(workarr19[0], currArr19[0], 1);
    bool checkY = CheckConditionForNumb(workarr19[0], currArr19[1], 1);
    Console.WriteLine($"{checkX} {checkY}");
    // case (x == 0 || y == 0):
    if (CheckConditionForNumb(workarr19[0], currArr19[0], 4) || CheckConditionForNumb(workarr19[0], currArr19[1], 4))
    {
        Console.Write("."); System.Threading.Thread.Sleep(500); Console.Write("."); System.Threading.Thread.Sleep(500); Console.Write("."); Console.WriteLine();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Для определение четвертей, x и y не могут быть равны 0, напишите числа заново");
    }
    else if (!(checkX ^ checkY))
    {
        // case (x > 0 && y > 0):
        if (checkX && checkY) Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся в I четверти");
        // case (x < 0 && y < 0):
        else { Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся во III четверти"); }
    }
    else
    {
        // case (x < 0 && y > 0):
        if (!checkX || checkY) Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся в II четверти");
        // case (x < 0 && y < 0)
        else { Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся во IV четверти"); }
    }
}

void Programm020()
{
    string[] start20 = { "Ввести номер четверти, показать диапазоны для возможных координат", "Enter", "int32,1" };
    string[] currArr20 = { "Number of quarter" };
    Start(start20, ref currArr20);

    string[] instruction20 = { "1 quater", "2 quater", "3 quater", "4 quater" };
    string[] result20 = { "x = (0, +infinity), y = (0, +infinity)", "x = (-infinity, 0), y = (0, +infinity)", "x = (-infinity, 0), y = (-infinity, 0)", "x = (0, +infinity), y = (-infinity, 0)" };
    switch (currArr20[0])
    {
        case "1":
            WriteResult(instruction20[0], result20[0], 0);
            break;
        case "2":
            WriteResult(instruction20[1], result20[1], 0);
            break;
        case "3":
            WriteResult(instruction20[2], result20[2], 0);
            break;
        case "4":
            WriteResult(instruction20[3], result20[3], 0);
            break;
        default:
            Console.WriteLine("Uncorrect indentify quater. Check correct number.");
            break;
    }
}
void Programm021()
{
    string[] start21 = { "Проверить пятизначное число на палидром", "Enter", "int32,5" };
    string[] currArr21 = { "Palindrome" };
    Start(start21, ref currArr21);

    string newstring21 = Reverse(currArr21[0]);
    if (CheckConditionForNumb(currArr21[0], newstring21, 4)) WriteResult(currArr21[0], "Palindrome", 0);
    else { WriteResult(currArr21[0], "Palindrome", 1); }
}

void Programm022()
{
    string[] start22 = { "Найти расстояние двух точек в 2D/3D (в 2D Z = 0)", "Enter", "int32" };
    string[] currArr22 = { "X.1", "Y.1", "Z.1", "X.2", "Y.2", "Z.2" };
    Start(start22, ref currArr22);
    string resulttext22 = "Distanse of two dots";

    double[] changearr22 = ToDoubleArray(currArr22);
    int i22 = 0;
    // result = корень из (x1-x2)^2 + (y1-y2)^2
    string result22 = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow((changearr22[i22] - changearr22[i22 + 3]), 2) + Math.Pow((changearr22[i22 + 1] - changearr22[i22 + 4]), 2) + Math.Pow((changearr22[i22 + 2] - changearr22[i22 + 5]), 2)), 2));
    WriteResult(resulttext22, result22, 0);
}

void Programm023()
{
    string[] start23 = { "Показать таблицу квадратов чисел от 1 до N", "default", "int32range" };
    string[] currArr23 = { "1", "Enter N" };
    Start(start23, ref currArr23);
    int max23 = Convert.ToInt32(currArr23[1]);
    double[] newArr23 = new double[max23];
    for (int i23 = 0; i23 < max23; i23++)
    {
        newArr23[i23] = Math.Pow(Convert.ToDouble(currArr23[i23]), 2);
        WriteResult(Convert.ToString(currArr23[i23]), Convert.ToString(newArr23[i23]), 0);
    }
}

void Programm024()
{
    string[] start24 = { "Найти кубы чисел от 1 до N", "default", "int32range" };
    string[] currArr24 = { "1", "Enter N" };
    string end24 = currArr24[1];
    Start(start24, ref currArr24);
    for (int i24 = 0; i24 < currArr24.Length; i24++) currArr24[i24] = Convert.ToString(Math.Pow(Convert.ToDouble(currArr24[i24]), 3));
    WriteResult($"cubes of numbers from 1 to {end24}", StringResult(currArr24), 0);
}

void Programm025()
{
    string[] start25 = { "Найти сумму чисел от 1 до А", "default", "Int32" };
    string[] currArr25 = { "1", "A number" };
    Start(start25, ref currArr25);
    int SN25 = Convert.ToInt32(currArr25[0]);
    int leng25 = Convert.ToInt32(currArr25[1]);
    double summ25 = 0;
    for (int i25 = 0; i25 < leng25; i25++) summ25 += SN25;
    WriteResult($"{leng25}", Convert.ToString(summ25), 0);
}

void Programm026()
{
    string[] start26 = { "Возведите число А в натуральную степень B, используя цикл", "Enter", "Int32" };
    string[] currArr26 = { "A number", "B number" };
    Start(start26, ref currArr26);
    int AN0 = Convert.ToInt32(currArr26[0]);
    int leng26 = Convert.ToInt32(currArr26[1]);
    double result = 1;
    for (int i26 = 0; i26 < leng26; i26++) result *= AN0;
    WriteResult($"{currArr26[0]} in {currArr26[1]}", Convert.ToString(result), 0);
}

void Programm027028()
{
    string[] start27 = { "Определить количество цифр в цифре и посчитать сумму цифр в цифре", "Enter", "Int32" };
    string[] currArr27 = { "Number" };
    Start(start27, ref currArr27);
    int resultCount = GetIntergerNumericalPosition(currArr27[0]);
    int summ = 0;
    int[] numb27 = ToIntArrayFromString(currArr27[0]);
    foreach (int n in numb27) summ += n;
    WriteResult("count numb", $"{resultCount}", 0);
    WriteResult("summ numb", $"{summ}", 0);
}

void Programm029()
{
    string[] start29 = { "Написать программу вычисления чисел от 1 до N", "Enter", "int32range" };
    string[] currArr29 = { "1", "327" };
    Start(start29, ref currArr29);
    WriteResult($"{currArr29.Length}", StringResult(currArr29), 0);
}

void Programm030()
{
    string[] start30 = { "Показать кубы чисел, заканчивающихся на четную цифру", "Random", "Double" };
    string[] currArr30 = { "-5", "5", "10" };
    Start(start30, ref currArr30);
    double[] newArr30 = ToDoubleArray(currArr30);
    Console.WriteLine("Результат для нахождения кубов чисел");
    for (int i = 0; i < newArr30.Length; i++) if (Math.Pow(newArr30[i], 3) % 2 == 0) Console.Write($"{Math.Pow(newArr30[i], 3)} ");
}

void Programm031()
{
    string[] start31 = { "Задать массив из 8 элементов и вывести их на экран", "Enter", "Int32" };
    string[] currArr31 = { "First", "Second", "Third", "Fourth", "Fiveth", "Secondth", "Seventh", "Eighth" };
    Start(start31, ref currArr31);
    WriteResult($"8 elements", StringResult(currArr31), 0);
}

void Programm032()
{
    string[] start32 = { "Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран", "Random", "Int32range" };
    string[] currArr32 = { "0", "1", "8" };
    Start(start32, ref currArr32);
    WriteResult($"8 elements", StringResult(currArr32), 0);
}

void Programm033()
{
    string[] start33 = { "Задать массив из 12 элементов, заполненных числами из [-9 ,9]. Найти сумму положительных/отрицательных элементов массива", "Random", "Int32" };
    string[] currArr33 = { "-9", "9", "12" };
    Start(start33, ref currArr33);

    int summPositiv33 = 0, summNegative33 = 0;
    int numbArr33 = 0;
    foreach (string numb33 in currArr33)
    {
        numbArr33 = Convert.ToInt32(numb33);
        if (numbArr33 > 0) summPositiv33 += numbArr33;
        else summNegative33 += numbArr33;
    }
    WriteResult("Positiv", $"{summPositiv33}", 0);
    WriteResult("Negative", $"{summNegative33}", 0);
}

void Programm034()
{
    string[] start34 = { "Написать программу замену элементов массива на противоположные", "Random", "Int32range" };
    string[] currArr34 = { "-100", "100", "15" };
    Start(start34, ref currArr34);

    Console.WriteLine($"Созданный массив: {StringResult(currArr34)}");
    for (int i = 0, leng = currArr34.Length, temp; i < leng; i++)
    {
        temp = Convert.ToInt32(currArr34[i]);
        currArr34[i] = Convert.ToString(temp * (-1));
    }
    WriteResult("opposite", StringResult(currArr34), 0);
}

void Programm035()
{
    string[] start35 = { "Определить присутствует ли в заданном массиве некоторое число", "Random", "Int32range" };
    string[] currArr35 = { "Введите минимальные значения", "Введите максимальные значения", "Введите количество" };
    string[] findArr35 = { "Find number" };
    Start(start35, ref currArr35);
    InputData(findArr35, "Int32");

    string find35 = findArr35[0];
    string result = "Not found";
    for (int i = 0; i < findArr35.Length; i++) if (findArr35[i] == find35) result = $" Это число присутствует, находится {i + 1} по порядку";
    Console.WriteLine(result);
}

void Programm036()
{
    string[] start36 = { "Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел", "Random", "Int32range,3" };
    string[] currArr36 = { "Введите минимальные значения", "Введите максимальные значения", "Введите количество" };
    Start(start36, ref currArr36);
    int even36 = 0, uneven36 = 0;
    for (int i = 0, leng = currArr36.Length; i < leng; i++)
    {
        if (Convert.ToInt32(currArr36[i]) % 2 == 0) even36++;
        else uneven36++;
    }
    WriteResult("even", $"{even36}", 0);
    WriteResult("uneven", $"{uneven36}", 0);
}

void Programm037()
{
    string[] start37 = { "В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]", "Random", "Int32range" };
    string[] currArr37 = { "Введите минимальные значения", "Введите максимальные значения", "123" };
    int[] settings37 = { 10, 99 };
    Start(start37, ref currArr37);

    int count37 = 0;
    int min = settings37[0], max = settings37[1], temp = 0;
    foreach (string s in currArr37)
    {
        temp = Convert.ToInt32(s);
        if (min <= temp && max >= temp) count37++;
    }
    WriteResult($"count element of [{min};{max}]", $"{count37}", 0);
}
void Programm038()
{

    string[] start38 = { "Найти сумму чисел одномерного массива стоящих на нечетной позиции", "Random", "Int32range" };
    string[] currArr38 = { "-100", "100", "100" };
    Start(start38, ref currArr38);
    int summ38 = 0;
    for (int i = 1; i < currArr38.Length; i += 2) summ38 += Convert.ToInt32(currArr38[i]);
    WriteResult($"summary noeven numbers", StringResult(currArr38), 0);
}
void Programm039()
{
    string[] start39 = { "Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.", "default", "Int32" };
    string[] currArr39 = { "0", "10" };
    Start(start39, ref currArr39);
    int center39 = currArr39.Length / 2;
    string[] newArr39 = new string[center39];
    if (currArr39.Length % 2 == 0)
    {
        for (int i = 0, j = currArr39.Length - 1; i < center39; i++, j--)
        {
            newArr39[i] = Convert.ToString(Convert.ToInt32(currArr39[i]) * Convert.ToInt32(currArr39[j]));
        }
    }
    else
    {
        for (int i = center39, j = center39; j < currArr39.Length; i--, j++)
        {
            newArr39[i] = Convert.ToString(Convert.ToInt32(currArr39[i]) * Convert.ToInt32(currArr39[j]));
            Array.Reverse(newArr39);
        }
    }
    WriteResult($"multiplied pairs", StringResult(newArr39), 0);
}
void Programm040()
{
    string[] start40 = { "В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом", "Random", "Double" };
    string[] currArr40 = { "0.5", "2", "15" };
    Start(start40, ref currArr40);
    double min40 = 0, max40 = 0, a40 = 0;
    foreach (string s in currArr40)
    {
        a40 = Convert.ToDouble(s);
        if (a40 > max40) max40 = a40;
        if (a40 < min40) min40 = a40;
    }
    double result = max40 - min40;
    WriteResult($"difference between max and min", $"{result}", 0);

}
void Programm041()
{
    string[] start41 = { "Выяснить являются ли три числа сторонами треугольника", "Enter", "Int32" };
    string[] currArr41 = { "Enter first side", "Enter second side", "Enter third side" };
    Start(start41, ref currArr41);
    bool result41 = (Math.Pow(Convert.ToDouble(currArr41[0]), 2) + Math.Pow(Convert.ToDouble(currArr41[1]), 2) == Math.Pow(Convert.ToDouble(currArr41[2]), 2));
    WriteResult($"3 elements of triangle", $"{result41}", 0);
}
void Programm042()
{
    string[] start42 = { "Определить сколько чисел больше 0 введено с клавиатуры", "Enter", "Int32" };
    Console.WriteLine(start42[0]);
    // string[] currArr42 = { "Введите количество попыток ввода" };
    // Start(start42, ref currArr42);
    // int leng42 = Convert.ToInt32(currArr42[0]);
    // int count42 = 0;
    // for (int i42 = 0; i42 < leng42; i42++)
    // {
    //     string[] textArr42 = { "Введите число" };
    //     InputData(textArr42, "Int32");
    //     if (Convert.ToInt32(textArr42[0]) > 0) count42++;
    // }
    // WriteResult("numbers > 0 from keyboard", $"{count42}", 0);

    int CountInputNumbers(List<double> inputList)
    {
        return Convert.ToInt32(inputList.Where(e => e > 0).Count());
    }

    bool CheckInputDataOfDouble(string inputData)
    {
        return !String.IsNullOrEmpty(inputData) && double.TryParse(inputData, out double doubleNumb);
    }

    List<double> InputNumbersFromKeyboard(List<double> inputList)
    {
        Console.WriteLine("To End Enter number keep string empty");

        int i = 1;
        string inputString = String.Empty;
        do
        {
            Console.WriteLine($"Enter {i} number");
            inputString = Console.ReadLine()!;
            if (CheckInputDataOfDouble(inputString)) { inputList.Add(Convert.ToDouble(inputString)); i++; }
        }
        while (!String.IsNullOrEmpty(inputString));

        return inputList;
    }

    List<double> listNumbers = new List<double>();
    int findCount = CountInputNumbers(InputNumbersFromKeyboard(listNumbers));
    Console.WriteLine($"Count of Numbers upper 0 from keyboard = {findCount}");
}
void Programm043()
{
    string[] start43 = { "Написать программу преобразования десятичного числа в двоичное", "Enter", "Int32" };
    string[] currArr43 = { "Number" };
    Start(start43, ref currArr43);
    sbyte sB43 = Convert.ToSByte(currArr43[0]);
    WriteResult($"number to byte", $"{sB43}", 0);
}
void Programm044()
{
    string[] start44 = { "Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2", "Enter", "Int32" };
    string[] currArr44 = { "Enter k1", "Enter b1", "Enter k2", "Enter b2" };
    Start(start44, ref currArr44);
    double[] newArr44 = ToDoubleArray(currArr44);
    double resultX = 0, resultY = 0;
    if (newArr44[0] != newArr44[2])
    {
        resultX = (newArr44[3] - newArr44[1]) / (newArr44[0] - newArr44[2]);
        resultY = (newArr44[3] * newArr44[0] - newArr44[1] * newArr44[2]) / (newArr44[0] - newArr44[2]);
    }
    else Console.WriteLine("k1 and k2 must be !=");
    WriteResult($"x", $"{resultX:F2}", 0);
    WriteResult($"y", $"{resultY:F2}", 0);
}
void Programm045()
{
    string[] start32 = { "Показать числа Фиббоначи", "Enter", "Int32,3" };
    string[] currArr32 = { "Укажите предел" };
    Start(start32, ref currArr32);
    double n45 = Convert.ToDouble(currArr32[0]);
    for (int i = 1; i <= n45; i++) Console.WriteLine($"Result for {Fibonacci(i)}");
}
void Programm046()
{
    string[] start46 = { "Написать программу масштабирования фигуры", "Enter", "Int32,4" };
    string[] currArr46 = { "Enter width of image", "Enter height of image", "Enter scale %" };
    Start(start46, ref currArr46);
    double[] newArr46 = ToDoubleArray(currArr46);
    double newS = newArr46[0] * newArr46[1] * newArr46[2] / 100;
    double resultX = Math.Sqrt(newArr46[0] * newArr46[0] * newArr46[2] / 100);
    double resultY = newS / resultX;
    WriteResult($"width of image", $"{resultX:F2}", 0);
    WriteResult($"heigth of image", $"{resultY:F2}", 0);
}
void Programm047()
{
    string[] star47 = { "Написать программу копирования массива", "default", "Int32" };
    string[] currArr47 = { "-45", "12" };
    Start(star47, ref currArr47);
    PrintArrayIntoConsole(currArr47, 0);
    string[] newArr47 = new string[currArr47.Length];
    Array.Copy(currArr47, newArr47, currArr47.Length);
    WriteResult("new array", StringResult(newArr47), 0);
}

void ForProgramm2DArr(int[,] inputArr, List<double> result, int numbOfTask)
{
    int min = inputArr[0, 0];
    int max = inputArr[0, 0];
    int leng = 0;
    double temp = 0;
    switch (numbOfTask)
    {
        case 0 | 1:
            leng = 2;
            break;
        case 2:
            leng = 2;
            break;
        case 3:
            leng = 1;
            break;
        case 5:
            leng = 4;
            break;
    }

    for (int h = 0; h < leng; h++) result.Add(h);

    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        // switch (numbOfTask)
        // {
        //     case 8:
        //     temp = inputArr[i, 0];
        //     break;
        // }

        for (int j = 0; j < inputArr.GetLength(1); j++)
        {
            switch (numbOfTask)
            {
                case 0:
                    result[0] += inputArr[i, j];
                    result[1] *= inputArr[i, j];
                    break;
                case 1:
                    if (inputArr[i, j] % 2 == 0)
                    {
                        result[0] += inputArr[i, j];
                        result[1] *= inputArr[i, j];
                    }
                    break;
                case 2:
                    if (inputArr[i, j] % 3 == 0 && inputArr[i, j] % 5 == 0)
                    {
                        result[0] += inputArr[i, j];
                        result[1] *= inputArr[i, j];
                    }
                    break;
                case 3:
                    if (inputArr[i, j] > -9 && inputArr[i, j] < 0)
                    {
                        result[0]++;
                    }
                    break;
                case 4:
                    if (i % 2 != 0 && j % 2 != 0 && inputArr[i, j] % 2 != 0)
                    {
                        result.Add(i + 1);
                        result.Add(j + 1);
                    }
                    break;
                case 5:
                    if (inputArr[i, j] > max)
                    {
                        max = inputArr[i, j];
                        result[0] = i;
                        result[1] = j;
                    }
                    if (inputArr[i, j] < min)
                    {
                        min = inputArr[i, j];
                        result[2] = i;
                        result[3] = j;
                    }
                    break;
                case 6:
                    temp = Math.Pow(inputArr[i, j], 2);
                    inputArr[i, j] = Convert.ToInt32(Math.Round(temp));
                    break;
                case 7:
                    if (j == 0)
                    {
                        result.Add(inputArr[i, j]);
                    }
                    break;
                case 8:
                    result.Add(inputArr[i, j]);
                    if (j == inputArr.GetLength(1) - 1) result.Add(0);
                    break;
            }
        }
        // switch (numbOfTask)
        // {
        //     case 8:
        //     result.Add(i);
        //     break;
        // }
    }
    switch (numbOfTask)
    {
        case 5:
            inputArr[Convert.ToInt32(result[0]), Convert.ToInt32(result[1])] = min;
            inputArr[Convert.ToInt32(result[2]), Convert.ToInt32(result[3])] = max;
            break;
    }
}

void Programm048()
{
    int[,] Arr2D48 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.");
    List<double> resultArr48 = new List<double>();
    ForProgramm2DArr(Arr2D48, resultArr48, 0);
    WriteResult("summ", $"{resultArr48[0]}", 0);
    WriteResult("multiplication", $"{resultArr48[1]}", 0);
}

void Programm049()
{
    int[,] Arr2D49 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.");
    List<double> resultArr49 = new List<double>();
    ForProgramm2DArr(Arr2D49, resultArr49, 1);
    WriteResult("summ", $"{resultArr49[0]}", 0);
    WriteResult("multiplication", $"{resultArr49[1]}", 0);
}

void Programm050()
{
    int[,] Arr2D50 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.");
    List<double> resultArr50 = new List<double>();
    ForProgramm2DArr(Arr2D50, resultArr50, 2);
    WriteResult("summ", $"{resultArr50[0]}", 0);
    WriteResult("multiplication", $"{resultArr50[1]}", 0);
}

void Programm051()
{
    int[,] Arr2D51 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.");
    List<double> resultArr51 = new List<double>();
    ForProgramm2DArr(Arr2D51, resultArr51, 3);
    WriteResult("count of elements > -9", $"{resultArr51[0]}", 0);
}

void Programm052()
{
    string start52 = "Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах.";
    List<double> resultArr52 = new List<double>();
    ForProgramm2DArr(FrameworkTo2DArray(start52), resultArr52, 4);
    WriteResult("not even numbs on even", "", 0);
    for (int i = 1; i < resultArr52.Count; i += 2) { Console.Write("[{0}, {1}]", resultArr52[i - 1], resultArr52[i]); Console.WriteLine(); }
}

void Programm053()
{
    int[,] Arr2D53 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.");
    List<double> resultArr53 = new List<double>();
    ForProgramm2DArr(Arr2D53, resultArr53, 5);
    WriteResult("change cells", "", 0);
    Print2DArray(Arr2D53);
}

void Programm054()
{
    int[,] Arr2D54 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.");
    List<double> resultArr54 = new List<double>();
    ForProgramm2DArr(Arr2D54, resultArr54, 6);
    WriteResult("^2", "", 0);
    Print2DArray(Arr2D54);
}

void Programm055()
{
    string start55 = "Дан целочисленный двумерный массив, размерности n х m. Найти среднее арифметическое всех элементов массива.";
    string[] currArr55 = { "4", "4", "0", "10" };
    List<double> resultArr55 = FrameworkTo2DArray2(start55, currArr55, 0, out int[,] Arr2D55);
    int result55 = Convert.ToInt32(resultArr55[0]) / (Arr2D55.GetLength(0) * Arr2D55.GetLength(1));
    WriteResult("avg", "", 0);
}

void Programm056()
{
    string start56 = "Дан целочисленный двумерный массив, размерности n х m. Выяснить, какое число встречается в какой строке раньше — положительное или отрицательное.";
    string[] currArr56 = { "4", "4", "0", "10" };
    List<double> resultArr56 = FrameworkTo2DArray2(start56, currArr56, 7, out int[,] Arr2D56);
    for (int i = 0; i < resultArr56.Count; i++)
    {
        if (resultArr56[i] >= 0) WriteResult($"{i} cow", "+", 0);
        else WriteResult($"{i} cow", "-", 0);
    }
}

void Programm057()
{
    int[,] Arr2D57 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Выяснить, в какой строке последовательность является возрастающей или убывающей.");
    List<string> resultArr = new List<string>();
    int countU = 0, countD = 0;
    for (int i = 0; i < Arr2D57.GetLength(0); i++)
    {
        countU = 0; countD = 0;
        for (int j = 0; j < Arr2D57.GetLength(1) - 1; j++)
        {
            if (Arr2D57[i, j] < Arr2D57[i, j + 1]) countU++;
            if (Arr2D57[i, j] > Arr2D57[i, j + 1]) countD++;
        }
        if (countU == Arr2D57.GetLength(1) - 1) resultArr.Add($"cow {i + 1}: " + "have Positive");
        else if (countD == Arr2D57.GetLength(1) - 1) resultArr.Add($"cow {i + 1}: " + "have Negative");
        else resultArr.Add($"cow {i + 1}: " + "have 'Not up or down array'");
    }
    WriteResult("cow position", "", 0);
    foreach (string s in resultArr) Console.WriteLine(s);
}

void Programm058()
{
    int[,] Arr2D58 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Вывести его элементы, индексы которых являются степенями двойки (1, 2, 4, 8, 16, ...).");
    List<int> resultArr = new List<int>();


    for (int i = 1; i < Arr2D58.GetLength(0); i *= 2)
    {
        for (int j = 1; j < Arr2D58.GetLength(1); j *= 2)
        {
            if (i == j) resultArr.Add(Arr2D58[i - 1, j - 1]);
        }
    }
    WriteResult("2^n position", "", 0);
    foreach (int s in resultArr) Console.WriteLine(s);
}
void Programm059()
{
    int[,] Arr2D59 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Найти количество элементов кратных 7.");
    List<int> resultArr = new List<int>();
    resultArr.Add(0);
    for (int i = 0; i < Arr2D59.GetLength(0); i++)
    {
        for (int j = 0; j < Arr2D59.GetLength(1); j++)
        {
            if (Arr2D59[i, j] % 7 == 0) resultArr[0]++;
        }
    }
    WriteResult("%7", $"{resultArr[0]}", 0);
}

void Programm060()
{
    int[,] Arr2D60 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Вывести на экран элементы, которые являются квадратами какого-либо числа.");
    List<int> resultArr = new List<int>();
    for (int i = 0; i < Arr2D60.GetLength(0); i++)
    {
        for (int j = 0; j < Arr2D60.GetLength(1); j++)
        {
            if (Math.Sqrt(Arr2D60[i, j]) == Math.Truncate(Math.Sqrt(Arr2D60[i, j]))) resultArr.Add(Arr2D60[i, j]);
        }
    }
    WriteResult("^2", $"", 0);
    foreach (int s in resultArr) Console.WriteLine(s);
}

void Programm061()
{
    int[,] Arr2D61 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их противоположные значения.");
    int temp = 0;
    for (int i = 0; i < Arr2D61.GetLength(0); i++)
    {
        for (int j = 0; j < Arr2D61.GetLength(1); j++)
        {
            temp = Arr2D61[i, j];
            Arr2D61[i, j] = (-1) * temp;
        }
    }
    WriteResult("opposite array", $"", 0);
    Print2DArray(Arr2D61);
}

void Programm062()
{
    int[,] Arr2D62 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Поменять местами первый и последний элементы.");
    int temp = 0;
    int x = Arr2D62.GetLength(0) - 1, y = Arr2D62.GetLength(1) - 1;
    temp = Arr2D62[x, y];
    Arr2D62[x, y] = Arr2D62[0, 0];
    Arr2D62[0, 0] = temp;
    WriteResult("opposite first and last numb", "", 0);
    Print2DArray(Arr2D62);
}

void Programm063()
{
    int[,] Arr2D63 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Вывести на экран те элементы, у которых остаток от деления на m равен k.");
    List<int> resultArr = new List<int>();
    int k = 3;
    for (int n = 0; n < Arr2D63.GetLength(0); n++)
    {
        for (int m = 0; m < Arr2D63.GetLength(1); m++)
        {
            if (Arr2D63[n, m] % m == k) resultArr.Add(Arr2D63[n, m]);
        }
    }
    WriteResult("opposite first and last numb", "", 0);
    Print2DArray(Arr2D63);
}

void Programm064()
{
    string[] start63 = { "Вводятся результаты контрольной работы 10 учащихся. Определите число не удовлетворительных, удовлетворительных, хороших, отличных оценок. Вывести среднюю оценку, полученную учащимися за контрольную работу.", "Enter", "Int32,1" };
    string[] currArr63 = { "Иванов", "Петров", "Сидоров", "Каменская", "Иванова", "Ученикова", "Школьнов", "Класснов", "Доскова", "Указкина" };
    string[,] resultArr63 = { {"Отлично", "Хорошо", "Удовлетворительно", "Не удовлетворительно", "Средняя оценка за класс" },
                                {"0","0","0","0","0"}};
    int stud5 = 0, stud4 = 0, stud3 = 0, stud2 = 0, temp = 0, summ = 0;
    Start(start63, ref currArr63);
    for (int i = 0; i < currArr63.Length; i++)
    {
        temp = Convert.ToInt32(currArr63[i]);
        if (temp == 5) stud5++;
        if (temp == 4) stud4++;
        if (temp == 3) stud3++;
        if (temp == 2) stud2++;
        summ += temp;
    }
    resultArr63[1, 0] = Convert.ToString(stud5);
    resultArr63[1, 1] = Convert.ToString(stud4);
    resultArr63[1, 2] = Convert.ToString(stud3);
    resultArr63[1, 3] = Convert.ToString(stud2);
    double avg = (double)summ / currArr63.Length;
    resultArr63[1, 4] = $"{avg}";

    WriteResult("students", "", 0);
    for (int i = 0; i < resultArr63.GetLength(1); i++)
    {
        for (int j = 0; j < resultArr63.GetLength(0); j++) Console.Write("{0}   ", resultArr63[j, i]);
        Console.WriteLine();
    }
}

void Programm065()
{
    string[] start63 = { "Ввести оценки N учеников по K предметам. Определить и вывести на экран количество учеников, не получивших ни одной 5", "Enter", "Int32,1" };
    string[,] resultArr63 = { { "", "Алгебра", "Геометрия", "Литература" },
                              { "Каменская", "4", "4", "4"},
                              { "Иванова", "4", "4", "4" },
                              { "Школьнов", "5", "5", "5" },
                              { "Доскова", "5", "5", "5" }
                                                                        };

    int j;
    for (j = 0; j < resultArr63.GetLength(1); j++) Console.Write("{0,10} |", resultArr63[0, j]);
    Console.WriteLine();
    int temp = 0, summ = 0;
    for (int i = 1; i < resultArr63.GetLength(0); i++)
    {
        for (j = 0; j < resultArr63.GetLength(1); j++) Console.Write("{0,10} |", resultArr63[i, j]);
        Console.WriteLine();
    }
    for (int i = 1; i < resultArr63.GetLength(0); i++)
    {
        j = 1;
        for (; j < resultArr63.GetLength(1); j++)
        {
            temp = Convert.ToInt32(resultArr63[i, j]);
            if (temp == 5) break;
        }
        if (j == resultArr63.GetLength(1)) summ++;
    }
    WriteResult("students", $"{summ}", 0);
}

void Programm066()
{
    string[] start63 = { "В группе учится N студентов, студенты получили по четыре отметки за экзамен. Определить количество неуспевающих студентов и средний балл группы", "Enter", "Int32,1" };
    string[,] resultArr63 = { { "", "Алгебра", "Геометрия", "Литература", "География" },
                              { "Каменская", "4", "4", "4", "5"},
                              { "Иванова", "4", "4", "4", "5"},
                              { "Школьнов", "2", "2", "2", "2" },
                              { "Доскова", "5", "5", "5", "5" }
                                                                };

    int summ = 0;
    double avg = 0, avgnumb = 2.6, oneAvg = 0, numb;
    for (int i = 1; i < resultArr63.GetLength(0); i++)
    {
        numb = 0;
        oneAvg = 0;
        for (int j = 1; j < resultArr63.GetLength(1); j++)
        {
            numb += Convert.ToInt32(resultArr63[i, j]);
        }
        oneAvg = numb / (resultArr63.GetLength(1) - 1);
        if (oneAvg < avgnumb) summ++;
        avg += oneAvg;
    }
    double avgAll = avg / (resultArr63.GetLength(0) - 1);
    WriteResult("students with 2", $"{summ}", 0);
    WriteResult("avg all studens", $"{avgAll}", 0);
}

void Programm067()
{
    int[,] Arr2D67 = FrameworkTo2DArray("В матрице чисел найти сумму элементов главной диагонали");
    List<int> resultArr = new List<int>();
    int summ = 0;
    for (int n = 0; n < Arr2D67.GetLength(0) || n < Arr2D67.GetLength(1); n++)
    {
        summ += Arr2D67[n, n];
    }
    WriteResult("summary of diagonal", "", 0);
    Print2DArray(Arr2D67);
}

void Programm068()
{
    void SortArray(int[] sortArr)
    {
        int temp;
        for (int n = 0; n < sortArr.Length; n++)
        {
            for (int m = 0; m < sortArr.Length - 1; m++)
            {
                if (sortArr[m] < sortArr[m + 1])
                {
                    temp = sortArr[m + 1];
                    sortArr[m + 1] = sortArr[m];
                    sortArr[m] = temp;
                }
            }
        }
    }


    int[] CreateFromSquare2DTo1DArray(int[,] Arr2D)
    {
        int[] newArr = new int[Arr2D.GetLength(0) * Arr2D.GetLength(1)];
        int ratio = Arr2D.GetLength(0);
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = Arr2D[i / ratio, i % ratio];
        }
        return newArr;
    }

    void FillFrom1DToSquare2DArray(int[] Arr, int[,] Arr2D)
    {
        for (int n = 0, i = 0; n < Arr2D.GetLength(0); n++)
        {
            for (int m = 0; m < Arr2D.GetLength(1); m++, i++)
            {
                Arr2D[n, m] = Arr[i];
            }
        }
    }

    int[,] Arr2D68 = FrameworkTo2DArray("Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");
    Print2DArray(Arr2D68);
    int[] newArr = CreateFromSquare2DTo1DArray(Arr2D68);
    SortArray(newArr);
    FillFrom1DToSquare2DArray(newArr, Arr2D68);
    Console.WriteLine();
    Print2DArray(Arr2D68);
}

void Programm069()
{
    int[,] Refill2DArray(int[,] Arr2D)
    {
        if (Arr2D.GetLength(0) == Arr2D.GetLength(1))
        {
            int[,] newArr = new int[Arr2D.GetLength(0), Arr2D.GetLength(1)];
            for (int n = 0; n < Arr2D.GetLength(0); n++)
            {
                for (int m = 0; m < Arr2D.GetLength(1); m++)
                {
                    newArr[m, n] = Arr2D[n, m];
                }
            }
            return newArr;
        }
        else
        {
            int[,] newArr = new int[Arr2D.GetLength(1), Arr2D.GetLength(0)];
            for (int n = 0; n < Arr2D.GetLength(1); n++)
            {
                for (int m = Arr2D.GetLength(0) - 1; m >= 0; m--)
                {
                    newArr[n, Arr2D.GetLength(0) - 1 - m] = Arr2D[m, n];
                }
            }
            return newArr;
        }
    }

    int[,] Arr2D68 = FrameworkTo2DArray("");
    Print2DArray(Arr2D68);
    int[,] newArr2D = Refill2DArray(Arr2D68);
    Console.WriteLine();
    Print2DArray(newArr2D);
}

void Programm070()
{
    int[,] MultiplicationMatrix(int[,] f, int[,] s)
    {
        if (f.GetLength(1) == s.GetLength(0))
        {
            int sum;
            int[,] c = new int[f.GetLength(0), s.GetLength(1)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int n = 0; n < c.GetLength(1); n++)
                {
                    sum = 0;
                    for (int m = 0; m < f.GetLength(1); m++)
                    {
                        sum += f[i, m] * s[m, n];
                    }
                    c[n, i] = sum;
                }
            }
            return c;
        }
        else { System.Console.WriteLine("Couldn't take multiplication from matrix"); return f; }
    }
    int[,] a = {{4,1,3},
            {1,2,3}};
    int[,] b = {{4,1},
            {1,2},
            {3,4}};
    int[,] c = MultiplicationMatrix(a, b);
    Print2DArray(c);
}

bool Fibonachhi(int input, int method)
{
    bool b = false;
    switch (method)
    {
        case 1:
            int n, f, k;
            for (n = 0, f = 1, k = 0; !(n >= input || k >= input || f >= input);)
            {
                n = f + k;
                k = n + f;
                f = k + n;
            }
            b = n == input || k == input || f == input;
            break;
        case 2:
            b = (Math.Sqrt(5 * Math.Pow(input, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(input, 2) + 4) % 1 == 0);
            break;
    }
    return b;
}


void Programm067()
{
    int[,] Arr2D63 = FrameworkTo2DArray("Дан целочисленный двумерный массив, размерности n х m. Вычислить сумму чисел, порядковые номера которых являются числами фибоначчи.");
    List<int> resultArr = new List<int>();
    int summ = 0;
    for (int n = 0; n < Arr2D63.GetLength(0); n++)
    {
        for (int m = 0; m < Arr2D63.GetLength(1); m++)
        {
            if (Fibonachhi(n + 1, 1) && Fibonachhi(m + 1, 1)) summ += Arr2D63[n, m];
        }
    }
    WriteResult("summ index of Fibonacci", $"{summ}", 0);
}

void Recursion()
{
    int M = 0, N = 5;
    void Program001003()
    {
        int ShowNumberN(int m, int n)
        {
            if (m == n) return n;
            else
            {
                Console.Write($"{m} ");
                return ShowNumberN(m + 1, n);
            }
        }
        Console.Write(ShowNumberN(M, N));
    }
    void Program004()
    {
        int SummaryElements(int m, int n)
        {
            if (m == n) return n;
            else return SummaryElements(m + 1, n) + m;
        }
        Console.Write(SummaryElements(M, N));
    }

    void Program005()
    {
        int SummaryUnitsOfNumber(int unit)
        {
            if (unit / 10 == 0) return unit;
            else return SummaryUnitsOfNumber(unit % 10) + SummaryUnitsOfNumber(unit / 10);
        }
        Console.Write(SummaryUnitsOfNumber(352));
    }

    void Programm0051()
    {
        double SummaryUnitsOfNumber(string unit, int count = 0)
        {
            if (count != unit.Length) return Char.GetNumericValue(unit[count]) + SummaryUnitsOfNumber(unit, count + 1);
            else return 0;
        }
        Console.Write(SummaryUnitsOfNumber("1234567891234567891234567890"));
    }


    void Program006()
    {
        int Hyper(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return Hyper(m - 1, 1);
            else return Hyper(m - 1, Hyper(m, n - 1));
        }
        Console.Write(Hyper(3, 5));
    }

    void Program007()
    {
        int Pow(int m, int n)
        {
            if (n == 0) return 1;
            else return Pow(m, n - 1) * m;
        }
        Console.Write(Pow(M, N));
    }

    void Program008()
    {
        double Fibonacci(double n)
        {
            if (n == 1 || n == 2) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        void CustomFibonacci(int m, int n)
        {
            if (m == n) Console.Write($"{Fibonacci(m)} ");
            else
            {
                Console.Write($"{Fibonacci(m)} ");
                CustomFibonacci(m + 1, n);
            }
        }
        CustomFibonacci(M, N);
    }

    void Programm009()
    {

        string findSymbol = "abcd";
        int countWords = 5;
        int c = 0;
        void FindCountWordsFromChar(string symbols, char[] resultString, ref int c, int length = 0)
        {
            if (length == resultString.Length) { c++; return; }
            else
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    resultString[length] = symbols[i];
                    FindCountWordsFromChar(symbols, resultString, ref c, length + 1);
                }
            }
        }
        FindCountWordsFromChar(findSymbol, new char[countWords], ref c);
        System.Console.WriteLine(c);
    }

    void Programm010()
    {
        double Factorial(double a)
        {
            if (a == 0) return 1;
            else return a * Factorial(a - 1);
        }
        System.Console.WriteLine(Factorial(10));
    }
}


// Main
// Console.WriteLine("Введите свое имя");
// var name = Console.ReadLine()!;
// Console.Clear();
// int sleep1 = 1000;
// System.Threading.Thread.Sleep(1000);
// Console.WriteLine($"Приветствую тебя, {name}");
// System.Threading.Thread.Sleep(2000);
Enterprogram();



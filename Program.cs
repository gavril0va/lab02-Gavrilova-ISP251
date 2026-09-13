Console.WriteLine( "Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine( "Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} .. {float. MaxValue}");
Console.WriteLine($"double: {double. MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal. MaxValue}" );


Console.WriteLine();
Console.WriteLine("Переполнение byte");
byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char sepsrator = '-';
int charAsNumber = firstLetter; // char MOXHO HeABHO превратить в int - это код символа в таблице Unicode

Console.WriteLine($"Символ: {firstLetter}, разделитель: {sepsrator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");


Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");


Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20; // компилятор вывел int
var gpa = 4.75; // компилятор вывел double
var fullName = "Смирнова А.C."; // компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");


Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");



Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert. ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"B 2030 году вам будет: {2030 - birthYearConvert} лет");


Console.WriteLine();
Console.WriteLine("Анкета");

Console.Write("Введите имя и фамилию: ");
string studentName = Console.ReadLine();

Console.Write("Введите группу: ");
string group = Console.ReadLine();

Console.Write("Введите год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Введите средний балл: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите любимую букву: ");
char favoriteLetter = Console.ReadLine()[0];
int ageIn2030 = 2030 - birthYear;
bool isExcellent = averageGrade >= 4.0;

Console.WriteLine();
Console.WriteLine("Анкета");
Console.WriteLine($"{studentName}, группа {group}");
Console.WriteLine($"Год рождения: {birthYear} (в 2030 будет {ageIn2030} лет)");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Балл >= 4.0: {isExcellent}");
Console.WriteLine($"Любимая буква: {favoriteLetter}");
string fullName = "Корсарова Ангелина Сергеевна";
byte age = 22;
string email = "corsarova2001@yandex.ru";
var pointsProgramming = 85.5;
var pointsMath = 73.2;
var pointsPhysics = 90.3;

string pattern = $"Ф.И.О: {fullName} \nВозраст: {age} \nemail: {email} \nБаллы по программированию: {pointsProgramming} \nБаллы по математике: {pointsMath} \nБаллы по физике: {pointsPhysics}";


Console.WriteLine(pattern,
    fullName,
    age,
    email,
    pointsProgramming,
    pointsMath,
    pointsPhysics);
Console.ReadKey();

double allPoints = pointsProgramming + pointsMath + pointsPhysics;
double averagePoint = allPoints / 3;

string pattern2 = $"Сумма баллов: {allPoints} \nСредний балл: {averagePoint}";

Console.WriteLine(pattern2,
    allPoints,
    averagePoint);

Console.ReadKey();
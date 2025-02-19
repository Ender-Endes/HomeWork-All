
/*
**Not2:**
    * Bu ödevin tamamı için "HomeWork_18_08_2024" adında bir klasör oluşturun.
    * Bu klasör içinde her ödevi ayrı bir proje oluşturak çalışın. Örneğin: HomeWork01, HomeWork02 gibi.

*/

// 1. `int` tipinde iki değişken oluşturun ve bu değişkenlere değerler atayın. Sonra bu değişkenleri toplayıp sonucu yeni bir değişkene atayın ve ekrana yazdırın.

int num1 = 10;
int num2 = 20;
int sum = num1 + num2;
Console.WriteLine(sum);

// 2. `double` tipinde bir değişken oluşturun ve bu değişkene bir ondalıklı sayı atayın. Bu sayının karesini hesaplayıp yeni bir `double` değişkene atayın ve sonucu ekrana yazdırın.

double num = 3.14;
double square = num * num;
Console.WriteLine(square);

// 3. `string` tipinde bir değişken oluşturun ve içine adınızı atayın. Sonra `int` tipinde bir değişken oluşturup yaşınızı atayın. Bu iki değişkeni kullanarak "Benim adım [ad] ve ben [yaş] yaşındayım." şeklinde bir cümle oluşturup ekrana yazdırın.

string name = "Ender";
int age = 33;
Console.WriteLine("Benim adım " + name + " ve ben " + age + " yaşındayım.");

// 4. `char` tipinde bir değişken oluşturun ve içine bir harf atayın. Bu harfin ASCII değerini `int` tipinde bir değişkene atayıp ekrana yazdırın.

char letter = 'A';
int ascii_value = (int)letter;
Console.WriteLine(ascii_value);

// 5. `bool` tipinde iki değişken oluşturun ve bunlara `true` ve `false` değerlerini atayın. Bu değişkenleri ekrana yazdırın.

bool isEnabled = true;
bool isOver = false;
Console.WriteLine(isEnabled);
Console.WriteLine(isOver);

// 6. `byte` tipinde bir değişken oluşturun ve içine 255 değerini atayın. Sonra bu değeri `int` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.

byte number = 255;
int newNumber = (int)number;
Console.WriteLine(newNumber);

// 7. `int` tipinde bir değişken oluşturun ve içine büyük bir sayı (örneğin 1000000) atayın. Bu değeri `byte` tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.

int bigNumber = 1000000;
byte newBigNumber = (byte)bigNumber;
Console.WriteLine(newBigNumber);

// byte türündeki bir değişken 1,000,000 gibi büyük bir sayıyı tutamaz. Bu duruma overflow denir. Sayı 256'ya bölünür ve kalan alınır. 

// 8. `double` tipinde bir değişken oluşturun ve içine 3.14 değerini atayın. Bu değeri `int` tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.

double pi = 3.14;
int newPi = (int)pi;
Console.WriteLine(newPi);

// double türündeki bir değişkenin int türüne dönüştürülmesi sonucunda ondalıklı kısım atılır ve sadece tam kısım alınır.

// 9. `string` tipinde bir değişken oluşturun ve içine bir sayı yazın (örneğin "42"). Bu string'i `int` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.

string number = "42";
int castedNumber = (int)number;
Console.WriteLine(newNumber);

// 10. `int` tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp `double` tipinde bir değişkene atayın ve sonucu ekrana yazdırın.

int num1 = 5;
int num2 = 10;
int num3 = 15;
double average = (num1 + num2 + num3) / 3.0;
Console.WriteLine(average);

// 11. `decimal` tipinde iki değişken oluşturun ve bunlara para miktarları atayın (örneğin 10.25m ve 5.75m). Bu değerleri toplayıp sonucu yeni bir `decimal` değişkene atayın ve ekrana yazdırın.

decimal money1 = 10.25m;
decimal money2 = 5.75m;
decimal total = money1 + money2;
Console.WriteLine(total);

// 12. `float` tipinde bir değişken oluşturun ve içine 1.23f değerini atayın. Bu değeri `double` tipine dönüştürüp yeni bir değişkene atayın. İki değeri de ekrana yazdırıp karşılaştırın.

float num = 1.23f;
double newNum = (double)num;
Console.WriteLine(num);
Console.WriteLine(newNum);

// 13. `long` tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi. Bu değeri `int` tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.

long bigNumber = 500000000000;
int newBigNumber = (int)bigNumber;
Console.WriteLine(newBigNumber);


// 14. `string` tipinde iki değişken oluşturun ve bunlara adınızı ve soyadınızı atayın. Bu iki değişkeni birleştirip yeni bir `string` değişkene atayın ve ekrana yazdırın.

string name = "Ender";
string surname = "Endes";
string fullName = name + " " + surname;
Console.WriteLine(fullName);

// 15. `string` tipinde bir değişken oluşturun ve içine "True" yazın. Bu string'i `bool` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.

string value = "True";
bool newValue = (bool)value;
Console.WriteLine(newValue);

// 16. `double` tipinde pi sayısını temsil eden bir değişken oluşturun (3.14159). Bu değeri `float` tipine dönüştürüp yeni bir değişkene atayın. Her iki değeri de ekrana yazdırıp hassasiyet farkını gözlemleyin.

double pi = 3.14159;
float newPi = (float)pi;
Console.WriteLine(pi);
Console.WriteLine(newPi);  

// 17. `byte`, `short`, `int`, ve `long` tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın. Bu değişkenlerin bellekte kapladıkları alanı `sizeof()` operatörünü kullanarak ekrana yazdırın.`sizeof()` nasıl kullanılır, araştırın.

byte num1 = 42;
short num2 = 42;
int num3 = 42;
long num4 = 42;
Console.WriteLine(sizeof(num1));
Console.WriteLine(sizeof(num2));
Console.WriteLine(sizeof(num3));
Console.WriteLine(sizeof(num4));

// 18. `string` tipinde bir değişken oluşturun ve içine bir cümle yazın. Bu cümlenin karakter sayısını `int` tipinde bir değişkene atayıp ekrana yazdırın. (İpucu: `.Length` özelliğini kullanabilirsiniz, araştırın.)

string sentence = "Hello there!";
int length = sentence.Length;
Console.WriteLine(length);
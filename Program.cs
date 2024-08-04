using FundamentosCSharp.Models;

#region Tipos de dados

string presentation = "Hello! Welcome.";

int quantity = 2;
quantity = 10;

double height = 1.65;
string formatedHeight = height.ToString("0.0"); 

decimal price = 5.50m;

bool condition = true;

DateTime currentDate = DateTime.Now;

DateTime followingDate = DateTime.Now.AddDays(10);


// Console.WriteLine(quantity); //10
// Console.WriteLine(formatedHeight); //1,7
// Console.WriteLine(price); //5,50
// Console.WriteLine(currentDate); //04/08/2024 17:11:13
// Console.WriteLine(currentDate.ToString("dd/MM/yyyy")); //04/08/2024
// Console.WriteLine(followingDate); //14/08/2024 17:12:57


#endregion

#region Classes
Person person1 = new Person();

person1.Name = "Ana";
person1.Age = 22;
// person1.IntroduceYourself();
//>dotnet run
//Hello World! My name is Ana and i have 22 years old.
#endregion

#region Atribuição
int a = 10;
int b = 20;
int c = a + b;
c +=5;
// Console.WriteLine(c);
#endregion

#region Conversão com Cast/Casting
//int error = "5"; //Cannot implicitly convert type 'string' to 'int'CS0029
int num = Convert.ToInt32("5"); //5
// int num1 = int.Parse("5c"); //The input string '5c' was not in a correct format.
double num2 = double.Parse("5,50"); //5,5
int nullValue = Convert.ToInt32(null); //0
// int nullValue1 = int.Parse(null); //Cannot convert null literal to non-nullable reference type.CS8625
// Console.WriteLine(nullValue);
#endregion

#region Conversão com Strings
int integer = 5;
string value = integer.ToString();
string test1 = (5.50).ToString();
string test2 = person1.Name.ToString();
// Console.WriteLine(test1);
// Console.WriteLine(test2);
#endregion

#region Conversão com Cast Implícito
int d = 5;
double e = d;
// Console.WriteLine(e);

int f = 6;
long g = f;
// Console.WriteLine(f);

//int h = g; //Cannot implicitly convert type 'long' to 'int'. Long can be more than int
#endregion

#region Ordem dos operadores
double result = 4 / 2 + 2; //4
double result1 = 4 / (2+2); //1
// Console.WriteLine(result);
// Console.WriteLine(result1);
#endregion

#region Conversões seguras
string text = "15";
int numb = 0;

int.TryParse(text, out numb); //Tenta converter, senão devolve o numero

// Console.WriteLine($"Saída: {numb}");
// Console.WriteLine("Continua o programa haja erro ou não...");
#endregion

#region  Operadores condicionais
int stockQuantity = 10;
int purchaseQuantity = 4;
bool isSalePossible = purchaseQuantity > 0 && stockQuantity >= purchaseQuantity;

// Console.WriteLine($"Is it possible to sell? {isSalePossible}");

if(purchaseQuantity == 0){
    // Console.WriteLine("Sale invalid.");
}
else if(isSalePossible){
    // Console.WriteLine("Sale made!");
}else {
    // Console.WriteLine("Sorry! We do not have the desired quantity in stock.");
}

/*------------------------------------------*/

// Console.WriteLine("Enter a letter: ");
string letter = "e"; //Console.ReadLine();

switch(letter){
    case "a":
    case "e":
    case "i":
    case "o": 
    case "u":
    // Console.WriteLine("The letter is a vowel");
    break;

    default:
    // Console.WriteLine("The letter is a consonant");
    break;

}
#endregion

#region  Operadores lógicos
bool isOfAge = true;
bool hasAuthorizationFromResponsible = false;

if(isOfAge || hasAuthorizationFromResponsible){
    // Console.WriteLine("Entry released!");
} else {
    // Console.WriteLine("Entry NOT released!");
}

/*------------------------------------------*/

bool hasMinimalPresence = true;
double average = 5.5;

if(hasMinimalPresence && average >= 6){
    // Console.WriteLine("Approved");
}else {
    // Console.WriteLine("Disapproved");
}

/*------------------------------------------*/

bool rained = true;
bool isItAfternoon = true;

if(!rained && !isItAfternoon){
    // Console.WriteLine("I'm going out for a bike ride!");
} else {
    // Console.WriteLine("I'm going out cycling another day...");
}
#endregion

#region  Operadores aritméticos e classe Math
Calculator calc = new Calculator();

// calc.Add(10, 30);
// calc.Subtract(10,50);
// calc.Multiply(15,45);
// calc.Divide(2,2);
// calc.Potentiation(3,3);
// calc.Sine(30);
// calc.Cosine(30);
// calc.Tangent(30);
// calc.SquareRoot(9);

int number = 10;
// Console.WriteLine($"Number: {number}");

number++;
// Console.WriteLine($"Incrementing the number: {number}");

number = number + 5;
// Console.WriteLine($"Incrementing 5 to the number: {number}");

number--;
// Console.WriteLine($"Decreasing the number: {number}");
#endregion

#region  Estruturas de repetição

int multiTableNumber = 5;

for(int counter = 0; counter <= 10; counter++){ //Declaração da variável; Condição; Incremento
    // Console.WriteLine($"{multiTableNumber} x {counter} = {multiTableNumber * counter}");
}

/*------------------------------------------*/

int assistantCounter = 0;
while(assistantCounter <= 10)
{
    // Console.WriteLine($"{multiTableNumber} x {assistantCounter} = {multiTableNumber * assistantCounter}");
    assistantCounter++;

    //Interrompendo o fluxo de execução
    if(assistantCounter == 5)
    {
        break;
    }
}

/*------------------------------------------*/

int sum = 0, number2 = 0;

do
{
    // Console.WriteLine("Enter a number to sum or enter 0 to stop:");
    // number2 = Convert.ToInt32(Console.ReadLine());

    sum += number2;


} while (number2 != 0);

// Console.WriteLine($"The total sum is: {sum}");

/*------------------------------------------*/

string option = "1";
bool showMenu = true;

while(showMenu)
{
   
    // Console.WriteLine("Enter your option: ");
    // Console.WriteLine("1) Add customer");
    // Console.WriteLine("2) Get customer");
    // Console.WriteLine("3) Delete customer");
    // Console.WriteLine("4) Close");

    // option = Console.ReadLine();

    switch(option)
    {
        case "1":
            // Console.WriteLine("You selected customer registration");
            break;

        case "2":
            // Console.WriteLine("You selected customer search");
            break;

        case "3":
            // Console.WriteLine("You selected customer deletion");
            break;

        case "4":
            // Console.WriteLine("You selected to end the program");
            showMenu = false; //Executa o resto do código fora do while
            // Environment.Exit(0); //Para a execução do programa
            break;

        default:
            Console.WriteLine("This option does not exist");
            break;
    }

    // Console.WriteLine("----------------------------");
}

//  Console.WriteLine("The program has been terminated");
#endregion
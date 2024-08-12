
void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("Erro de divisao por zero");
        return;  
    }
        float resultado = a / b;
        Console.WriteLine($"{a} / {b} = {resultado}");
    
}
//variaveis globais
float a;
float b;

void DigitarAeB(){
    Console.WriteLine("Digitar a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digitar b:");
    b = float.Parse(Console.ReadLine());
}

//MENU

Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("|1 - Soma         |");
Console.WriteLine("|2 - Subtração    |");
Console.WriteLine("|3 - Multiplicação|");
Console.WriteLine("|4 - Divisão      |");
Console.WriteLine("|5 - Sair         |");
Console.WriteLine("-------------------");
Console.WriteLine("")


if(Opcao == 1){
    Console.WriteLine("Soma");
    DigitarAeB();
    Soma(a,b);
}

else if(Opcao == 2){
    Console.WriteLine("Subtração");
    DigitarAeB();
    Subtracao(a,b);
}

else if(Opcao == 3){
    Console.WriteLine("Mutiplicação");
    DigitarAeB();
    Multiplicacao(a,b);
}









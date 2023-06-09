Console.WriteLine("Введите начало сложения суммы: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец сложения суммы: ");
int finish = Convert.ToInt32(Console.ReadLine());

int sum = 0;
FindSum(start, finish);

int result = FindSumRecursion(start, finish);
Console.WriteLine($"Сумма элементов между {start} и {finish} равна {result}"); 

ArithmeticProgression(start, finish);

//  I.Способ (с помощью цикла):

void FindSum(int start, int finish){
    for(int i = start; i <= finish; i++){
        sum += i;
    }
    Console.WriteLine($"Сумма элементов между {start} и {finish} равна {sum}");
}

//  II.Способ (с помощью рекурсии):

int FindSumRecursion(int start, int finish)
{
    if (start == finish){
        return finish;
    }
    return start + FindSumRecursion(start + 1, finish);
}

//  III.Способ (с помощью арифметической прогресии):

void ArithmeticProgression(int start, int finish){
    int difference = finish - start + 1;
    double ArithmeticProgressionResult = (((start + finish) * difference)/2);
    Console.WriteLine($"Сумма элементов между {start} и {finish} равна {ArithmeticProgressionResult}");
}
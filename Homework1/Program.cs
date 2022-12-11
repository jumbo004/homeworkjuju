// See https://aka.ms/new-console-template for more information
// task 1 Verilmish n eddedinin 3 ve 7 e bolunub bolunmesini tapin
//Devide(21);
//static void Devide(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine($"{n} 3 ve 7e bolunur");
//    }
//    else
//    {
//        Console.WriteLine($"{n} 3 ve 7e bolunmur");
//    }
//}


//task2 n ve m eddeleri verilir.Eger n ve m eddedleri her ikisi cuddurse n ve m eddedlerinin cemini tapin.
//Cem(2, 6);
//static void Cem(int n,int m)
//{
// int sum=0; 
//    if(n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("duzgun edded daxil edin");
//    }
//}



//task 3 verilmish n ve m (n<m) eddeleri arasindaki tek eddedleriin cemini tapin
//Sum(3, 9);
//static void Sum (int n ,int m)
//{
//    int sum2 = 0;
//    for (int i =n; i<m; i++)
//    {
//        if (i%2==1)
//        {
//            sum2 = sum2+i;
//        }
//    }
//    Console.WriteLine( sum2);
//}



//task4 veilmish arraying icindeki tek ededlerin cemini tapin
//int[] arr = { 1, 2, 3, 4, 5, 6, 8 };
//Nums(arr);
//static void Nums(int[] arr)
//{
//    int sum =0; 
//    for (int i=0;i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum=sum + arr[i];
//        }
//    }
//    Console.WriteLine(sum);
//}



//task5 verilmish arrayin icindeki cut eddedlerin sayini tapin 
//int[] arr = { 2, 5, 6, 7, 8 };
//Count(arr);
//static void Count(int[] arr)
//{
//    int count2 = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count2++;
//        }
//    }
//    Console.WriteLine(count2);
//}




//task6 n ve m (n<m) eddedleri  arisandaki tek eddedleri sayini tapin
//CountNm(1, 9);
//static void CountNm(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}



//task7 virilmish n ve m (n<m) eddedleri arasindaki cut eddedlerin cemini tapin
//Sum(1,12);
//static void Sum (int n,int m)
//{
//    int sum1 = 0;
//    for (int i=n; i<m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum1 = sum1+i;

//        }
//    }
//    Console.WriteLine(sum1);

//}


//task8 n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin
//CountJ(1, 14);
//static void CountJ(int n,int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i%2==0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}


//task9 n tam edenin sade ve ya murekkeb oldugunu tapin
//Simple(20); 
//static void Simple(int n)
//{
//    int count = 0;
//    for(int i = 1; i <= n; i++)
//    {
//        if (n % 2 == 0)
//        {
//            count++;
//        }
//    }
//    if (count > 2)
//    {
//        Console.WriteLine($"{n} murekkeb ededdir");
//    }
//    else if (count == 2)
//    {
//        Console.WriteLine($"{n} sade ededdir");
//    }
//    else
//    {
//        Console.WriteLine($"{n} ne sadedir ne de murekkeb");
//    }
//}

//task10 n ededin factoriallarini hesablayin
//Factor(6);
//static void Factor(int n)
//{
//    int result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result=result*i;
//    }
//    Console.WriteLine(result);
//}
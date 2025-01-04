/*
//Burada 0,1,2,3,4,5,6,7,8,9 sayac değerleri döndürerek cw ile her seferinde bunu yazdırdım.

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim! ");
}

*/

/*
//Burada 0..20 sayac değerleri döndürerek cw ile her seferinde bunu yazdırdım.

for (int i = 1; i <= 20; ++i)
{
    Console.WriteLine(i);
}
*/
//Bu ve alttaki kodda aynı işlemi yapıyor ekrana çift sayılar yazılıyor. 
/*
for (int i = 0; i <= 20; i=i+2)
{

    Console.WriteLine(i);
}
*/

/*
for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
  
}
*/

// burada 50 ve 150 arasında her 1 artış değerinin toplamlarını değişkene atayıp döngüden çıkılınca son toplamı yazdırdım.
/*
int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam = i + toplam;
}
Console.WriteLine(toplam);

*/

//Burada da üstteki işlemin aynısını tek ve çift sayılar olarak yaptım. 
/*

int toplamcift = 0;
int toplamtek = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
      toplamcift = i + toplamcift;
    else
    {
        toplamtek = i + toplamtek;
    }
  
}
Console.WriteLine(" çift sayıların toplamı : " + toplamcift);
Console.WriteLine("tek sayıların toplamı : " + toplamtek);
*/
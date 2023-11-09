int carpim  = 1 ;
int i = 1 ;
int sayi;
Console.WriteLine("Faktöriyel Degeri hesaplanacak sayıyı giriniz : ");

sayi = int.Parse(Console.ReadLine());

while ( i < sayi)
{

    carpim *= sayi;
    
    sayi--;
   
} 
Console.WriteLine("Girdiniz Degerin Sonucu : " + carpim );

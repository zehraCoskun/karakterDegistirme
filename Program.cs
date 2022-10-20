//Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cümle girişi yapınız");
        string[] cumle = Console.ReadLine().Split(" ");
        int kelimeSayisi = cumle.Count();
        
        foreach (var item in cumle)
        {
            char[] harfler = item.ToCharArray();
            char tutucu = harfler[0];
            harfler[0]=harfler[item.Length-1];
            harfler[item.Length-1]=tutucu;
            foreach (var harf in harfler)
            {
                Console.Write(harf);
            }
            Console.WriteLine(" ");


        }
    }
}
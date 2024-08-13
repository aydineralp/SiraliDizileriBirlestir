namespace SiraliDiziBirlestir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ilk diziyi alır
            Console.Write("Birinci diziyi girin: ");  // or: 1 3 5 7 seklinde gir.
            string[] dizi1Str = Console.ReadLine().Split(' ');
            int[] dizi1 = Array.ConvertAll(dizi1Str, int.Parse);

            // Kullanıcıdan ikinci diziyi alır
            Console.Write("İkinci diziyi girin : ");
            string[] dizi2Str = Console.ReadLine().Split(' ');
            int[] dizi2 = Array.ConvertAll(dizi2Str, int.Parse);

            // Dizileri birleştirir
            int[] birlesikDizi = new int[dizi1.Length + dizi2.Length];
            int i = 0, j = 0, k = 0;

            while (i < dizi1.Length && j < dizi2.Length)
            {
                if (dizi1[i] < dizi2[j])
                    birlesikDizi[k++] = dizi1[i++];
                else
                    birlesikDizi[k++] = dizi2[j++];
            }

            // Kalan elemanları ekler
            while (i < dizi1.Length)
                birlesikDizi[k++] = dizi1[i++];

            while (j < dizi2.Length)
                birlesikDizi[k++] = dizi2[j++];

            // Sonuçları ekrana yazdırır
            Console.WriteLine("\nBirleştirilmiş ve sıralı dizi:");
            foreach (int sayi in birlesikDizi)
            {
                Console.Write(sayi + " ");
            }
        }
    }
}

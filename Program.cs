namespace inikalkulator {  
    class Kalkulator {  
        static void Main(string[] args) {  
            Console.Clear();
            while (true)
            {
                Console.WriteLine(@"Masukkan angka 1 - 4 untuk melakukan operasi
1. Jumlah
2. Kurang
3. Kali
4. Bagi");
                int menu = Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine("Masukkan angka pertama");  
                int ang1 = Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine("Masukkan angka kedua");  
                int ang2 = Convert.ToInt32(Console.ReadLine());  
                int hasil = 0;
                if (menu == 1) {
                    hasil = jumlah(ang1,ang2);
                } 
                else if (menu == 2) {
                    hasil = kurang(ang1,ang2);
                }
                else if (menu == 3) {
                    hasil = kali(ang1,ang2);
                }
                else if (menu == 4) {
                    hasil = bagi(ang1,ang2);
                }
                else {
                    Console.WriteLine("Pilih menu 1 sampai 4");
                    break;
                }
                Console.WriteLine("Hasil operasi : {0}", hasil);
                Console.WriteLine("\n Ketik y Jika ingin berhenti");
                ConsoleKeyInfo status;
                status = Console.ReadKey();
                if(status.Key==ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
        }
        //jumlah  
        public static int jumlah(int ang1, int ang2) {  
            int hasil = ang1 + ang2;  
            return hasil;  
        }  
        //kurang  
        public static int kurang(int ang1, int ang2) {  
            int hasil = ang1 - ang2;  
            return hasil;  
        }  
        //kali  
        public static int kali(int ang1, int ang2) {  
            int hasil = ang1 * ang2;  
            return hasil;  
        }  
        //bagi  
        public static int bagi(int ang1, int ang2) {  
            int hasil = ang1 / ang2;  
            return hasil;  
        }  
    }  
}  
// See https://aka.ms/new-console-template for more information

try{
    Console.WriteLine("Bir Sayı Giriniz:");
    int sayi =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
}
catch(Exception ex){
    Console.WriteLine("Hata:"+ex.Message.ToString());
}
finally{
    Console.WriteLine("İşlem tamamlandı.");
}

try
{
    // int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse("-200000000000");
}   
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch(FormatException ex){
    Console.WriteLine("Veri tipi uyumlu değil");
    Console.WriteLine(ex);
}
catch(OverflowException ex){
    Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("İşlem başarıyla tamamlandı.");
}



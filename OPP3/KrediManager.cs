using System;
using System.Collections.Generic;
using System.Text;

namespace OPP3
{
    interface IKrediManager                      //İnterface=Şablon -İnterface!leri genellikler operasyon metotlarında kullanırız.
    {
        void Hesapla();
        void BirseyYap();
    }
}
// interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız bu noktada bu 
//yaptığımıza örnekte kredi türlerinin  hepsinde hesaplama vardır hepsinde ortak mı tüm kredilerde ortaktır ama kodları farklıdır fazi 
//oranından tutun farklı kurallar tasıtta farklı ihtiyaçta fasrlı kredi türlerine göre bu hesaplama işkeri değişişklik gösterir.
//Loglama=Bir nevi o sistemdew olan hareketleri döktüğümüz bir dökümdür.Logları dosyada veri tabanında tutabilirsiniz. sms olarak atabilirsiniz
// Onu dosyaya yazmamızda veri tabanınıa yazmamızda da logluyoruz hepsinin imzası aynı ama doysaya yazarken dosyaya yazma kodları
//sms yollarken sms yollama kodları
//mail yollarken mail yollama kodları uygulanır hepsi loglamadır.
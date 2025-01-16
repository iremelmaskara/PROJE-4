# PROJE-4
Bu proje, Tiva C serisi mikrodenetleyicilerle yapılan bir uygulamadır. Proje, bir LCD ekran, ADC, UART haberleşmesi ve zamanlayıcıyı entegre ederek çeşitli işlemleri gerçekleştirir.

Projenin Amacı
LCD ekran üzerinde mesaj yazdırmak ve saati güncel şekilde göstermek.
UART üzerinden bilgisayarla iletişim kurmak.
ADC ile sıcaklık verisi almak ve bu veriyi UART üzerinden göndermek.
Timer kullanarak belirli aralıklarla olay tetiklemek.
GPIO giriş/çıkışlarını kullanarak LED kontrolü sağlamak.

Yazılım Özellikleri
LCD Kullanımı:
LCD, GPIO üzerinden 4-bit modda çalışacak şekilde ayarlanmıştır. Mesaj yazma, temizleme, satır değiştirme gibi işlemler gerçekleştirilmiştir.

UART İletişimi:
UART, bilgisayarla seri haberleşme için kullanılmıştır. UART üzerinden saat ve ADC verileri gönderilmektedir.

ADC (Analog-Dijital Dönüşüm):
ADC, sıcaklık sensöründen alınan veriyi dijital forma çevirir ve bu veri UART ile gönderilir.

Timer Kullanımı:
Timer, 1 saniyelik zaman aralıklarıyla kesme oluşturur. Bu kesme sırasında LED kontrolü yapılır ve saat güncellenir.

GPIO Kontrolü:
GPIO, LED kontrolü ve buton girişleri için kullanılmıştır.

Projenin Çalışma Adımları
Kurulum:
Donanım bağlantılarını yapın.
Tiva C'yi USB üzerinden bilgisayara bağlayın.

Kodun Derlenmesi ve Yüklenmesi:
Code Composer Studio (CCS) kullanarak kodu derleyin.
Tiva C üzerine yükleyin.

UART Haberleşmesi:
Seri port ekranını (örneğin, PuTTY , sharpdevelop veya CCS içindeki terminal) açın.
UART üzerinden gelen veriyi görüntüleyin.

Çıkışların Kontrolü:

LCD ekran üzerinde mesajlar görüntülenir.
LED yanıp söner (GPIO kontrolü).
UART üzerinden ADC verisi ve saat bilgisi gönderilir.

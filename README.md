# HangFire

• Uygulanamnın akışını bozmadan arka planda belli kodları çalıştırmak isteniyorsa kullanılabilir. Mesela uygulama ayaktayken her pazartesi bir rapor oluşturmak istiyorsanız bu amaçla kullanılır.

• Windows servis ile yapmak istediğimizde windows'a bağımlı oluyorduk. Eğer bir .Net Core yazıyorsak yani amacımız cross platform, bir linux üzerinde de çalıştırmak istesek win servisi çalıştıramayacaktık. Hangfire kullanarak cross çalışabiliriz.

• .Net Framework 4.5 üstü, .Net Core 1.0 ve üstü için kullanabiliriz.

• Hangfire kütüphanesi arka tarafta bir veritabanı kullanır. Bu bir sql server olabilir, noSql olabilir veya redis olabilir.

• Hangfire kütüphanesini bir message broker olarak kullanabilirsiniz. Kafka, RabbitMQ gibi.

• Normal projemize API, MVC, Console hepsi olabilir projeye implemente edildiğinde Job larımız belirli sürelerde çalışacaktır.

# Job Türleri


![image](https://user-images.githubusercontent.com/17917793/201527803-f4128f27-1f53-4f66-9749-cda29a5f0b56.png)

Toplam 6 job türü oluşturabiliriz.

1) FireAndForget : Tek seferde çalışacak kod için uygundur. Örn: Kullanıcı üye oldu bir mesaj göndermek istiyorsanız bu uygundur.

2) Delayed: Belirli bir süre içinde çalışacak kodlar varsa uygundur. Ör: Kullanıcı üye olduktan 1 saat/1gün /30 gün sonra bir mail göndermek için.

3) Recurring: Belirli aralıklarla çalışmak istediğiniz kodlar için. Ör: Her gün, her yıl çalışmasını istediğiniz durumlar için. Saatine saniyesine kadar ayarlıyabilirsiniz.

4) Continuations: Diğer joblardan sonra çalışacak bir kodunuz varsa bunu belirleyebilirsiniz. Bu job un çalışması için önce belirteceğin job un çalışması gerekiyor sonra bu job çalışacaktır.

5 ve 6 ile Toplu jobları çalıştırığ for ile dönüp hata meydana geldiğinde exception işlemlerini handle edebilirsiniz. 


# Hangfire dashboard

• Kütüphanenin dashboard' ı var hangi job işleniyor, başarılı/başarısız, hangi hata fırlatıldı ? Bunları görmemiz için root üzerine bir middleware ekliyoruz.

![image](https://user-images.githubusercontent.com/17917793/201527879-2c972e0b-0932-4b3d-87cb-52d19d259a79.png)



## Packages

Install-Package Hangfire.Core -v 1.7.31

Install-Package Hangfire.SqlServer -v 1.7.31

Install-Package Hangfire.AspNetCore -v 1.7.31

Install-Package HangFire.MemoryStorage -v 1.4.0 (Eğer sql server değil de memory'de verileri tutmak istiyorsanız) 

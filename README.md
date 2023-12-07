Hava Durumu Uygulaması:

Bu C# hava durumu uygulaması, şehirlerin hava durumu bilgilerini çevrimiçi olarak alıp görüntülemek için kullanılan basit bir konsol uygulamasıdır.

-Kullanım-
Uygulama, Program sınıfındaki Main metodu içerir. Bu metodun içinde bir Weather nesnesi oluşturularak belirli şehirlerin hava durumu bilgileri alınır ve ekrana yazdırılır.




-CityWeather Sınıfı-


CityWeather sınıfı, hava durumu bilgilerini temsil eder. Şu özelliklere sahiptir:

City: Şehir adını tutar.

Description: Hava durumu açıklamasını tutar.

Humidity: Nem oranını tutar.

Temperature: Sıcaklık bilgisini tutar.

Wind: Rüzgar hızını tutar.




Weather Sınıfı


Weather sınıfı, hava durumu bilgilerini çevrimiçi olarak almak için bir metod içerir. Şu özelliklere sahiptir:

GetWeather(string cityName): Belirtilen şehir adına göre hava durumu bilgilerini alır.


Gereksinimler:

Bu uygulama, .NET Framework veya .NET Core çalışma ortamına ihtiyaç duyar.

İnternet erişimi gereklidir, çünkü hava durumu bilgileri çevrimiçi bir API'dan alınır.
Notlar:

Uygulama, dış bir API'yi kullanarak hava durumu bilgilerini alır.
JSON verisi, CityWeather sınıfına dönüştürülerek kullanılır.
Hata durumunda uygun bir mesaj gösterilir.
Uygulamayı kullanarak çeşitli şehirlerin hava durumu bilgilerini takip edebilirsiniz. 
(Bazen api sayfası açılmadığında uygulama veriyi alamıyor ancak sorunsuz bir şekilde çalışıyor)

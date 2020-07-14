# Portal
 Projenin DataAccess/Concrete/DataContext kısmında veritabanın adres bilgileri tutuluyor.
 
Veritabanının adresini buradan değiştirebilirsiniz.

Veritabanı yedek dosyası ek olarak(script.sql) eklenmiştir.(Çalışması için eklenmesi gerekiyor.)


Core katmanında önceki projelerimde de kullandığım generic tiplerle ekleme, silme, güncelleme, silme işlemleri yapılmaktadır.

DataAccess katmanında Context bilgileri bulunmaktadır.

Business katmanında Mernis kimlik kontrolü servisi ve diğer filtreleme işlemleri yapılmaktadır.

Entities katmanında veritabanı tabloları tutulmaktadır.

MVC katmanında ön yüzle alakalı işlemler yapılmaktadır.

Katmanlar arası bağlar Autofac kullanılarak dependecy injection ile yapılmıştır.

Giriş sayfasında(/Home/Companies) portal ve starbuck seçenekleri vardır. Bu veriler veritabanından gelmektedir.

Kullanıcı seçim yaptığında ilgili şirketin id ve name bilgileri session olarak tutulmaktadır.








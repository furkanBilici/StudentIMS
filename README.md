# StudentIMS (Öğrenci Bilgi Yönetim Sistemi)

## Proje Hakkında
StudentIMS, Danışman, Öğrenci ve Yönetici panellerini içeren kapsamlı bir öğrenci bilgi yönetim sistemidir. Bu proje, verimli veri yönetimi ve kesintisiz bir kullanıcı deneyimi sağlamak için çeşitli teknolojilerle geliştirilmiştir.

- **Backend:** ASP.NET
- **Frontend:** HTML, CSS, JavaScript
- **Veritabanı:** Veri depolama ve yönetim için SQL

## Özellikler
- **Danışman Paneli:** Öğrenci danışmanlığı yönetimi için araçlar.
- **Öğrenci Paneli:** Öğrencilerin kayıtlarını görüntülemesi ve yönetmesi için erişim.
- **Yönetici Paneli:** Sistem genelinde kapsamlı yönetim kontrolleri.
- **Veritabanı Entegrasyonu:** Güvenli ve yapılandırılmış veri depolama için SQL veritabanı.

## Başlarken

### Gereksinimler
- **Kullanılan Teknolojiler:** ASP.NET, SQL, HTML, CSS, JavaScript
- **Ortam Gereksinimleri:**
  - ASP.NET uygulamalarını çalıştırabilen bir web sunucusu
  - Veritabanı yönetimi için SQL Server

### Kurulum
1. **Depoyu klonlayın:**
   ```bash
   git clone https://github.com/furkanBilici/StudentIMS.git
   cd StudentIMS
   ```

2. **Veritabanını ayarlayın:**
   - Depoda sağlanan `.bak` dosyasını kullanarak veritabanını geri yükleyin. Bu dosyayı SQL Server'a aktararak veritabanı yapısını ve başlangıç verilerini oluşturun.
   - Projedeki `appsettings.json` dosyasını güncelleyin. Uygulamanın veritabanına bağlanabilmesi için `DefaultConnection` değerini kendi SQL Server bağlantı dizginizle değiştirin.

3. **Uygulamayı derleyin ve çalıştırın:**
   - Projeyi Visual Studio veya başka bir uyumlu IDE'de açın.
   - Gerekli NuGet paketlerini geri yükleyin.
   - Projeyi derleyin ve yerel sunucunuzda çalıştırın.

### Kullanım
1. Belirtilen yerel sunucu adresinden uygulamaya tarayıcınız aracılığıyla erişin.
2. Sağlanan panelleri (Yönetici, Danışman veya Öğrenci) kullanarak ilgili görevleri gerçekleştirin.

## Testler
Şu anda depoda otomatik testler sağlanmamaktadır. Gelecekteki güncellemeler birim ve entegrasyon testlerini içerebilir.

## Katkıda Bulunma
Katkılar memnuniyetle karşılanır! Katkıda bulunmak için:
1. Depoyu forklayın.
2. Yeni bir dal oluşturun:
   ```bash
   git checkout -b ozellik-adi
   ```
3. Değişikliklerinizi commit edin:
   ```bash
   git commit -m "Değişiklik açıklaması"
   ```
4. Dalı gönderin:
   ```bash
   git push origin ozellik-adi
   ```
5. Bir pull request açın.

## Lisans
Bu proje Apache-2.0 Lisansı altında lisanslanmıştır. Ayrıntılar için `LICENSE` dosyasına bakın.

## İletişim
Sorularınız veya önerileriniz için [GitHub deposu](https://github.com/furkanBilici/StudentIMS) üzerinden ulaşabilirsiniz.


# 📁 Şirket-Çalışan Yönetim Sistemi (Employee Management)

Bu proje, bir şirketin çalışan yönetimini etkin ve güvenli bir şekilde yapabilmesini sağlayan bir Windows masaüstü uygulamasıdır. Proje kapsamında çalışan bilgileri, maaşlar, departmanlar, iş geçmişi gibi veriler yönetilir ve izlenebilir.

---

![Ekran görüntüsü 2025-06-16 180602](https://github.com/user-attachments/assets/e51a13a8-c27f-445e-b4c1-b562925e34ba)

---

## 🧹 Proje Özellikleri

* 👤 Çalışan bilgilerini ekleme, güncelleme ve görüntüleme (Ad, Soyad, Telefon, E-Posta vb.)
* 🕒 Çalışan bilgilerinin **güncellenmeden önceki** ve **sonraki** hallerinin izlenmesi (Audit takibi)
* 📌 Çalışanın iş geçmişi ve aktif iş pozisyonu
* 💰 Çalışan maaş bilgileri
* 🏢 Departman ve şube bilgileri
* 👥 Rol bazlı kullanıcı yönetimi (Admin, Kullanıcı vb.)
* 🔐 Veri güvenliği ve düzenli veri erişimi

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji           | Açıklama                                  |
| ------------------- | ----------------------------------------- |
| C#.NET              | Uygulama geliştirme dili                  |
| Windows Forms       | Masaüstü kullanıcı arayüzü                |
| MSSQL (v20.2)       | Veritabanı yönetimi                       |
| Stored Procedures   | Veri işlemlerini yönetmek için kullanıldı |
| Entity-Relationship | Mantıksal veritabanı modeli               |

---

## 📂 Veritabanı Tasarımı

**Temel Tablolar:**

* `Employees`: Çalışan bilgileri
* `Branches`: Şube bilgileri
* `Departments`: Departman bilgileri
* `Roles`, `Users`: Kullanıcı giriş ve yetki kontrolü
* `EmployeesAudit`: Çalışan güncelleme geçmişi
* `Salaries`: Maaş kayıtları
* `ListTypes`, `ListTypesData`: Sabit veri yönetimi (şehir, cinsiyet, unvan vb.)

---

## 🔄 Proje Fonksiyonları

* ✅ Yeni çalışan kaydı ekleme
* ✏️ Mevcut çalışan bilgisini güncelleme
* 📜 Güncelleme geçmişini listeleme
* 💼 Şube ve departman ekleme
* 🔐 Rol bazlı kullanıcı yetkilendirme

---

## 🧪 Kurulum ve Kullanım

1. Projeyi Visual Studio'da açın
2. SQL Server üzerinde `EmployeeManagement` veritabanını oluşturun
3. Gerekli `Tables` ve `Stored Procedures` scriptlerini çalıştırın
4. `App.config` dosyasındaki bağlantı cümlesini güncelleyin
5. Uygulamayı başlatın

---

## 📝 Notlar

* Veritabanında `ListTypes` ve `ListTypesData` tabloları kullanılarak dinamik sabit veriler tanımlanmıştır.
* `Audit` tablosu sayesinde, yapılan değii\u015ikliklerin geçmişi görüntülenebilir.
* `Soft Delete` özelliği tercih edilmediğinde `Hard Delete` prosedürleri kullanılmıştır.

---

## 📧 İletişim

Bu proje [Rabia YAZLI](https://linkedin.com/in/rabiayazlı34) tarafından geliştirilmiştir. Geri bildirimler ve katkılar için iletişime geçebilirsiniz.


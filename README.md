# CetStudentBook

## Assignment: Books CRUD

### What I Implemented

- **List page** (`/Books`): Tum kitaplari tablo halinde listeler. Her satirda Edit ve Delete butonlari vardir.
- **Create page** (`/Books/Create`): Yeni kitap eklemek icin form sayfasi. Validasyon kurallari uygulanir.
- **Edit page** (`/Books/Edit/{id}`): Mevcut kitabi guncellemek icin form. Hatali giris yapilirsa validasyon mesajlari gosterilir.
- **Delete page** (`/Books/Delete/{id}`): Kitap bilgilerini gosterir ve silme oncesi onay ister.

### How to Run Locally

1. Repoyu klonlayin:
   ```
   git clone https://github.com/AslandereTugba/CetStudentBook.git
   ```
2. Visual Studio 2022'de `.sln` dosyasini acin.
3. `appsettings.json` icindeki connection string'i kendi SQL Server bilgilerinize gore guncelleyin.
4. Paket Yoneticisi Konsolu'nda migration komutunu calistirin:
   ```
   Update-Database
   ```
5. Projeyi calistirin (F5).

### Database / Migration Steps

Paket Yoneticisi Konsolu'nda:
```
Add-Migration AddBooksTable
Update-Database
```
Bu komutlar Books tablosunu veritabaninda olusturur.

### Screenshots

#### Books List Page
![Books List](screenshots/books-list.png)

#### Edit Page with Validation Error
![Edit Validation](screenshots/edit-validation.png)

#### Delete Confirmation Page
![Delete Confirmation](screenshots/delete-confirmation.png)

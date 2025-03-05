**Feladatleírás**

Ebben a feladatban egy egyszerű iskolai nyilvántartó rendszert kell készítenetek, amelyben osztályok és diákok adatait kezeljük. Az alkalmazást MVVM mintában kell megvalósítanotok, és az adatok megjelenítéséhez egy XAML alapú felhasználói felületet kell készítenetek.


### **1. Osztályok definiálása**



* **SchoolClass osztály**
    * Attribútumok: `Id` (egész szám), `ClassId` (sztring)
    * Konstruktora ellenőrizze, hogy a `ClassId` nem üres vagy nullás, különben dobjon kivételt!
    * `ToString()` metódus, amely visszaadja az osztály adatait.
* **Student osztály**
    * Attribútumok: `Id` (egész szám), `Name` (sztring), `IsWoman` (logikai), `BirthDay` (dátum), `SchoolClassId` (egész szám)
    * Konstruktora ellenőrizze, hogy a `Name` nem üres vagy nullás, különben dobjon kivételt!
    * `ToString()` metódus, amely visszaadja a diák adatait.


### **2. Adattárolás**



* **SchoolClassRepo osztály**
    * Egy listában tárolja az osztályokat.
    * Metódusok:
        * `AddClass(SchoolClass schoolClass)`: Egy új osztály hozzáadása.
        * `UpdateClassName(int id, string newClassId)`: Egy osztály nevének módosítása.
        * `GetAllClasses()`: Az összes osztály visszaadása.


### **3. MVVM megvalósítása**



* **SchoolClassViewModel osztály**
    * `ObservableCollection<SchoolClass>` típusú listában tárolja az osztályokat.
    * Legalább 5 előre létrehozott osztályt tartalmazzon.
    * Készítsétek el a `CommunityToolkit.Mvvm.ComponentModel` használatával!


### **4. XAML Megjelenítés**



* **SchoolClassView.xaml**
    * ListView vezérlést használjon az osztályok megjelenítésére.
    * Az osztályok neve jelenjen meg a listában.

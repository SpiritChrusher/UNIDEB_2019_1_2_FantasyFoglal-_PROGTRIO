1.	A rendszer célja

Készülő programunk egy honfoglaló játék. Célunk ezzel a projekttel, hogy hatékonyan fejlesszük és frissítsük mind a fiatalok, mind a középkorúak, mind az idősek lexikális tudását.

Az alkalmazást úgy lehet majd használni, hogy a program egy adatbázisból random kérdést ír ki és ad négy választási lehetőséget is. El kell találni a helyes választ. A felhasználóink ezáltal új, ismeretlen kérdésekkel bővítik a már meglévő tudásukat.

Saját kérdésekkel is lehet bővíteni a játékot.

2.	A projekt terv

•	Projekt: FantasyFoglaló

o	Ütemterv:

	2019.09.30: Csapat megalakulása.

	2019.10.10: Projekt kezdete.

	2019.10.17: A dokumentáció megírása befejezésre került. Az alábbi dokumentumok elérhetőek:

•	Követelmény specifikáció: 1. Jelenlegi helyzet, 2. Vágyálom rendszer, 3. Jelenlegi üzleti folyamatok, 4. Igényelt Üzleti folyamatok

•	Funkcionális specifikáció: 1. Jelenlegi helyzet, 2. Vágyálom rendszer, 3. Jelenlegi üzleti folyamatok, 4. Igényelt Üzleti folyamatok

•	Rendszerterv: 1. A rendszer célja, 2. Projekt terv, 3. Üzleti folyamatok modellje, 4. Követelmények, 5. Funkcionálisterv, 6. Fizikai környezet, 7. Architekturális terv, 8. Tesztterv, 9. Telepítési terv, 10. Karbantartási terv

o	2019.10.20: A fejlesztés elkezdődik

o	2019.12.01: A fejlesztés befejeződik

o	2019.12.02: A tesztelés elkezdése

o	2019.12.09: Projekt átadása

o	Rendelkezésre álló idő: 35 nap

•	Szerepkörök:
o	scrum master: Szabó Kristóf

o	Front end: Szabó Kristóf, Demeter Ádám, Nagy László

o	Full stack: Szabó Kristóf, Demeter Ádám, Nagy László

o	Back end: Szabó Kristóf, Demeter Ádám, Nagy László


•	Felelősségek:

o	scrum master: A Scrum mester felügyeli és megkönnyíti a folyamat fenntartását, segíti a csapatot, ha problémába ütközik, illetve felügyeli, hogy mindenki betartja-e a Scrum alapvető szabályait.

o	Front end: Az alkalmazás kinézetéért felelős szakember. A front end megjeleníti az információt a felhasználónak.

o	Back end: A szerveren futó logika megírásáért felel pl.:
Üzleti logika, Adatbázis modell.

o	Back end: Front End és Back End munkálatok végzése egyaránt.


3. Üzleti folyamatok modellje

•	Megvalósítandó üzleti folyamatok:

o	A szoftver egy nevet és egy színt fog bekérni a felhasználótól, amelyet egy adatbázisban tárolunk

o	A felületnek lehetőséget kell biztosítania újabb kérdések, válaszok bevitelére, valamint ezeknek a törlésére.

•	Üzleti szereplők:

o	A név és a szín megadása után a szoftver felhasználó felhasználói jogosultságot kap. A felhasználónak lehetősége van a kérdések adatbázisban való tárolására. Adatbázisban tárolt kérdések, válaszok bővítésére/törlésére.

4. Követelmények:

Megnevezés

Bejelentkezés

Általános beállítások

Adatbázis bővítés

Elért pontszám


 
5. Funkcionálisterv:

o	Képrernyőterv:

	Bejelentkezés:

•	A képernyőn megjelenik egy bejelentkező felület, amelyen ki kell választani 

	Adatbázis: 

•	Ezen a felületen kérdéseket válaszokat tudunk hozzáadni törölni.


6. Fizikai környezet:
•	Az alkalmazás C# nyelven kerül megvalósításra ennek következtében a végeredmény egy asztali alkalmazás lesz melyet majd szeretnénk, webre esetleg mobilra fejleszteni. A megvalósítás Visual Studio környezethasználatával történik. Az alkalmazás fejlesztése során csak is open source függőségeket tartalmazhat. Mivel a szoftver nem csatlakozik hálózathoz, ezért tűzfal vagy egyéb hálózattal kapcsolatos tudnivaló nincs.

7. Architekturálisterv:

•	A rendszer 3 különböző rétegből fog állni. Az adatbázis réteg az első, erre épül egy logikai réteg, majd a prezentációs réteg. A prezentációs rétegünk egy mobil alkalmazás. Az adatbázist és a prezentációs rétegnek az összekötést a logikai réteg fogja biztosítani. Amikor az alkalmazásban változtatásokat, hibajavításokat végzünk a felhasználó beállításai mellett a változás határozza meg, hogy az automatikusan frissül-e. Amennyiben nem, egy figyelmeztető üzenet jelenik meg, és a felhasználó hozzájárulása szükséges a frissítés megkezdéséhez. Meghatározott tervezési minták és alapelvek betartásával a rendszer könnyen és következetesen bővíthető. A rendszer moduláris felépítése megkönnyíti, és nagy mértékben elősegíti a bővítését, fejlesztést.

8.Tesztterv:

    Vizsgált funkció      	         input	                    eredmény                elvárt eredmény           eredmény  megfelelő-e?
    bejelentkezés       4 karakternél rövidebb felhasználónév 	sikertelen	            sikertelen	                  megfelelt
    bejelentkezés       sikeres színválasztás	                sikeres	                sikeres	                      megfelelt
    kérdés hozzáadás    kevesebb mint 4 válasz megadása	        sikertelen	            sikertelen	                  megfelelt
    kérdés hozzáadás	pontosan 4 válasz megadása	            sikeres	                sikeres	                      megfelelt
    kérdés törlése	    nincs kijelölt kérdés	                sikertelen	            sikertelen	                  megfelelt

9. Telepítési terv

10. Karbantartási terv:
•	Az üzemeltetés a rendszergazda feladata. A rendszergazda lehet a megrendelő munkatársa, vagy külső munkaerő is. Az üzemeltetés során elvárás:

•	a rendszeres biztonsági mentés

•	meghibásodás esetén az utolsó konzisztens állapot visszaállítása

•	a rendszer frissítése

•	az általános átvizsgálás során észlelt hibák javítása

•	bejelentések során érkezett hibák javítása

•	a munkatársak igényeinek folyamatos figyelése és felmérése

•	biztonsági beállítások folyamatos felülvizsgálata és szükség esetén korrigálásuk.

A rendszerterv dokumentációt Demeter Ádám készítette.

# Jelenlegi helyzet

Az ember a mindennapok során a szórakoztatóipar számos fajtájával találkozik, ilyenek a filmek, könyvek és a videójátékok is. Az eredeti Honfoglaló játékban a játékosoknak lehetősége van kérdések minél pontosabb és helyesebb megválaszolásával valódi területeket mintázó térképeken helyeket "elfoglalni".

Arra gondoltunk tehát, miért is ne köthetnénk össze ezt egyéb szórakoztatóipari termékek világaival? Ha sikerül egy már népszerű és jól bejáratott játékon/játékstíluson egy elég jót csavarnunk, miközben megtartjuk azokat az értékeket amik miatt az eredeti sikeressé vált, a mi sikerünk is gyakorlatilag garantált; nem is említve hogy hasznot húzhatunk és építhetünk az eredeti brand már létező renoméjára.

A csavar tehát a következő volna: mi lenne, ha a játékosok fikcionális világok területeivel is "honfoglalózhatnának", miközben az adott világ történelméhez vagy érintett korszakához (vagy egyéb, általános témákhoz) kapcsolódó kérdéseket oldanak meg?

# Az elképzelt rendszer

A főoldalon egy áttekintés fogad minket a játékról, annak alapvető menetéről. Lehetőség van a regisztálásra, illetve a bejelentkezésre. Fiók létrehozására azért van szükség, hogy tudjuk rögzíteni az adott játékos előrehaladását és összegyűjtött tapasztalatát a játékban, melyeket aztán a játékmechanika befolyásolására használhatunk fel.

Bejelentkezés után a profilunk fogad minket. Itt egy összesített kép látható különféle statisztikákról, illetve itt tudunk pályát választani. Pályaválasztás után játékmódot van lehetőségünk kijelölni. Ezt követően lesz betöltve a megfelelé térkép, megjelenítve az ellenfelek listája, és kezdődik meg a játék.

Játék során, ahogy az eredeti `Honfoglaló` játékban is, területekre kattintunk és megpróbáljuk azt megszerezni az ellenféltől/ellenfelektől. Az, hogy mi is jelenti az ellenfél bázisát (hisz ugye vár mégse lehet), az adott pálya témájától függ. A tematikához kapcsolódó kérdéseket minél helyesebben megválaszolva a felhasználó pontot gyűjt, majd a játék végén a legtöbb területet birtokló, vagy a legtöbb ponttal rendelkező játékos győz.

A győzelemmel a játékos tapasztalati pontokat és játékban elkölthető valutát szerezhet. A valutát valódi pénzért is meg lehet vásárolni. Ezzel a belső pénzügyi rendszerrel, ún. mikrotranzakciókkal, jelentősen megnöveljük a játék bevételét, és hosszútávú fenntarthatóságát is szavatoljuk. Lehetséges továbbá még a valutákkal új térképeket kioldani is.

# Követelménylista

## A termék megjelenése

A termék fontos, hogy modern dizájnnal rendelkezzen, megfeleljen a kurrens stílusbeli irányzatoknak. Szükséges, hogy minél egyszerűbben átlátható és minél intuitívabban kezelhető legyen, hiszen akkor lesz a projekt a legsikeresebb, ha minél több embert meg tudunk ragadni - ehhez pedig elengedhetetlen egy olyan használati nehézségi görbe kialakítása, ami alacsony igényeket támaszt az elején.

## A rendszer megbízhatósága

A rendszer felhőben kell üzemeljen, hogy garantált legyen a minél stabilabb és szélesebb elérhetőség. Nem elhanyagolható szempont azonban a skálázhatóság sem, hisz egy ilyen jellegű játék bármikor fel lehet kapva - ez egy másik indok tehát a felhőszolgáltatások választására.

Cél emellett hogy minél kevesebb minden épüljön dinamikus erőforrásra. Minél kisebb a dinamikus erőforrások scope-ja, annál kisebb a támadási felülete a rendszernek, így annál nagyobb a megbízhatósága.

## A játékélmény

A játékélmény mindenek előtt addiktív kell legyen. A legtöbb pénzt a projekt akkor fogja behozni, ha minél többen minél többet játszanak, eközben minél több reklámfelületet látnak, és ha ösztönözve vannak a játékbeli valuta megvásárlására.

A pályáknak változatosaknak kell lenniük, a kérdéseknek sokrétűeknek. Ha lehetséges, a projekt későbbi életciklusaiban legyen lehetőség a felhasználók ismereteinek osztályozására és csoportosítására, így finomhangolhatóvá téve kik, mikor, milyen kérdést kapnak - tovább növelve a játék addiktivitását. 

## A technológiai stack

A játéknak a legszélesebb körben elérhetőnek kell lennie, tehát úgy számítógépen, mint mobilon is. Emiatt a játék frontendje mindenképp webalapú kell legyen, mely telefonon lehet esetleg akár PWA formába is csomagolva. A backend bármilyen alkalmas nyelven és frameworkben készülhet, azonban képesnek kell lennie új kérdések, játékmódok és pályák rugalmas hozzáadására, statisztikai mutatók lekövetésére. A backendnek és a frontendnek képesnek kell lennie játékfordítások kezelésére, és helyes megjelenítésére.

# Használati esetek / célcsoport

Mivel könyvekből / filmekből / játékokból ismerhető világokról van szó, a célcsoport mindenki, aki ezeket fogyasztja. Bár a telefon és a számítógép alapszintű használata gondot jelenthet a 40 év felettiek számára, maga a termék nem mutathat ezen az igényen felül.

A használati esetek széleskörűek. Lesz aki telefonon fog játszani utazás, vagy egyéb fajta várakozás apropóján. Lesz olyan, aki egy unalmas tanórát tölt el vele. Lesz aki jelentős órákat fog a játékkal tölteni, hogy jobban elmerülhessen egy adott világ lore-jában. Ezek következtében tehát egy-egy mérkőzésnek legfeljebb 10 percesnek kell lennie, és végeredménytől függetlenül valamilyen szintű sikerélményt kell nyújtania.

Készítette: Nagy Lászó
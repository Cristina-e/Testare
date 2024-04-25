
Comparare frameworku-uri:

Selenium, introdus de Jason Huggins în 2004, este un instrument utilizat la scara larga pentru automatizarea browserelor web. A strâns un sprijin semnificativ din partea comunității, cu aproape 30.000 de commit-uri pe GitHub de la voluntari. Selenium asigură experiențe consistente pentru utilizatori pe diverse browsere și dispozitive și include componente precum Webdriver, Selenium IDE și Selenium Grid. Comunitatea sa robustă și documentația extinsă îl fac o alegere preferată pentru nevoile de testare web.

Webdriver permite controlul browserelor pentru testarea aplicațiilor web. Selenium IDE înregistrează interacțiunile cu paginile web pentru a crea scripturi de test reutilizabile. Selenium Grid facilitează rularea testelor pe mai multe mașini simultan, îmbunătățind scalabilitatea. Împreună, aceste componente formează o soluție cuprinzătoare de testare pentru aplicațiile web.

Selenium este constant updatat reflectand angajamentul continuu al comunității Selenium de a îmbunătăți și moderniza framework-ul, asigurându-i relevanța în peisajul dezvoltării web de astăzi.

Playwright, un instrument mai nou pentru testarea aplicațiilor web end-to-end, oferă viteză și ușurință în utilizare. Instrumente Playwright precum Codegen, Playwright Inspector și Traceviewer ajută la crearea și depanarea testelor.

Comparând Playwright și Selenium:

Precondiții: Selenium necesită drivere de browser, în timp ce Playwright are nevoie doar de NodeJS. Acest proces de configurare simplificat al Playwright facilitează începerea testării automate.

Limbi Suportate: Selenium suportă mai multe limbi, inclusiv Python, Java și Ruby, în timp ce Playwright suportă JavaScript, TypeScript și altele. Acest suport mai larg al limbilor al Selenium-ului poate fi avantajos pentru echipele cu abilități diverse.

Test Runner: Playwright are propriul său runner, în timp ce Selenium se bazează pe runner-e terțe. Desi acest lucru pare a fi un avantaj pentru Playwright dar in cazul meu (flosind ambele framework-uri cu NUnit) am observat ca prefer un runner tert.

Locatori de Elemente: Selenium folosește diferiți locatori precum Id, Xpath și CSS, în timp ce Playwright are API de locatori. Sistemul simplificat de locatori al Playwright reduce complexitatea scripturilor de testare dar Selenium ofera o varietate mai mare de locatori care ne da mai mult control asupra codului .

Așteptări: Playwright include un auto-așteptare încorporat, reducând fragilitatea, în timp ce Selenium necesită așteptări explicite. Această caracteristică încorporată de auto-așteptare a Playwright simplifică dezvoltarea scripturilor de testare.

Execuție Paralelă a Testelor: Ambele suportă testarea paralelă.

Testare Vizuală: Playwright simplifică testarea vizuală cu instrumente încorporate, în timp ce Selenium necesită biblioteci externe. 

Înregistrare și Capturi de Ecran a Testelor: Playwright oferă aceste caracteristici din oficiu, în timp ce Selenium poate necesita extensii. 

Aserțiunile: sunt folosite pentru a verifica dacă starea aplicației web în cauză este cea așteptată. Pentru a utiliza aserțiuni în Selenium, puteți utiliza cuvântul cheie assert încorporat în codul dvs. sau o bibliotecă de aserții terță parte, cum ar fi NUnit, JUnit sau TestNG.

În timp ce Playwright folosește JEST. Această bibliotecă oferă o mulțime de potriviri precum toEqual, toContain, toMatch, toMatchSnapshot și multe altele. Playwright îl extinde și cu potriviri asincrone care vor aștepta până când condiția așteptată este îndeplinită.

Raportare a Testelor: Playwright oferă raportoare încorporate, în timp ce Selenium necesită extensii terțe. 

Performanță: Execuția scripturilor Playwright este mai rapidă datorită protocolului său de comunicare. Acest protocol de comunicare optimizat al Playwright contribuie la o executare mai rapidă a testelor și la o performanță generală îmbunătățită.

Suportul Comunității: Selenium are o comunitate mai mare și o documentație mai bogată în comparație cu Playwright. Pentru începători, parcurgerea unui curs de automatizare Playwright poate oferi îndrumări și resurse pentru a începe eficient.


Pentru proietul nostru am ales sa folosim Selenium, sacrificand astfel viteza de executare a testelor. Aceasta decizie a avut loc dupa ce am observat nivelul de resurse si documentatii disponibile online pentru fiecare framework. Alti factori care ne-au influentat decizia au fost: flexibilitatea pe care o ofera Selenium in localizarea elementelor - pentru incepatori ca noi s-a dovedit a fi o varianta buna de invatare deoarece includem manual anumite functionalitati care sunt incluse automat in Playwright, posibilitatea testarii pe mai multe browsere si sisteme de operare.

-Flowchart pentru a intelege utilitatea aplicatiei initiale:

<img width="436" alt="image" src="https://github.com/Cristina-e/Testare/assets/82153676/a522e9a7-556d-4a1d-9d98-6efba74f830e">


-Playlist cu rularea unor teste pe youtube:

https://www.youtube.com/playlist?list=PLZ4IZLqUlnoaoI0MhAzQh_RT47fdUF2Lq

-Comparatie viteza: 

<img width="526" alt="image" src="https://github.com/Cristina-e/Testare/assets/82153676/c960d425-fcbe-469d-8bfb-98d79d8d9905">



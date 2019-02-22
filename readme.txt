For å sette opp databasen:

https://docs.google.com/document/d/1OoyYamH9FXHXBLr4chU1AtbfghtmsJpiOxLmkpub1xc/edit




REGLER VI MÅ FØLGE:

1. Kun Commit/Push dersom koden din ikke inneholder errors, og kompilerer uten problemer.

2. Skriv koden med MVC-metodikk (veldig viktig dersom vi skal jobbe som gruppe uten å skape problemer for hverandre). Se på denne videoen for forklaring av MVC-metodikken:
https://www.youtube.com/watch?v=pCvZtjoRq1I

3. Dersom du må gjøre forandring til en annen persons kode, da du skal trykke Commit, forklar forandringen du har gjort og begrunnelsen til forandringen.

4. Da man skal navngi Model, Controller og View-filer, følg disse prinsippene:
Model skal ha likt eller samme navn som tabellen / tabellene den aksesser og fungerer opp i mot. Så f.eks 'User'-model forhandler med user_list modellen.
Controller skal alle ha Controller på slutten av navnet. Så f.eks UserEditController / UserLogInController, og helst ta i bruk Model-navnet.
View skal ha navn som korresponder mot en Controller, men uten å ende med Controller. Så f.eks 'UserEdit', 'UserLogIn' osv.



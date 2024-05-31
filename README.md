# SaveCaseToDatabase
Spara intressanta fall till en lokal databas som kan läsas med programmet "AcessCaseDatabase"

Detta ska ändras:

1. i "Main.cs" rad 41: path till var man vill spara filen som innehåller alla fall. Man behöver inte skapa filen i förväg. Den skapas automatiskt vid första körning av scriptet.

2. i "AriaInterface.cs" rad 8-10-12-14: ipaddress/servernamn till Aria databaserna. Alt. ta bort "AriaInterface.cs" från projektet och lägga till en "AriaInterface.cs" fil som redan har rätt info

3. (?) Kolla referenserna till VMS.TPS.Common.Model.API och VMS.TPS.Common.Model.Types är korrekta. Uppdatera dem annars.

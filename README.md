# Examensarbete

Detta examensarbete består av två separata API:er med fullständig CRUD-funktionalitet, samt ett konsolprojekt för seedning och återställning av databasen.

Syftet med projektet var att bygga två likvärdiga API:er med olika ramverk för att därefter genomföra prestandatester och jämföra resultaten.

Ett API har byggts med ASP.NET Core (.NET 9) och det andra med NestJS (Node.js 22). Båda API:erna är uppbyggda med controllers och kommunicerar med en gemensam Azure SQL-databas. ASP.NET-projektet använder Entity Framework, medan NestJS-projektet använder TypeORM för databashantering.


**Infrastruktur och testmiljö**
- API:erna är deployade till Azure App Services (Linux), och båda låg på samma App Service Plan.
- Databasen hostas i Azure SQL.
- Prestandatesterna genomfördes med hjälp av Azure Load Testing.
  - För att säkerställa rättvisa testresultat:
  - Endast ett API var aktivt under varje test, det andra var pausat.
  - Databasen återställdes mellan varje testomgång med hjälp av konsolprojektet.
  - Varje API testades två gånger för att öka tillförlitligheten.


**Datamodell**

Databasen består av två tabeller:
- HockeyPlayers – innehåller information om spelare. Tabellen har en foreign key till tabellen Nations, vilket innebär att varje spelare är kopplad till ett land.
- Nations – innehåller information om länder.


**Resultat**

Resultaten från prestandatesterna finns som bilder i performance-mappen i respektive projekt.

# Examensarbete

Projektet består av två api:er med CRUD-funktionalitet, samt ett consol-projekt för seedning av databas.

Syftet var att bygga två likadana api:er med olika ramverk och sedan genomföra Load Tester och jämföra prestandan sinsemellan.

I performance-mappen i vardera projekt finns bilder på resultaten för Load Testerna.

Jag har byggt ett api med ASP.Net Core och det andra i NestJS.

Testerna genomfördes med Azure Load Tester och api:erna var deployade på Azure med app servicear, som låg på samma app service plan (Linux). databasen var en Azure SQL.
Testet kördes två gånger på varje api och vid varje test-tillfälle var den app servicen som inte testades stoppad för att inte påverka resultatet.
Mellan varje test återställdes databasens data med hjälp av consol-projektet.

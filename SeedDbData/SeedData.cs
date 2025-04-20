using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDbData
{
    public static class SeedData
    {
        public static List<Nation> GetSeedNations()
        {
            return new List<Nation>
            {
            new Nation {Nationality="Sweden" },
            new Nation {Nationality="Finland"},
            new Nation {Nationality="Canada"},
            new Nation {Nationality="USA"},
            new Nation {Nationality="Czech Republic"},
            new Nation {Nationality="Russia"}
            };

        }
        public static List<HockeyPlayer> GetSeededHockeyPlayers()
        {
            return new List<HockeyPlayer>
            {
            new HockeyPlayer { FullName = "Henrik Zetterberg", HightInCm = 180, WeightInKg = 88, Club = "Detroit Red Wings", Position = "Center", Age = 43, NationId = 1 },
            new HockeyPlayer { FullName = "Nicklas Lidström", HightInCm = 185, WeightInKg = 90, Club = "Detroit Red Wings", Position = "Defense", Age = 54, NationId = 1 },
            new HockeyPlayer { FullName = "Peter Forsberg", HightInCm = 183, WeightInKg = 92, Club = "Colorado Avalanche", Position = "Center", Age = 51, NationId = 1 },
            new HockeyPlayer { FullName = "Mats Sundin", HightInCm = 191, WeightInKg = 100, Club = "Toronto Maple Leafs", Position = "Center", Age = 53, NationId = 1},
            new HockeyPlayer { FullName = "Victor Hedman", HightInCm = 198, WeightInKg = 103, Club = "Tampa Bay Lightning", Position = "Defense", Age = 33, NationId = 1},
            new HockeyPlayer { FullName = "Erik Karlsson", HightInCm = 180, WeightInKg = 85, Club = "Pittsburgh Penguins", Position = "Defense", Age = 33, NationId = 1},
            new HockeyPlayer { FullName = "Daniel Sedin", HightInCm = 182, WeightInKg = 88, Club = "Vancouver Canucks", Position = "Left Wing", Age = 43, NationId = 1},
            new HockeyPlayer { FullName = "Henrik Sedin", HightInCm = 182, WeightInKg = 88, Club = "Vancouver Canucks", Position = "Center", Age = 43, NationId = 1},
            new HockeyPlayer { FullName = "Patrik Berglund", HightInCm = 193, WeightInKg = 100, Club = "St. Louis Blues", Position = "Center", Age = 35, NationId = 1},
            new HockeyPlayer { FullName = "Filip Forsberg", HightInCm = 188, WeightInKg = 92, Club = "Nashville Predators", Position = "Left Wing", Age = 29, NationId = 1},
            new HockeyPlayer { FullName = "Gabriel Landeskog", HightInCm = 185, WeightInKg = 95, Club = "Colorado Avalanche", Position = "Left Wing", Age = 31, NationId = 1},
            new HockeyPlayer { FullName = "William Nylander", HightInCm = 183, WeightInKg = 87, Club = "Toronto Maple Leafs", Position = "Right Wing", Age = 27, NationId = 1},
            new HockeyPlayer { FullName = "Elias Pettersson", HightInCm = 188, WeightInKg = 84, Club = "Vancouver Canucks", Position = "Center", Age = 25, NationId = 1},
            new HockeyPlayer { FullName = "Rasmus Dahlin", HightInCm = 191, WeightInKg = 94, Club = "Buffalo Sabres", Position = "Defense", Age = 24 , NationId = 1},
            new HockeyPlayer { FullName = "Jacob Markström", HightInCm = 191, WeightInKg = 88, Club = "Calgary Flames", Position = "Goalie", Age = 34 , NationId = 1},
            new HockeyPlayer { FullName = "Robin Lehner", HightInCm = 192, WeightInKg = 105, Club = "Vegas Golden Knights", Position = "Goalie", Age = 33 , NationId = 1},
            new HockeyPlayer { FullName = "Alexander Edler", HightInCm = 193, WeightInKg = 97, Club = "Los Angeles Kings", Position = "Defense", Age = 38 , NationId = 1},
            new HockeyPlayer { FullName = "Oscar Lindberg", HightInCm = 185, WeightInKg = 92, Club = "Vegas Golden Knights", Position = "Center", Age = 32 , NationId = 1},
            new HockeyPlayer { FullName = "Carl Hagelin", HightInCm = 180, WeightInKg = 85, Club = "Washington Capitals", Position = "Left Wing", Age = 35 , NationId = 1},
            new HockeyPlayer { FullName = "Marcus Johansson", HightInCm = 183, WeightInKg = 86, Club = "Minnesota Wild", Position = "Left Wing", Age = 33 , NationId = 1},
            new HockeyPlayer { FullName = "Johan Larsson", HightInCm = 181, WeightInKg = 88, Club = "Arizona Coyotes", Position = "Center", Age = 32 , NationId = 1},
            new HockeyPlayer { FullName = "André Burakovsky", HightInCm = 188, WeightInKg = 86, Club = "Seattle Kraken", Position = "Left Wing", Age = 29 , NationId = 1},
            new HockeyPlayer { FullName = "Jesper Bratt", HightInCm = 180, WeightInKg = 84, Club = "New Jersey Devils", Position = "Left Wing", Age = 26 , NationId = 1},
            new HockeyPlayer { FullName = "Jonathan Eriksson", HightInCm = 185, WeightInKg = 89, Club = "AIK", Position = "Right Wing", Age = 28 , NationId = 1},
            new HockeyPlayer { FullName = "Kevin Sandberg", HightInCm = 190, WeightInKg = 95, Club = "HV71", Position = "Defense", Age = 27 , NationId = 1},
            new HockeyPlayer { FullName = "Linus Karlsson", HightInCm = 178, WeightInKg = 82, Club = "Färjestad", Position = "Center", Age = 26 , NationId = 1},
            new HockeyPlayer { FullName = "Max Nylander", HightInCm = 183, WeightInKg = 86, Club = "Luleå", Position = "Left Wing", Age = 29 , NationId = 1},
            new HockeyPlayer { FullName = "Simon Holm", HightInCm = 192, WeightInKg = 100, Club = "Frölunda", Position = "Defense", Age = 30 , NationId = 1},
            new HockeyPlayer { FullName = "Oscar Lindqvist", HightInCm = 181, WeightInKg = 84, Club = "Djurgården", Position = "Right Wing", Age = 25 , NationId = 1},
            new HockeyPlayer { FullName = "Tobias Berg", HightInCm = 186, WeightInKg = 88, Club = "Linköping", Position = "Center", Age = 27 , NationId = 1},
            new HockeyPlayer { FullName = "Teemu Selänne", HightInCm = 184, WeightInKg = 94, Club = "Anaheim Ducks", Position = "Right Wing", Age = 53, NationId = 2 },
            new HockeyPlayer { FullName = "Saku Koivu", HightInCm = 180, WeightInKg = 89, Club = "Montreal Canadiens", Position = "Center", Age = 49, NationId = 2 },
            new HockeyPlayer { FullName = "Jari Kurri", HightInCm = 183, WeightInKg = 89, Club = "Edmonton Oilers", Position = "Right Wing", Age = 58, NationId = 2 },
            new HockeyPlayer { FullName = "Mikko Koivu", HightInCm = 188, WeightInKg = 98, Club = "Minnesota Wild", Position = "Center", Age = 40, NationId = 2 },
            new HockeyPlayer { FullName = "Kimi Räikkönen", HightInCm = 185, WeightInKg = 84, Club = "TPS Hockey", Position = "Forward", Age = 44, NationId = 2 },
            new HockeyPlayer { FullName = "Patrik Laine", HightInCm = 193, WeightInKg = 92, Club = "Columbus Blue Jackets", Position = "Right Wing", Age = 26, NationId = 2 },
            new HockeyPlayer { FullName = "Aleksander Barkov", HightInCm = 193, WeightInKg = 99, Club = "Florida Panthers", Position = "Center", Age = 28, NationId = 2 },
            new HockeyPlayer { FullName = "Kaapo Kakko", HightInCm = 187, WeightInKg = 91, Club = "New York Rangers", Position = "Right Wing", Age = 23, NationId = 2 },
            new HockeyPlayer { FullName = "Rasmus Ristolainen", HightInCm = 191, WeightInKg = 103, Club = "Philadelphia Flyers", Position = "Defense", Age = 30, NationId = 2 },
            new HockeyPlayer { FullName = "Valtteri Filppula", HightInCm = 183, WeightInKg = 88, Club = "New York Islanders", Position = "Center", Age = 39, NationId = 2 },
            new HockeyPlayer { FullName = "Patrik Laine", HightInCm = 191, WeightInKg = 94, Club = "Columbus Blue Jackets", Position = "Right Wing", Age = 26, NationId = 2 },
            new HockeyPlayer { FullName = "Sebastian Aho", HightInCm = 183, WeightInKg = 88, Club = "Carolina Hurricanes", Position = "Center", Age = 27, NationId = 2 },
            new HockeyPlayer { FullName = "Aleksander Barkov", HightInCm = 193, WeightInKg = 96, Club = "Florida Panthers", Position = "Center", Age = 28, NationId = 2 },
            new HockeyPlayer { FullName = "Mikko Rantanen", HightInCm = 195, WeightInKg = 100, Club = "Colorado Avalanche", Position = "Right Wing", Age = 27, NationId = 2 },
            new HockeyPlayer { FullName = "Teuvo Teräväinen", HightInCm = 181, WeightInKg = 79, Club = "Carolina Hurricanes", Position = "Left Wing", Age = 26, NationId = 2 },
            new HockeyPlayer { FullName = "Rasmus Ristolainen", HightInCm = 191, WeightInKg = 103, Club = "Philadelphia Flyers", Position = "Defense", Age = 30, NationId = 2 },
            new HockeyPlayer { FullName = "Joonas Korpisalo", HightInCm = 185, WeightInKg = 85, Club = "Columbus Blue Jackets", Position = "Goalie", Age = 29, NationId = 2 },
            new HockeyPlayer { FullName = "Kasperi Kapanen", HightInCm = 182, WeightInKg = 84, Club = "Pittsburgh Penguins", Position = "Right Wing", Age = 27, NationId = 2 },
            new HockeyPlayer { FullName = "Juho Lammikko", HightInCm = 186, WeightInKg = 88, Club = "Florida Panthers", Position = "Center", Age = 26, NationId = 2 },
            new HockeyPlayer { FullName = "Eeli Tolvanen", HightInCm = 180, WeightInKg = 83, Club = "Seattle Kraken", Position = "Left Wing", Age = 24, NationId = 2 },
            new HockeyPlayer { FullName = "Connor McDavid", HightInCm = 193, WeightInKg = 93, Club = "Edmonton Oilers", Position = "Center", Age = 26, NationId = 3 },
            new HockeyPlayer { FullName = "Sidney Crosby", HightInCm = 180, WeightInKg = 91, Club = "Pittsburgh Penguins", Position = "Center", Age = 36, NationId = 3 },
            new HockeyPlayer { FullName = "Nathan MacKinnon", HightInCm = 183, WeightInKg = 100, Club = "Colorado Avalanche", Position = "Center", Age = 28, NationId = 3 },
            new HockeyPlayer { FullName = "Leon Draisaitl", HightInCm = 193, WeightInKg = 110, Club = "Edmonton Oilers", Position = "Center", Age = 28, NationId = 3 },
            new HockeyPlayer { FullName = "Auston Matthews", HightInCm = 191, WeightInKg = 98, Club = "Toronto Maple Leafs", Position = "Center", Age = 26, NationId = 3 },
            new HockeyPlayer { FullName = "Brad Marchand", HightInCm = 180, WeightInKg = 83, Club = "Boston Bruins", Position = "Left Wing", Age = 35, NationId = 3 },
            new HockeyPlayer { FullName = "Steven Stamkos", HightInCm = 191, WeightInKg = 95, Club = "Tampa Bay Lightning", Position = "Center", Age = 33, NationId = 3 },
            new HockeyPlayer { FullName = "Carey Price", HightInCm = 191, WeightInKg = 99, Club = "Montreal Canadiens", Position = "Goalie", Age = 36, NationId = 3 },
            new HockeyPlayer { FullName = "John Tavares", HightInCm = 185, WeightInKg = 93, Club = "Toronto Maple Leafs", Position = "Center", Age = 33, NationId = 3 },
            new HockeyPlayer { FullName = "Mark Scheifele", HightInCm = 191, WeightInKg = 94, Club = "Winnipeg Jets", Position = "Center", Age = 30, NationId = 3 },
            new HockeyPlayer { FullName = "Mitch Marner", HightInCm = 185, WeightInKg = 82, Club = "Toronto Maple Leafs", Position = "Right Wing", Age = 26, NationId = 3 },
            new HockeyPlayer { FullName = "Tyler Seguin", HightInCm = 188, WeightInKg = 93, Club = "Dallas Stars", Position = "Center", Age = 32, NationId = 3 },
            new HockeyPlayer { FullName = "Ryan O'Reilly", HightInCm = 191, WeightInKg = 96, Club = "Toronto Maple Leafs", Position = "Center", Age = 33, NationId = 3 },
            new HockeyPlayer { FullName = "Brayden Point", HightInCm = 180, WeightInKg = 80, Club = "Tampa Bay Lightning", Position = "Center", Age = 27, NationId = 3 },
            new HockeyPlayer { FullName = "Darnell Nurse", HightInCm = 193, WeightInKg = 103, Club = "Edmonton Oilers", Position = "Defense", Age = 28, NationId = 3 },
            new HockeyPlayer { FullName = "Alex Pietrangelo", HightInCm = 193, WeightInKg = 102, Club = "Vegas Golden Knights", Position = "Defense", Age = 33, NationId = 3 },
            new HockeyPlayer { FullName = "Shea Weber", HightInCm = 191, WeightInKg = 109, Club = "Montreal Canadiens", Position = "Defense", Age = 39, NationId = 3 },
            new HockeyPlayer { FullName = "TJ Brodie", HightInCm = 183, WeightInKg = 91, Club = "Toronto Maple Leafs", Position = "Defense", Age = 34, NationId = 3 },
            new HockeyPlayer { FullName = "Tyson Barrie", HightInCm = 180, WeightInKg = 85, Club = "Edmonton Oilers", Position = "Defense", Age = 33, NationId = 3 },
            new HockeyPlayer { FullName = "Jake Muzzin", HightInCm = 191, WeightInKg = 102, Club = "Toronto Maple Leafs", Position = "Defense", Age = 35, NationId = 3 },
            new HockeyPlayer { FullName = "Patrick Kane", HightInCm = 180, WeightInKg = 88, Club = "Chicago Blackhawks", Position = "Right Wing", Age = 34, NationId = 4 },
            new HockeyPlayer { FullName = "Austin Matthews", HightInCm = 191, WeightInKg = 98, Club = "Toronto Maple Leafs", Position = "Center", Age = 26, NationId = 4 },
            new HockeyPlayer { FullName = "Johnny Gaudreau", HightInCm = 175, WeightInKg = 68, Club = "Columbus Blue Jackets", Position = "Left Wing", Age = 30, NationId = 4 },
            new HockeyPlayer { FullName = "Jack Eichel", HightInCm = 191, WeightInKg = 93, Club = "Vegas Golden Knights", Position = "Center", Age = 27, NationId = 4 },
            new HockeyPlayer { FullName = "Zach Parise", HightInCm = 180, WeightInKg = 92, Club = "New York Islanders", Position = "Left Wing", Age = 39, NationId = 4 },
            new HockeyPlayer { FullName = "Joe Pavelski", HightInCm = 180, WeightInKg = 93, Club = "Dallas Stars", Position = "Center", Age = 39, NationId = 4 },
            new HockeyPlayer { FullName = "Blake Wheeler", HightInCm = 193, WeightInKg = 101, Club = "Winnipeg Jets", Position = "Right Wing", Age = 37, NationId = 4 },
            new HockeyPlayer { FullName = "Ryan Suter", HightInCm = 188, WeightInKg = 98, Club = "Dallas Stars", Position = "Defense", Age = 39, NationId = 4 },
            new HockeyPlayer { FullName = "Chris Kreider", HightInCm = 188, WeightInKg = 97, Club = "New York Rangers", Position = "Left Wing", Age = 32, NationId = 4 },
            new HockeyPlayer { FullName = "Adam Fox", HightInCm = 180, WeightInKg = 88, Club = "New York Rangers", Position = "Defense", Age = 26, NationId = 4 },
            new HockeyPlayer { FullName = "Seth Jones", HightInCm = 191, WeightInKg = 96, Club = "Chicago Blackhawks", Position = "Defense", Age = 29, NationId = 4 },
            new HockeyPlayer { FullName = "Phil Kessel", HightInCm = 183, WeightInKg = 94, Club = "Vegas Golden Knights", Position = "Right Wing", Age = 36, NationId = 4 },
            new HockeyPlayer { FullName = "J.T. Miller", HightInCm = 188, WeightInKg = 102, Club = "Vancouver Canucks", Position = "Center", Age = 31, NationId = 4 },
            new HockeyPlayer { FullName = "Charlie McAvoy", HightInCm = 191, WeightInKg = 97, Club = "Boston Bruins", Position = "Defense", Age = 26, NationId = 4 },
            new HockeyPlayer { FullName = "T.J. Oshie", HightInCm = 180, WeightInKg = 93, Club = "Washington Capitals", Position = "Right Wing", Age = 37, NationId = 4 },
            new HockeyPlayer { FullName = "David Pastrnak", HightInCm = 193, WeightInKg = 95, Club = "Boston Bruins", Position = "Right Wing", Age = 27, NationId = 5 },
            new HockeyPlayer { FullName = "Jakub Voracek", HightInCm = 191, WeightInKg = 99, Club = "Columbus Blue Jackets", Position = "Right Wing", Age = 34, NationId = 5 },
            new HockeyPlayer { FullName = "Patrik Laine", HightInCm = 193, WeightInKg = 94, Club = "Columbus Blue Jackets", Position = "Left Wing", Age = 26, NationId = 5 },
            new HockeyPlayer { FullName = "Tomas Hertl", HightInCm = 193, WeightInKg = 104, Club = "San Jose Sharks", Position = "Center", Age = 33, NationId = 5 },
            new HockeyPlayer { FullName = "Martin Nečas", HightInCm = 185, WeightInKg = 86, Club = "Carolina Hurricanes", Position = "Center", Age = 24, NationId = 5 },
            new HockeyPlayer { FullName = "Alexander Ovechkin", HightInCm = 191, WeightInKg = 107, Club = "Washington Capitals", Position = "Left Wing", Age = 38, NationId = 6 },
            new HockeyPlayer { FullName = "Evgeni Malkin", HightInCm = 191, WeightInKg = 95, Club = "Pittsburgh Penguins", Position = "Center", Age = 38, NationId = 6 },
            new HockeyPlayer { FullName = "Artemi Panarin", HightInCm = 180, WeightInKg = 87, Club = "New York Rangers", Position = "Left Wing", Age = 32, NationId = 6 },
            new HockeyPlayer { FullName = "Nikita Kucherov", HightInCm = 184, WeightInKg = 93, Club = "Tampa Bay Lightning", Position = "Right Wing", Age = 30, NationId = 6 },
            new HockeyPlayer { FullName = "Vladimir Tarasenko", HightInCm = 185, WeightInKg = 102, Club = "New York Rangers", Position = "Right Wing", Age = 32, NationId = 6 },
            new HockeyPlayer { FullName = "Sergei Bobrovsky", HightInCm = 185, WeightInKg = 85, Club = "Florida Panthers", Position = "Goalie", Age = 35, NationId = 6 },
            new HockeyPlayer { FullName = "Andrei Vasilevskiy", HightInCm = 193, WeightInKg = 98, Club = "Tampa Bay Lightning", Position = "Goalie", Age = 29, NationId = 6 },
            new HockeyPlayer { FullName = "Dmitry Orlov", HightInCm = 183, WeightInKg = 94, Club = "Boston Bruins", Position = "Defense", Age = 32, NationId = 6 },
            new HockeyPlayer { FullName = "Evgeny Kuznetsov", HightInCm = 191, WeightInKg = 91, Club = "Washington Capitals", Position = "Center", Age = 31, NationId = 6 },
            new HockeyPlayer { FullName = "Kirill Kaprizov", HightInCm = 180, WeightInKg = 87, Club = "Minnesota Wild", Position = "Left Wing", Age = 27, NationId = 6 }
            };
        }
       
    }
}

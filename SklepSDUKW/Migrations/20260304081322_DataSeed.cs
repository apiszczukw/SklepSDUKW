using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepSDUKW.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Straszne filmy pełne napięcia, grozy i nadprzyrodzonych zjawisk.", "Horror" },
                    { 2, "Filmy science fiction osadzone w przyszłości, kosmosie lub alternatywnej rzeczywistości.", "Sci-Fi" },
                    { 3, "Lekkie i humorystyczne produkcje mające na celu rozbawić widza.", "Komedia" },
                    { 4, "Poruszające historie skupiające się na emocjach, relacjach i życiowych dylematach bohaterów.", "Dramat" },
                    { 5, "Dynamiczne filmy z widowiskowymi scenami walki, pościgów i efektów specjalnych.", "Akcja" },
                    { 6, "Filmy tworzone techniką animacji, skierowane zarówno do dzieci, jak i dorosłych.", "Animacja" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Historia rodziny nawiedzanej przez demoniczną obecność.", "James Wan", null, "The Conjuring" },
                    { 2, 1, "Psychologiczny horror o rodzinnej traumie i mrocznych tajemnicach.", "Ari Aster", null, "Hereditary" },
                    { 3, 1, "Klasyczna opowieść o opętaniu i egzorcyzmach.", "William Friedkin", null, "The Exorcist" },
                    { 4, 1, "Grupa dzieci stawia czoła przerażającemu klaunowi.", "Andy Muschietti", null, "It" },
                    { 5, 1, "Dziennikarka bada tajemniczą kasetę wideo przynoszącą śmierć.", "Gore Verbinski", null, "The Ring" },
                    { 6, 1, "Morderca atakujący swoje ofiary w snach.", "Wes Craven", null, "A Nightmare on Elm Street" },
                    { 7, 1, "Izolacja w hotelu prowadzi do szaleństwa.", "Stanley Kubrick", null, "The Shining" },
                    { 8, 1, "Rodzina walczy z bytami z innego wymiaru.", "James Wan", null, "Insidious" },
                    { 9, 1, "Matka i syn konfrontują się z mroczną istotą z książki.", "Jennifer Kent", null, "The Babadook" },
                    { 10, 1, "Psychopatyczny morderca zmusza ofiary do makabrycznych wyborów.", "James Wan", null, "Saw" },
                    { 11, 2, "Podróż przez kosmos w poszukiwaniu nowego domu dla ludzkości.", "Christopher Nolan", null, "Interstellar" },
                    { 12, 2, "Złodzieje wnikają w sny, by kraść tajemnice.", "Christopher Nolan", null, "Inception" },
                    { 13, 2, "Haker odkrywa prawdziwą naturę rzeczywistości.", "The Wachowskis", null, "The Matrix" },
                    { 14, 2, "Łowca androidów odkrywa sekret zagrażający światu.", "Denis Villeneuve", null, "Blade Runner 2049" },
                    { 15, 2, "Lingwistka próbuje porozumieć się z obcą cywilizacją.", "Denis Villeneuve", null, "Arrival" },
                    { 16, 2, "Walka o kontrolę nad pustynną planetą Arrakis.", "Denis Villeneuve", null, "Dune" },
                    { 17, 2, "Astronauci walczą o przetrwanie w przestrzeni kosmicznej.", "Alfonso Cuarón", null, "Gravity" },
                    { 18, 2, "Eksperyment z zaawansowaną sztuczną inteligencją.", "Alex Garland", null, "Ex Machina" },
                    { 19, 2, "Astronauta próbuje przeżyć samotnie na Marsie.", "Ridley Scott", null, "The Martian" },
                    { 20, 2, "Podzielony świat przyszłości i walka o równość.", "Neill Blomkamp", null, "Elysium" },
                    { 21, 3, "Szalone poszukiwania zaginionego pana młodego w Las Vegas.", "Todd Phillips", null, "The Hangover" },
                    { 22, 3, "Dwóch nastolatków przeżywa ostatnią imprezę przed studiami.", "Greg Mottola", null, "Superbad" },
                    { 23, 3, "Mężczyzna przeżywa wciąż ten sam dzień.", "Harold Ramis", null, "Groundhog Day" },
                    { 24, 3, "Antybohater o niewyparzonym języku szuka zemsty.", "Tim Miller", null, "Deadpool" },
                    { 25, 3, "Seria katastrof podczas organizacji ślubu przyjaciółki.", "Paul Feig", null, "Bridesmaids" },
                    { 26, 3, "Nieśmiały mężczyzna odkrywa magiczną maskę.", "Chuck Russell", null, "The Mask" },
                    { 27, 3, "Chłopiec sam broni domu przed złodziejami.", "Chris Columbus", null, "Home Alone" },
                    { 28, 3, "Dwóch dorosłych mężczyzn musi nauczyć się wspólnego życia.", "Adam McKay", null, "Step Brothers" },
                    { 29, 3, "Mężczyzna zaczyna mówić 'tak' każdej propozycji.", "Peyton Reed", null, "Yes Man" },
                    { 30, 3, "Barwna opowieść o concierge'u i jego przygodach.", "Wes Anderson", null, "The Grand Budapest Hotel" },
                    { 31, 4, "Historia przyjaźni i nadziei w więzieniu.", "Frank Darabont", null, "The Shawshank Redemption" },
                    { 32, 4, "Niezwykłe życie prostolinijnego mężczyzny.", "Robert Zemeckis", null, "Forrest Gump" },
                    { 33, 4, "Nadzwyczajne wydarzenia w celi śmierci.", "Frank Darabont", null, "The Green Mile" },
                    { 34, 4, "Biografia genialnego matematyka zmagającego się z chorobą.", "Ron Howard", null, "A Beautiful Mind" },
                    { 35, 4, "Mężczyzna tworzy podziemny klub walki.", "David Fincher", null, "Fight Club" },
                    { 36, 4, "Ojciec walczy o lepsze życie dla syna.", "Gabriele Muccino", null, "The Pursuit of Happyness" },
                    { 37, 4, "Rzymski generał szuka zemsty jako gladiator.", "Ridley Scott", null, "Gladiator" },
                    { 38, 4, "Historia pianisty w czasie II wojny światowej.", "Roman Polanski", null, "The Pianist" },
                    { 39, 4, "Portret psychologiczny przyszłego przestępcy.", "Todd Phillips", null, "Joker" },
                    { 40, 4, "Student perkusji pod presją bezwzględnego nauczyciela.", "Damien Chazelle", null, "Whiplash" },
                    { 41, 5, "Pościg przez postapokaliptyczne pustkowia.", "George Miller", null, "Mad Max: Fury Road" },
                    { 42, 5, "Były zabójca wraca do świata przestępczego.", "Chad Stahelski", null, "John Wick" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 43, 5, "Policjant samotnie walczy z terrorystami.", "John McTiernan", null, "Die Hard" },
                    { 44, 5, "Batman staje do walki z Jokerem.", "Christopher Nolan", null, "The Dark Knight" },
                    { 45, 5, "Superbohaterowie łączą siły przeciw zagrożeniu.", "Joss Whedon", null, "The Avengers" },
                    { 46, 5, "Agent Ethan Hunt wykonuje kolejną niebezpieczną misję.", "Christopher McQuarrie", null, "Mission: Impossible – Fallout" },
                    { 47, 5, "James Bond rozpoczyna swoją służbę jako agent 007.", "Martin Campbell", null, "Casino Royale" },
                    { 48, 5, "Spektakularne walki na arenie starożytnego Rzymu.", "Ridley Scott", null, "Gladiator" },
                    { 49, 5, "Mężczyzna bez pamięci odkrywa, że jest wyszkolonym agentem.", "Doug Liman", null, "The Bourne Identity" },
                    { 50, 5, "Bitwa Spartan przeciwko perskiej armii.", "Zack Snyder", null, "300" },
                    { 51, 6, "Zabawki ożywają pod nieobecność właściciela.", "John Lasseter", null, "Toy Story" },
                    { 52, 6, "Młody lew walczy o swoje miejsce w królestwie.", "Roger Allers", null, "The Lion King" },
                    { 53, 6, "Siostrzana miłość w magicznym królestwie.", "Chris Buck", null, "Frozen" },
                    { 54, 6, "Ogr wyrusza na misję ratowania księżniczki.", "Andrew Adamson", null, "Shrek" },
                    { 55, 6, "Ojciec przemierza ocean w poszukiwaniu syna.", "Andrew Stanton", null, "Finding Nemo" },
                    { 56, 6, "Staruszek wyrusza w podróż domu unoszącego się na balonach.", "Pete Docter", null, "Up" },
                    { 57, 6, "Chłopiec odkrywa tajemnice przodków w świecie zmarłych.", "Lee Unkrich", null, "Coco" },
                    { 58, 6, "Emocje sterują życiem dziewczynki.", "Pete Docter", null, "Inside Out" },
                    { 59, 6, "Policyjna intryga w mieście zamieszkanym przez zwierzęta.", "Byron Howard", null, "Zootopia" },
                    { 60, 6, "Dziewczynka trafia do magicznego świata duchów.", "Hayao Miyazaki", null, "Spirited Away" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

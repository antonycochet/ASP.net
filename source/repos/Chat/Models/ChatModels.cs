using System.Collections.Generic;

namespace Chat.Models
{
    public class ChatModels
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }

        public static List<ChatModels> GetMeuteDeChats()
        {
            var i = 1;
            return new List<ChatModels>
            {
                new ChatModels{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new ChatModels{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new ChatModels{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new ChatModels{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new ChatModels{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new ChatModels{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new ChatModels{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }
    }
}
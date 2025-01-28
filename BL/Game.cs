using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json.Serialization;

namespace STEAM.Models
{
    public class Game
    {
        public Game() { }

        public int AppID;
        public string Name;
        public string ReleaseDate;
        public double Price;
        public string Description;
        public string HeaderImage;
        public string Website;
        public string Windows;
        public string Mac;
        public string Linux;
        public int ScoreRank;
        public string Recommendations;
        public string Publisher;
        public int NumberOfPurchases;

        public static List<Game> GamesList = new List<Game>();


        public Game(int AppID, string Name, string ReleaseDate, double Price,
            string Description, string HeaderImage, string Website, string Windows,
            string Mac, string Linux, int ScoreRank, string Recommendations, string Publisher, int NumberOfPurchases)
        {
            appID = AppID;
            name = Name;
            releaseDate = ReleaseDate;
            price = Price;
            description = Description;
            headerImage = HeaderImage;
            website = Website;
            windows = Windows;
            mac = Mac;
            linux = Linux;
            scoreRank = ScoreRank;
            recommendations = Recommendations;
            publisher = Publisher;
            numberOfPurchases = NumberOfPurchases;
        }

        public int appID { get => AppID; set => AppID = value; }
        public string name { get => Name; set => Name = value; }

        [JsonPropertyName("Release_date")]
        public string releaseDate { get => ReleaseDate; set => ReleaseDate = value; }
        public double price { get => Price; set => Price = value; }

        [JsonPropertyName("description")]
        public string description { get => Description; set => Description = value; }

        [JsonPropertyName("Header_image")]
        public string headerImage { get => HeaderImage; set => HeaderImage = value; }
        public string website { get => Website; set => Website = value; }
        public string windows { get => Windows; set => Windows = value; }
        public string mac { get => Mac; set => Mac = value; }
        public string linux { get => Linux; set => Linux = value; }

        [JsonPropertyName("Score_rank")]
        public int scoreRank { get => ScoreRank; set => ScoreRank = value; }
        public string recommendations { get => Recommendations; set => Recommendations = value; }

        [JsonPropertyName("Developers")]
        public string publisher { get => Publisher; set => Publisher = value; }

        public int numberOfPurchases { get => NumberOfPurchases; set => NumberOfPurchases = value; }

        public int UserBuyGame(int ID, int AppID)
        {
            DBservices dbs = new DBservices();
            return dbs.UserBuyGame(ID, AppID);
        }

        public List<Game> MyGames(int UserID)
        {
            DBservices dbs = new DBservices();
            return dbs.MyGames(UserID);
        }

        public List<Game> GetByPrice(string UserID, double price)
        {
            DBservices dbs = new DBservices();
            return dbs.GetByPrice(UserID, price);
        }

        public List<Game> GetByRankScore(string UserID, int RankScore)
        {
            DBservices dbs = new DBservices();
            return dbs.GetByRankScore(UserID, RankScore);
        }

        public int DeleteById(int ID, int AppID)
        {

            DBservices dbs = new DBservices();
            return dbs.DeleteById(ID, AppID);

        }

     

    }

}

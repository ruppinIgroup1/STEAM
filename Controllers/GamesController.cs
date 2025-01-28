using Microsoft.AspNetCore.Mvc;
using STEAM.Models;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace STEAM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        [HttpGet("GetByPrice")] //Using QueryString
        public List<Game> GetByPrice(string UserID, double price)
        {
            Game game = new Game();
            List<Game> Result = game.GetByPrice(UserID, price);
            return Result;

        }


        [HttpGet("searchByScore/UserID/{UserID}/minScoreRank/{minScoreRank}")]   // Using resource routing
        public List<Game> GetByRankScore(string UserID, int minScoreRank) 
        {
            Game game = new Game();
            List <Game> Result = game.GetByRankScore(UserID, minScoreRank);
            return Result;
        }

        [HttpGet]
        [Route("GetGameDetailsWithDownloadsAndRevenue")]
        public IActionResult GetGameDetailsWithDownloadsAndRevenue()
        {
            DBservices dbs = new DBservices();
            Object result = dbs.GetGameDetailsWithDownloadsAndRevenue();
            return Ok(result);
        }


        [HttpDelete("DeleteByID")] // Using QueryString
        public int DeleteById(int ID, int AppID)
        {
            Game game = new Game();
            return game.DeleteById(ID, AppID);
            
        }




        // GET: api/<GamesController>
        [HttpGet]
        public List<Game> MyGames(int UserID)
        {
            Game game = new Game();
            List<Game> Result = game.MyGames(UserID);
            return Result;
        }

        // GET api/<GamesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GamesController>
        [HttpPost]
        public int UserBuyGame(int ID, int AppID)
        {
            Game game = new Game();
            return game.UserBuyGame(ID, AppID);
        }


        // PUT api/<GamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<GamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

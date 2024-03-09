﻿using BoardGamesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoardGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGamesController : ControllerBase
    {
        private readonly ILogger<BoardGamesController> _logger;
        public BoardGamesController(ILogger<BoardGamesController> logger) 
        {
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 60)]
        public IEnumerable<BoardGame> Get()
        {
            return new[]
            {
                new BoardGame()
                {
                    Id = 1,
                    Name = "Axis & Allies",
                    Year = 1981
                },
                new BoardGame()
                {
                    Id = 2,
                    Name = "Citadels",
                    Year = 2000
                },
                new BoardGame()
                {
                    Id = 3,
                    Name = "Terraforming Mars",
                    Year = 2016
                }
            };
        }
    }
}
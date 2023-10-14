using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Description = "The movie is about the 1912 sinking of the RMS Titanic. It stars Kate Winslet and Leonardo DiCaprio. The two play characters who are of different social classes. They fall in love after meeting aboard the ship, but it was not good for a rich girl to fall in love with a poor boy in 1912." },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Description = "Inception centres on brooding “extractor” Dom Cobb (played by Leonardo DiCaprio)—a thief who invades targets' dreams through a chemical-induced shared dream state in order to steal valuable information. Having a reputation for being the best in his business, Cobb is commissioned by wealthy businessman Mr."   },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Description = "In THE SHAWSHANK REDEMPTION, Andy Dufresne (Tim Robbins) is convicted for the murder of his wife and her lover and sent to prison. It's 1949, and Andy doesn't have the stuff for prison life. Andy befriends \"Red\" Redding (Morgan Freeman) and uses his past as a banker to get a job in the prison library."},
            new MovieViewModel { Id = 4, Name = "The Notebook", Rating = "5", ReleaseYear = 2004, Genre = "Drama/Romance", Description = "The Notebook is an achingly tender story about the enduring power of love, a story of miracles that will stay with you forever. Set amid the austere beauty of coastal North Carolina in 1946, The Notebook begins with the story of Noah Calhoun, a rural Southerner returned home from World War II."},
            new MovieViewModel { Id = 5, Name = "Notting Hill", Rating = "5", ReleaseYear = 1999, Genre = "Romance/Comedy", Description = "The story is of a romance between a British bookseller (Grant) and a famous American actress (Roberts) who happens to walk into his shop in London's Notting Hill district. Released on 21 May 1999, Notting Hill was well received by critics and became the highest-grossing British film of all time." },
            new MovieViewModel { Id = 6, Name = "Enola Holmes", Rating = "5", ReleaseYear = 2020, Genre = "Mystery/Crime", Description = "In the film, Enola travels to London to find her missing mother but ends up on a thrilling adventure, pairing up with a runaway lord as they attempt to solve a mystery that threatens the entire country. In addition to Brown, the film also stars Sam Claflin, Henry Cavill, and Helena Bonham Carter." },
            new MovieViewModel { Id = 7, Name = "Barbie", Rating = "4", ReleaseYear = 2023, Genre = "Comedy/Fantasy", Description = "Set in the colorful Barbie Land, stereotypical Barbie lives a perfect life every single day. One day, she shows signs of being a human. She decides to go to the Real World to find the cure in order to make herself perfect again." },
            new MovieViewModel { Id = 8, Name = "Past Lives", Rating = "5", ReleaseYear = 2023, Genre = "Drama/Romance", Description = "Starring Greta Lee, Teo Yoo, and John Magaro, the film follows the relationship between two childhood friends over the course of 24 years, as they contemplate their relationship when they grow apart to have different lives. The plot is semi-autobiographical and inspired by real events from Song's life." },
            new MovieViewModel { Id = 9, Name = "Tin & Tina", Rating = "4", ReleaseYear = 2023, Genre = "Horror/Thriller", Description = "Parents need to know that Tin & Tina is a Spanish horror film about two cheerful, malevolent, and religiously zealous orphans who kill a dog and a child when adopted by a well-meaning but clueless couple." },
            new MovieViewModel { Id = 10, Name = "Spirited Away", Rating = "5", ReleaseYear = 2001, Genre = "Fantasy/Adventure", Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches and spirits, a world where humans are changed into beasts." },
            new MovieViewModel { Id = 11, Name = "Mean Girls", Rating = "5", ReleaseYear = 2004, Genre = "Comedy/Teen", Description = "The plot centers on naïve teenage girl Cady Heron (Lohan) navigating her way through the social hierarchy of a modern American high school after years' homeschooling by her parents while they conducted research in Africa. Saturday Night Live creator Lorne Michaels produced the film." },
            new MovieViewModel { Id = 12, Name = "Corpse Bride", Rating = "5", ReleaseYear = 2005, Genre = "Family/Musical", Description = "When a shy groom practices his wedding vows in the inadvertent presence of a deceased young woman, she rises from the grave assuming he has married her." },
            new MovieViewModel { Id = 13, Name = "Midnight Runners", Rating = "5", ReleaseYear = 2017, Genre = "Action/Comedy", Description = "Two friends who are students at Korean National Police University, find themselves in an endless race against time after they witness a kidnapping and decide to use their knowledge." },
            new MovieViewModel { Id = 14, Name = "The Devils Wear Prada", Rating = "5", ReleaseYear = 2006, Genre = "Drama/Comedy", Description = "The Devil Wears Prada is a 2003 novel by Lauren Weisberger about a young woman who is hired as a personal assistant to a powerful fashion magazine editor, a job that becomes nightmarish as she struggles to keep up with her boss's grueling schedule and demeaning demands." },
            new MovieViewModel { Id = 15, Name = "One More Chance", Rating = "5", ReleaseYear = 2007, Genre = "Romance/Drama", Description = "The film tells a love story between Popoy and Basha who are lovers since their college days and they became a couple. Suddenly, as they try to maintain their relationship, they have misunderstandings to each other due to their ambitions in life." }

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


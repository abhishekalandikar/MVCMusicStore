﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }

        //
        // GET: /Store/ => Dummy data
       // public ActionResult Index()
        //{
          //  var genres = new List<Genre>
            //{
              //  new Genre { Name = "Disco"},
                //new Genre { Name = "Jazz"},
                //new Genre { Name = "Rock"}
            //};
            //return View(genres);
        //}
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("Albums")
            .Single(g => g.Name == genre);
            return View(genreModel);


        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);

        }

        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }




    }
}
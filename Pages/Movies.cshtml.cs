using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesDatabase.Interfaces;
using MoviesDatabase.Models;

namespace MoviesDatabase.Pages
{
    public class MoviesModel : PageModel
    {
        

        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
        }
    }
}

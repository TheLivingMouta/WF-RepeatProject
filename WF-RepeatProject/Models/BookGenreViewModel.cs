using Microsoft.AspNetCore.Mvc.Rendering;

namespace WF_RepeatProject.Models;

    public class BookGenreViewModel
    {

        public List<Book>? Books { get; set;}
        public SelectList? Categories { get; set; }
        public string? BookCategory { get; set; }
        public string? SearchString { get; set; }

    }


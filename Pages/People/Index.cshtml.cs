using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Meetup.Data;
using Meetup.Models;

namespace Meetup.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly Meetup.Data.MeetupContext _context;

        public IndexModel(Meetup.Data.MeetupContext context)
        {
            _context = context;
        }



        public IList<Person> Person { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Interests { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PersonInterest { get; set; }

        public async Task OnGetAsync()
        {
            //Person = await _context.Person.ToListAsync();

            /*var people = from m in _context.Person
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                people = people.Where(s => s.Title.Contains(SearchString));
            }

            Person = await people.ToListAsync();*/

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Person
                                            orderby m.Interest
                                            select m.Interest;

            var people = from m in _context.Person
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                //people = people.Where(s => s.FirstName.Contains(SearchString));
                people = people.Where(s => s.FirstName.Contains(SearchString)
                                            || s.LastName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(PersonInterest))
            {
                people = people.Where(x => x.Interest == PersonInterest);
            }
            Interests = new SelectList(await genreQuery.Distinct().ToListAsync());
            Person = await people.ToListAsync();




        }
    }
}

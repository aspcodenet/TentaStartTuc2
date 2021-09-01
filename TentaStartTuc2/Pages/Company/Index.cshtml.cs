using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TentaStartTuc2.Data;

namespace TentaStartTuc2.Pages.Company
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
       

        public class CompanyListItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public List<CompanyListItem> Items { get; set; } = new List<CompanyListItem>();


        public void OnGet()
        {
            Items = _context.Companies.Select(s => new CompanyListItem
            {
                Id = s.Id,
                Name = s.Namn
            }).ToList();
        }

    }
}

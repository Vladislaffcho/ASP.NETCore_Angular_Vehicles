using System.Collections.Generic;
using System.Threading.Tasks;
using ASP.NET_Core_Angular_4.Controllers.Resources;
using ASP.NET_Core_Angular_4.Models;
using ASP.NET_Core_Angular_4.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Angular_4.Controllers
{
    public class MakesController : Controller
    {
        private readonly CoreAngularDbContext context;
        private readonly IMapper mapper;
        public MakesController(CoreAngularDbContext context, IMapper mapper)

        {
            this.mapper = mapper;
            this.context = context;
        }
        
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
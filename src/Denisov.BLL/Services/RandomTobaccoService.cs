using Denisov.Common.Interfaces;
using Denisov.DAL;
using Denisov.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Denisov.BLL.Services
{
    public class RandomTobaccoService: IRandomTobacco
    {
        private readonly DenisovDbContext _context;

        public RandomTobaccoService(DenisovDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Tobacco> GetRandom()
        {
            var tobaccos = await _context.Tobaccos.ToListAsync();
            var random = new Random();
            int index = random.Next(tobaccos.Count);
            return tobaccos[index];
        }
    }
}

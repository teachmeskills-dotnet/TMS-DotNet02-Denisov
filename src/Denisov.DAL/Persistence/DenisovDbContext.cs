using Denisov.DAL.Entities;
using Denisov.DAL.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Denisov.DAL
{
    /// <summary>
    /// Application DB context.
    /// </summary>
    public class DenisovDbContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Data base set of firms.
        /// </summary>
        public DbSet<Firm> Firms { get; set; }

        /// <summary>
        /// Data base set of mixes.
        /// </summary>
        public DbSet<Mix> Mixes { get; set; }

        /// <summary>
        /// Data base set of profiles.
        /// </summary>
        public DbSet<Profile> Profiles { get; set; }

        /// <summary>
        /// Data base set of saved mixes.
        /// </summary>
        public DbSet<SavedMix> SavedMixes { get; set; }

        /// <summary>
        /// Data base set of saved tobaccos.
        /// </summary>
        public DbSet<SavedTobacco> SavedTobaccos { get; set; }

        /// <summary>
        /// Data base set of tobaccos.
        /// </summary>
        public DbSet<Tobacco> Tobaccos { get; set; }

        /// <summary>
        /// Data base set of tobacco mixes.
        /// </summary>
        public DbSet<TobaccoMix> TobaccoMixes { get; set; }

        /// <summary>
        /// Define application DB context.
        /// </summary>
        /// <param name="options">Options of DB context.</param>
        public DenisovDbContext(DbContextOptions<DenisovDbContext> options) :
            base(options)
        {

        }

        public DenisovDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

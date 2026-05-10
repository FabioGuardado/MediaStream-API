using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto.Domain.Entities.Identity;
using Proyecto.Domain.Entities.Media;
using Proyecto.Infrastructure.Identity;

namespace Proyecto.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<AppIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();

        public DbSet<Role> Roles => Set<Role>();

        public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

        public DbSet<MediaItem> Media => Set<MediaItem>();

        public DbSet<Video> Videos => Set<Video>();

        public DbSet<Audio> Audios => Set<Audio>();

        public DbSet<Category> Categories => Set<Category>();

        public DbSet<Playlist> Playlists => Set<Playlist>();

        public DbSet<PlaylistMedia> PlaylistMedia => Set<PlaylistMedia>();

        public DbSet<Favorite> Favorites => Set<Favorite>();

        public DbSet<WatchHistory> WatchHistories => Set<WatchHistory>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationDbContext).Assembly
            );
        }
    }
}

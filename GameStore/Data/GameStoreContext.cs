using System;
using GameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) :DbContext(options)
{
    public DbSet<Game> game => Set<Game>();
    public DbSet<Genre> genre => Set<Genre>();

}

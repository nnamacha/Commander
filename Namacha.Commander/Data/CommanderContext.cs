using Microsoft.EntityFrameworkCore;
using Namacha.Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Namacha.Commander.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt): base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}

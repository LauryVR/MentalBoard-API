using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalBoard_API.Contexts
{
    public class MentalBoardContext : DbContext
    {
        public MentalBoardContext(DbContextOptions<MentalBoardContext> options)
            : base(options)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace AynesNotesApp.DataBaseContext
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}

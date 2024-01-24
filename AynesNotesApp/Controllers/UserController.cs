using AynesNotesApp.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace AynesNotesApp.Controllers
{
    public class UserController
    {
        private readonly ApplicationContext _context;

        public UserController(ApplicationContext context)
        {
            _context = context;
        }
    }
}

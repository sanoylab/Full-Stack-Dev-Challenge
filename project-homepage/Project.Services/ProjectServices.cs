using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Services
{
    public class ProjectServices : IProject
    {
        private readonly ProjectAppDbContext _context;

        public ProjectServices(ProjectAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Data.Models.Project> GetAll()
        {
            return _context.Projects;
        }

        public Data.Models.Project GetById(int id)
        {
            return _context.Projects.FirstOrDefault(proj => proj.Id == id);
        }
    }
}

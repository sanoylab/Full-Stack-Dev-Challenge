using System;
using System.Collections.Generic;
using System.Text;


namespace Project.Data
{
    public interface IProject
    {
        public IEnumerable<Project.Data.Models.Project> GetAll();
        public Project.Data.Models.Project GetById(int id);
    }
}

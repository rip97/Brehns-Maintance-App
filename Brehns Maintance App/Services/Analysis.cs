using Brehns_Maintance_App.Data;
using Brehns_Maintance_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brehns_Maintance_App.Services
{
    public class Analysis
    {
        private readonly ApplicationDbContext _context;

        private List<Project> completed;

        private List<Project> incomplete;

        public List<Project> Completed { get { return completed; } }

        public List<Project> Incomplete { get { return incomplete; } }

        public Analysis(ApplicationDbContext context)
        {
            _context = context;
            GetCompletedStatus();
        }

        private void GetCompletedStatus()
        {
            var projects = _context.Projects.ToList();
            foreach(var project in projects)
            {
                if(project.Complete == true)
                {
                    completed.Add(project);
                }
                else
                {
                    incomplete.Add(project);
                }
            }
        }
    }
}

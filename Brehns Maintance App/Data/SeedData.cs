using Brehns_Maintance_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brehns_Maintance_App.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any projects.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
                new Project{Priorty="Medium", Amount=200, Description="Install Fan in Bedroom", Complete=false},
                new Project{Priorty="Medium", Amount=200, Description="Install Fan in Guest Bed", Complete=false},
                new Project{Priorty="Medium", Amount=50, Description="Mount TV w/plug and hood plates", Complete=false},
                new Project{Priorty="Medium", Amount=0, Description="Patch and paint living room", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="replace plugs in kitchen", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="Replace GFI's in Bathrooms", Complete=false},
                new Project{Priorty="High", Amount=50, Description="Nail Baseboards better", Complete=false},
                new Project{Priorty="Medium", Amount=50, Description="Redo all caulking ", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="Replace all plugs and switches in Bed", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="Replace all plugs and switches in Guest Bed", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="Fix Leaky bathroom sink", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="Fix leaky toliets", Complete=false},
                new Project{Priorty="Low", Amount=300, Description="Retile Master Bath", Complete=false},
                new Project{Priorty="Medium", Amount=300, Description="Replace Bathroom sinks", Complete=false},
                new Project{Priorty="Low", Amount=50, Description="No lox breaker panel", Complete=false},
                new Project{Priorty="High", Amount=100, Description="Paint Ceilings", Complete=false},
                new Project{Priorty="Low", Amount=100, Description="Fix Kitchen Light", Complete=false},


            };
            foreach (var project in projects)
            {
                context.Projects.Add(project);
            }
            context.SaveChanges();
        }
    }
}

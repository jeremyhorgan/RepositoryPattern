using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    internal class ScenarioRepository : Repository<Scenario>, IScenarioRepository
    {
        public ScenarioRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Scenario> GetScenariosForName(string name)
        {
            return Context.Set<Scenario>().Where(item => item.Name.StartsWith(name));
        }
    }
}

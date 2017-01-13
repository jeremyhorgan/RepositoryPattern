using System.Collections.Generic;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    internal interface IScenarioRepository : IRepository<Scenario>
    {
        IEnumerable<Scenario> GetScenariosForName(string name);
    }
}

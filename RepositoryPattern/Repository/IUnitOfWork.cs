using System;

namespace RepositoryPattern.Repository
{
    internal interface IUnitOfWork : IDisposable
    {
        IScenarioRepository Scenarios { get; }

        int Complete();
    }
}

using System;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly Lazy<IScenarioRepository> _scenariosRepository;

        public UnitOfWork(DbContext context)
        {
            _context = context;

            _scenariosRepository = new Lazy<IScenarioRepository>(() => new ScenarioRepository(_context));
        }

        public IScenarioRepository Scenarios => _scenariosRepository.Value;

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
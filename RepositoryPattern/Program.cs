using System;
using RepositoryPattern.Model;
using RepositoryPattern.Repository;

namespace RepositoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            var context = new AppDBContext();
            context.Database.EnsureCreated();

            using (var unitOfWork = new UnitOfWork(context))
            {
                for (var scenarioNumber = 0; scenarioNumber < 10; scenarioNumber++)
                {
                    unitOfWork.Scenarios.Add(new Scenario()
                    {
                        Name = $"Scenario {scenarioNumber}",
                        CreateDate = DateTime.Now,
                        Replications = 10
                    });
                }

                unitOfWork.Complete();
            }
        }
    }
}

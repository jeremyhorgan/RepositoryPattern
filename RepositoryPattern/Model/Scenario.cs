using System;

namespace RepositoryPattern.Model
{
    public class Scenario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Replications { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

using System.Collections.Generic;

namespace BestMerge.Entity
{
    public class TfsProject
    {
        public string ProjectId { get; set; }

        public string DisplayName { get; set; }

        public string ProjectUri { get; set; }

        public List<TfsBranch> Branches { get; set; }

        public List<string> Contributors { get; set; }
    }
}
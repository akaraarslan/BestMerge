using System.Collections.Generic;

namespace BestMerge.Entity
{
    public class TfsBranch
    {
        public string DisplayName { get; set; }

        public List<TfsBranch> ChildBranches { get; set; }
    }
}
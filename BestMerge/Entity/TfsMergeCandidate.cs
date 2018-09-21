using System;

namespace BestMerge.Entity
{
    public class TfsMergeCandidate
    {
        public int ChangesetId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Owner { get; set; }

        public string Comment { get; set; }
    }
}
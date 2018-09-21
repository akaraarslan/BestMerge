using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMerge.Entity
{
    public class TfsProjectCollection
    {
        public string InstanceId { get; set; }

        public string DisplayName { get; set; }

        public List<TfsProject> TeamProjects { get; set; }
    }
}

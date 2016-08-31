using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contracts;

namespace Models
{
    public class Court : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacilityId { get; set; }

        public Facility Facility { get; set; }
        public ICollection<CourtTime> CoutTimes { get; set; } = new List<CourtTime>();
    }
}

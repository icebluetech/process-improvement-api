using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class InnovationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Widget { get; set; }
        public User Owner { get; set; }
        public string Date { get; set; }

        public static IEnumerable<InnovationModel> Create(IEnumerable<Innovation> innovations)
        {
            var temp = new List<InnovationModel>();
            foreach (var innovation in innovations)
            {
                temp.Add(new InnovationModel
                {
                    Id = innovation.Id,
                    Title = innovation.Title,
                    Type = innovation.InnovationType.Name,
                    Widget = innovation.Widget.Name,
                    Owner = innovation.InnovationUsers.Where(u => u.UserRoleId == 4).Single().User,
                    Date = innovation.Date.ToString("y")
                });
            }
            return temp;
        }
    }
}

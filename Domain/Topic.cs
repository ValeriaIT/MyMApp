using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Topic
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Category { get; set; } = string.Empty;
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ParentId { get; set; } = Guid.Empty.ToString();        
        public List<string> ConnectionId { get; set; } = new List<string>();
        public DateTime Date { get; set; } = DateTime.Now;
        public int Level { get; set; } = 0;
        public bool IsCancelled { get; set; } = false;
    }
}

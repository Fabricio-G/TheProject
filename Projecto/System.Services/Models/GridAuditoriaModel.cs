using System.Collections.Generic;

namespace System.Services.Models
{
    public class GridAuditoriaModel
    {
        public int TotalRows { get; set; }
        public List<AuditoriaModel> AuditoriaList { get; set; }
    }
}

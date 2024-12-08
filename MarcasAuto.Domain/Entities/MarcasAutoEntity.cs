using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcasAuto.Domain.Entities
{
    public class MarcasAutoEntity
    {
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Make { get; set; } = string.Empty;
    }
}

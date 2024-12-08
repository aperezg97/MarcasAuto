using MarcasAuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcasAuto.Infraestructure.Seeds
{
    public static class MarcasSeed
    {
        public static MarcasAutoEntity[] Items = [
            new MarcasAutoEntity { Id = "8901d8dd-24b0-4f56-a523-6d6694b9a4ac", Make = "Toyota" },
            new MarcasAutoEntity { Id = "91de0725-5e4d-49af-b63d-1dfc6b7699c9", Make = "Ford" },
            new MarcasAutoEntity { Id = "ff5425c0-ed1d-422d-ad1d-47a1e5f8b8f1", Make = "Chevrolet" }
        ];
    }
}

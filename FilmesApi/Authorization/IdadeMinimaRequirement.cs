using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Authorization
{
    public class IdadeMinimaRequirement : IAuthorizationRequirement
    {
        public int IdadeMinima { get; set; }

        public IdadeMinimaRequirement(int idadeMinima)
        {
            IdadeMinima = idadeMinima;
        }
    }
}

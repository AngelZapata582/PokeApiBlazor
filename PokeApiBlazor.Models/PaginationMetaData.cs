using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Models
{
    public class PaginationMetaData
    {
        public int CurrentPage { get; set; } = 1; //pagina actual
        public int TotalCount { get; set; } //total de registros
        public int TotalPages { get; set; } //total de paginas
        public bool HasPrevious => CurrentPage > 1; //habilita la pagina anterior si la pagina actual es mayor a 1 
        public bool HasNext => CurrentPage < TotalPages;//habilita la siguiente pagina si la pagina actual es menor al total de paginas
    }
}

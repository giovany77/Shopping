using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name="Pais")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener maximo {1} caracteres.")] //tamaño maximo de caracteres, evitamos que se cree con max
        [Required(ErrorMessage ="El campo {0} es obligatorio.")] //para que no sea nulo
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public class Psychologist
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome requerido")]
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "CRP requerido")]
        [Display(Name = "CRP")]
        public int CRP { get; set; }

        public bool Liberado { get; set; }

        [Required(ErrorMessage = "Endereço requerido")]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set;}

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser User { get; set; }
    }
}

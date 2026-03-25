using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.ViewModels
{

    /// <summary>
    /// dados das fotografias
    /// </summary>
    public class PhotosDTO
    {

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome associado à fotografia
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Descrição (opcional) da fotografia
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Nome do ficheiro que contém a fotografia
        /// </summary>

        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// nome da categoria da fotografia
        /// </summary>
        public string Category { get; set; } = "";

    }

}

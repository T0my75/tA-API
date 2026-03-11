using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models{

    /// <summary>
    /// objetos a serem vendidos na loja
    /// </summary>

    public class Photography{

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome associado à fotografia
        /// </summary>

        public string Title { get; set; }

        /// <summary>
        /// Descrição (opcional) da fotografia
        /// </summary>

        public string Discription { get; set; }

        /// <summary>
        /// Nome do ficheiro que contém a fotografia
        /// </summary>

        public string File { get; set; }

        /// <summary>
        /// Data em que a fotografia foi tirada
        /// </summary>

        public DateTime Date { get; set; }

        /// <summary>
        /// Preço da venda da fotografia
        /// </summary>

        public decimal Price { get; set; }

        /*********************
         * Relacionamentos 1-N
         *********************/

        /// <summary>
        /// FK para a categoria da fotografia
        /// </summary>

        [ForeignKey(nameof(Category))]

        public int CategoryFk { get; set; }

        /// <summary>
        /// Categoria da fotografia
        /// </summary>

        public Category Category { get; set; }

        /*********************
         * Relacionamentos N-M
         *********************/

        /// <summary>
        /// Lista de compras associadas à fotografia
        /// </summary>

        public ICollection<Purchase> ListOfPurchase { get; set; }


    }
}

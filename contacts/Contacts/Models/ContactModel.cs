using System;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class ContactModel
    {
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Nascimento
        /// </summary>
        [Required]
        public DateTime Nascimento { get; set; }

        /// <summary>
        /// Sexo
        /// </summary>
        [Required]
        public string Sexo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Data.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public double Strenght { get; set; }
        [Required]
        public double Agility { get; set; }
        [Required]
        public double Intelligence { get; set; }
        [Required]
        public double Range { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public double Health { get; set; }
        [Required]
        public double Mana { get; set; }
        [Required]
        public double Damage { get; set; }
    }
}

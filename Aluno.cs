using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIWEB
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [StringLength(35)]
        public string descricao { get; set; }

        [StringLength(35)]
        public string curso { get; set; }

        public float nota1 { get; set; }
        public float nota2 { get; set; }
    }
}

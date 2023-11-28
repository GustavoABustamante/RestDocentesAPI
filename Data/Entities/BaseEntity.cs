using System.ComponentModel.DataAnnotations;

namespace RestDocentesAPI.Data.Entities
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}

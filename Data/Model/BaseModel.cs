using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}

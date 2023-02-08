using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }


        // For the nav property City, use the property CityId as foreign key
        [ForeignKey("CityId")] // not necessary. By convention, indicatin a property with the name of the entity + Id will be enough for EF to know what property corresponds to he entity's foreign key.
        public City? City { get; set; }
        public int CityId { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}

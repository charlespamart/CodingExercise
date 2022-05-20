using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace CodingExercise;

public class MyEntityData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string name { get; set; }
    
    public string FirstName { get; }
    
    public object[] Adresse { get; set; }
}
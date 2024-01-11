using System.ComponentModel.DataAnnotations;

public class Prioridades{
  
  [Key]

public int PrioridadId { get; set; }
[Required(ErrorMessage = "Este campo es nesesario")]
public string Descricion { get; set; } = string.Empty;
[Required(ErrorMessage = "Este campo es nesesario")]
public int DiasCompromiso{ get; set; } 


}
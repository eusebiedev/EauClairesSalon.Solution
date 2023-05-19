namespace HairSalon.Models
{
  public class Client // remember restaurants is akin to Items , edit properties below as per project
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int StylistId { get; set; }
    public Stylist stylist { get; set; }
  }
}
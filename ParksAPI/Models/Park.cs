namespace ParksAPI.Models {
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string Type { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Feature { get; set; }
  }
}
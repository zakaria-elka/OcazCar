namespace OcazAPI.Services.OffreAPI.Models.Dto
{
    public class OffreDto
    {
       
        public int OffreId { get; set; }
        
        public string OffreCarName { get; set; }

        public double Price { get; set; }
        public string DatePub { get; set; }
        public string Ville { get; set; }
        public int AgentId { get; set; }
        public int CarId { get; set; }
        public Object AgentCar { get; set; }
        public Object Car { get; set; }

    }
}

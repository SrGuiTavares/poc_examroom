using CarDealer.Domain.Model.Base;

namespace CarDealer.Domain.Model
{
    public class Car : BaseModel
    {
        public decimal Price { get; set; }
        public string Imagem { get; set; }
    }
}

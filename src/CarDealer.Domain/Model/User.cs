using CarDealer.Domain.Model.Base;

namespace CarDealer.Domain.Model
{
    public class User : BaseModel
    {
        public string Password { get; set; }
    }
}

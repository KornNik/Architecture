
namespace Task1
{
    public class Customer: EntityBase
    {
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator) : base(idGenerator)
        {

        }
    }
}
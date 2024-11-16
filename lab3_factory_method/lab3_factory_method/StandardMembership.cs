namespace lab3_factory_method
{
    internal class StandardMembership : MembershipInterface
    {
        private readonly string _name;
        private readonly string _duration;
        private readonly decimal _price;

        public StandardMembership(decimal price)
        {
            _name = "Standard Membership";
            _duration = "1 Month";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public string Duration => _duration;

        public decimal GetPrice() => _price;
    }
}

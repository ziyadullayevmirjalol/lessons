namespace OOPencapsulation.encapsulation
{
    internal class Bank
    {
        // field
        private decimal balance;
        // property
        // public decimal AccessBalance { get; set; }

        // Encapsulation
        public decimal AccessBalance { get { return balance; } set { balance = value; } }
    }

}

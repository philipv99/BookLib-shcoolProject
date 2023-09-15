namespace BookLib
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


        public Book(string name, int price)
        {
            Id = 0;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"the book: {Name}. cost: {Price}";
        }

        public void ValidateName()
        {
            if (Name == null || Name == string.Empty)
            {
                throw new ArgumentNullException("name is null or empty");
            }
            if (Name.Count() < 4)
            {
                throw new ArgumentException("name of book is to short");
            }
        }

        public void ValidatePrice() 
        {
            if (Price < 0 || Price >= 1200)
            {
                throw new ArgumentOutOfRangeException("price is not between 0 & 1200");
            }
        }
    }
}
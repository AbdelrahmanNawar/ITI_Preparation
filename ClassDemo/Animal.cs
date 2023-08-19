namespace ClassDemo
{
    public  class Animal
    {
        public static int Count { get; set; }
        static Animal()
        {
            hello();
        }
        public Animal()
        {

        }
        public Animal(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }

        protected string ASD { get; set; }

        private static void hello()
        {
            Console.WriteLine("you are using the static constructor");
            Count = 1_000;
        }
        public virtual string ConvertObjectToString()
        {
            return "sdffsdfdsfdsfdsfsdfds";
        }
    }
}

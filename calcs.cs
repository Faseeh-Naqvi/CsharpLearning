namespace calc {

    public class calcs
    {
        public string model;
        private int age;
        public calcs(string model, int age)
        {
            this.model = model;
            this.age = age;
        }
        public int Square(int n)
        {
            return n * n;
        }

        public string booleanCheck(string n)
        {
            if (n == "1" || n == "0")
            {
                if (n == "1") { return "True"; }
                else { return "False"; }
            }
            else
            {
                return "invalid input";
            }
        }

        public string info()
        {
            return $"{this.model}--> model {this.age}--> age of calculator ";
    }
}
}
namespace calc {

    public static class calcs{
    public static int Square(int n) {
        return n * n;
    }

    public static string booleanCheck(string n) {
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
}
}
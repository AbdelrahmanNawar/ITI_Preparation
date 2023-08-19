namespace ClassDemo
{
    public static class MathBase
    {
        public static double pi  = 3.14;
        public static int div(int x, int y) => x / y;
        public static int mul(int x, int y) => x * y;
        public static int sub(int x, int y) => x - y;
        public static int sum(int x, int y) => x + y;
        public static double CalculateCircleArea(int r) => pi * r * r;
        
    }
}
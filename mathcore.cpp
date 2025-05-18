class mathcore
{
    public:mathcore();
    double shoot(double x, double y)
    {
        return x*y;
    }
    double shoorrh(double x, double y)
    {
        return (x*(2-x))*y;
    }
    double shoorrw(double x, double y)
    {
        return x*(y*(2-y));
    }
    double shoorrb(double x, double y)
    {
        return (x*(2-x))*(y*(2-y));
    }
};
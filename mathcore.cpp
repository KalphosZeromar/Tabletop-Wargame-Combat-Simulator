class mathcore
{
    public:mathcore();

    double shoot(double x, double y)
    {
        return x*y;
    }
    double shootrrh(double x, double y)
    {
        return (x*(2-x))*y;
    }
    double shootrrw(double x, double y)
    {
        return x*(y*(2-y));
    }
    double shootrrb(double x, double y)
    {
        return (x*(2-x))*(y*(2-y));
    }
};
using System;
using System.Numerics;


public class Rsa
{
	public Rsa()
	{
	}
    private int p;
    private int q;
    private int n;
    private int N;
    private int e;
    private int d;
    
    public int gdc(int a, int b)
    {
        int c = 0;
        while ((a%b)!=0)
        {
            c = a % b;
            a = b;
            b = c;
        }
        int gcd = c;
        return gcd;
    }

    public double Gen_PublicKey(double P, double Q)
    {
        double n = P * Q;
        for (int i = 0; i<3; i++)
        {
            
        }
    }
    public void Gen_PrivateKey()
    {

    }
    public void Encyrpt()
    {

    }
    public void Decyrpt()
    {

    }
    static public void Main(String[] args)
    {
        Console.WriteLine(gcd(3768,1701).ToString());
    }
}

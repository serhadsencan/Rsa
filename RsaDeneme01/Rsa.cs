using System;
using System.Numerics;



public class Rsa
{

    private BigInteger n;
    private BigInteger N;
    private BigInteger e;
    private BigInteger d;
    private BigInteger[] cipher;
    public string cipherText;
    public string plainText;
    private byte[] last;

    public Rsa()
    {

    }


    ////////
    public int gcd(int a, int b)
    {
        int gcd = 0;
        while ((a % b) != 0)
        {
            gcd = a % b;
            a = b;
            b = gcd;
        }
        return gcd;
    }
    ///////
    public int mod(int sayi, int taban)
    {
        int mod = 0;
        int c = sayi / taban;
        mod = sayi - (taban * c);

        return mod;
    }
    public void Test(BigInteger P, BigInteger Q)
    {
        n = BigInteger.Multiply(P, Q);
        Console.WriteLine(n);
    }


    public void Gen_PublicKey(BigInteger P, BigInteger Q)
    {
        n = BigInteger.Multiply(P,Q);
        N = BigInteger.Multiply((P - 1), (Q - 1));

         Console.WriteLine("n == "+ n+ "  N == "+ N);
         
        for (int i = 3; i < N; i++)
        {
            if (BigInteger.GreatestCommonDivisor(i,N) == 1)
            {
                e = i;
                 Console.WriteLine("E == " + e);
                break;
            }

        }


    }

    public void Encyrpt(byte[] m)
    {
        
        
            cipher = new BigInteger[m.Length];

            last = new byte[m.Length];


        for (int i = 0; i < m.Length; i++)
        {

            //for (int j = 0; j < e; j++)
            //{
            //    temp = mod(temp * Convert.ToInt32(m[i]), n);
            //    cipher[i] = temp;
            //}
            cipher[i] = BigInteger.ModPow(m[i], e, n);

            last[i] = (Byte)BigInteger.ModPow(cipher[i], 1, 256);
            Console.WriteLine(cipher[i]);

            }

            cipherText = System.Text.Encoding.UTF8.GetString(last);

        
        
    }

    public void Gen_PrivateKey()
    {
        d = 0;
        //while (mod((e * d), N) != 1)
        //{
        //    d++;
        //}
        while (BigInteger.ModPow(BigInteger.Multiply(e,d),1,N) != 1)
        {
            d++;
        }
        Console.WriteLine("d::::"+d);    }



    public void Decyrpt()
    {
        try
        {
           
            BigInteger[] tempArr = new BigInteger[last.Length];


            for (int i = 0; i < last.Length; i++)
            {

                //for (int j = 0; j < d; j++)
                //{
                //    temp = mod(temp * Convert.ToInt32(cipher[i]), n);

                //    tempArr[i] = temp;

                //}
                tempArr[i] = BigInteger.ModPow(cipher[i],d,n);
                

                last[i] = (Byte)BigInteger.ModPow(tempArr[i],1,256);
            }
            plainText = System.Text.Encoding.UTF8.GetString(last);


        }
        catch (Exception)
        {
            plainText = "Girilen asalsayı çok büyük";
        }

    }

}

using System;




public class Rsa
{

    private int n;
    private int N;
    private int e;
    private int d;
    private int[] cipher;
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


    public void Gen_PublicKey(int P, int Q)
    {
        n = P * Q;
        N = (P - 1) * (Q - 1);
        // Console.WriteLine("n == "+ n+ "  N == "+ N);
        //  Console.WriteLine("e ::::"+e.ToString());
        for (int i = 3; i < N; i++)
        {
            if (gcd(i, N) == 1)
            {
                e = i;
                // Console.WriteLine("E == " + e);
                break;
            }

        }


    }

    public void Encyrpt(byte[] m)
    {
        try
        {
            cipher = new int[m.Length];

            last = new byte[m.Length];
            int temp = 1;

            for (int i = 0; i < m.Length; i++)
            {

                for (int j = 0; j < e; j++)
                {
                    temp = mod(temp * Convert.ToInt32(m[i]), n);
                    cipher[i] = temp;
                }

                last[i] = Convert.ToByte(mod(cipher[i], 256));
                temp = 1;

            }

            cipherText = System.Text.Encoding.UTF8.GetString(last);

        }
        catch (Exception)
        {
            cipherText = "Girilen asalsayı çok büyük";
        }
    }

    public void Gen_PrivateKey()
    {
        d = 0;
        while (mod((e * d), N) != 1)
        {
            d++;
        }
    }



    public void Decyrpt()
    {
        try
        {
            int temp = 1;
            int[] tempArr = new int[last.Length];


            for (int i = 0; i < last.Length; i++)
            {

                for (int j = 0; j < d; j++)
                {
                    temp = mod(temp * Convert.ToInt32(cipher[i]), n);

                    tempArr[i] = temp;

                }
                temp = 1;

                last[i] = Convert.ToByte(tempArr[i] % 256);
            }
            plainText = System.Text.Encoding.UTF8.GetString(last);


        }
        catch (Exception)
        {
            plainText = "Girilen asalsayı çok büyük";
        }

    }

}

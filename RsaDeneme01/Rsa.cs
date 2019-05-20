using System;




public class Rsa
{
   
    private int n;
    private int N;
    private int e;
    private int d;
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
        while ((a%b)!=0)
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
         N = (P-1) * (Q-1);
        Console.WriteLine("n == "+ n+ "  N == "+ N);
        Console.WriteLine("e ::::"+e.ToString());
        for (int i = 3; i < N; i++)
        {
            if (gcd(i, N) == 1)
            {
                e = i;
                Console.WriteLine("E == " + e);
                break;
            }

        }


    }

    public void Encyrpt(byte[] m)
    {
        int[] cipher = new int[m.Length];
        
        last = new byte[m.Length];
        int temp = 1;
      
        for (int i = 0; i < m.Length; i++)
        {
            
            for (int j = 0; j < e; j++)
            {
                temp = mod(temp * Convert.ToInt16(m[i]),n);
                cipher[i] = temp;
                //Console.WriteLine("Cipher1 :"+m[i].ToString());
            }
            last[i] = Convert.ToByte(mod(cipher[i], n));
            
           
            mod(last[i],n);
            //Console.WriteLine("Last ::" + last[i]);
            //Console.WriteLine("mod == "+ mod(cipher[i],n).ToString());
            temp = 1;

        }

        cipherText = System.Text.Encoding.UTF8.GetString(last);
        Console.WriteLine(cipherText);
        
    }

    public void Gen_PrivateKey()
    {
        d = 0;
        while (mod((e*d),N)!=1)
        {
            d++;
        }
        Console.WriteLine("DDDDDD::::"+d.ToString());
        
    }

    ///    47458321         47,458,246‬

    public void Decyrpt()
    {
        int temp = 1;
        int[] tempArr = new int[last.Length];
        char[] tempchar = new char[last.Length];
       
        for (int i = 0; i < last.Length; i++)
        {
            
            for (int j=0; j<d;j++)
            {
                temp = mod(temp * Convert.ToInt16(last[i]),n);
                Console.WriteLine("temp  ::"+ temp+"  ::"+i.ToString());
                tempArr[i] = temp;
                
                //Console.WriteLine("tempppp:: "+temp.ToString()+" i :"+i.ToString());
            }
            temp = 1;
            last[i] = Convert.ToByte(tempArr[i]);
        }
        plainText = System.Text.Encoding.UTF8.GetString(last);
        //plainText = new String(tempchar);

       
    }
    
}

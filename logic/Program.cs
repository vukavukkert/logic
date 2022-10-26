Console.WriteLine("x y z w f");
for (int x1 = 0; x1 < 2; x1++)
{
    bool x = Convert.ToBoolean(x1);
    for (int y1 = 0; y1 < 2; y1++)
    {
        bool y = Convert.ToBoolean(y1);
        for (int z1 = 0; z1 < 2; z1++)
        {
            bool z = Convert.ToBoolean(z1);
            for (int w1 = 0; w1 < 2; w1++)
            {
                bool w = Convert.ToBoolean(w1);
                bool f = ((!z | w) & !(!x == y)) || (y & z);
                if (f == false)
                {
                    Console.WriteLine($"{w1} {y1} {z1} {w1} {f}");
                }              
            }          
        }      
    }
}

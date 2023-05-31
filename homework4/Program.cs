namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[6];
            for (int i = 0; i < humans.Length; i++)
            {
                humans[i] = Human.Input(i);
            }
            for (int i = 0; i < humans.Length; i++) 
            {
                humans[i].Output();
            }
            for(int i = 0;i < humans.Length; i++)
            {
                if (humans[i].Age() < 16)
                {
                    humans[i].ChangeName("Very young");
                }
            }
            for (int i = 0; i < humans.Length; i++)
            {
                humans[i].Output();
            }
            for (int i = 0 ; i < humans.Length ; i++)
            {
                for (int j = i + 1; j < humans.Length; j++)
                {
                    if (humans[i] == humans[j])
                    {
                        Console.WriteLine($"{humans[i].Name} and {humans[j].Name} are equals");
                    }
                    else
                    { Console.WriteLine($"Humans are not equals"); }
                }
            }
        }
    }
}
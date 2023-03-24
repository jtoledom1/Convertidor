internal class Program
{
    private static void Main(string[] args)
    {
        bool repeat = true;
       
        while (repeat == true)
        {
        #region all
        int Entrada =0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int p6 = 0;
            int p7 = 0;
            int p8 = 0;

        Console.Write("Introduce el valor requerido: ");
        Entrada = int.Parse(Console.ReadLine());
        Console.Write("\n");
        while (Entrada >= 256) 
        {
            Console.WriteLine("Introduce un valor menor de 256");
            Console.Write("Reintroduce el valor requerido: ");
            Entrada = int.Parse(Console.ReadLine());
        }
           
            while (Entrada>0) 
            {
                #region ifs
                int rj = 0;
               
                rj = Entrada;
                if (rj >= 128)
                {

                    rj = rj - 128;
                    p1 = 1;
                }
                else
                {
                    p1 = 0;
                }

                if (rj >= 64)
                {
                    rj = rj - 64;
                    p2 = 1;
                }
                else
                {
                    p2 = 0;
                }
                if (rj >= 32)
                {
                    rj = rj - 32;
                    p3 = 1;
                }
                else
                {
                    p3 = 0;
                }

                if (rj >= 16)
                {
                    rj = rj - 16;
                    p4 = 1;
                }
                else
                {
                    p4 = 0;
                }
                if (rj >= 8)
                {
                    rj = rj - 8;
                    p5 = 1;
                }
                else
                {
                    p5 = 0;
                }
                if (rj >= 4)
                {
                    rj = rj - 4;
                    p6 = 1;
                }
                else
                {
                    p6 = 0;
                }
                if (rj >= 2)
                {
                    rj = rj - 2;
                    p7 = 1;

                }
                else
                {
                    p7 = 0;
                }
                if (rj >= 1)
                {
                    rj = rj - 1;
                    p8 = 1;
                }
                else
                {
                    p8 = 0;
                }
                #endregion
                Entrada = rj;
            }
        Console.WriteLine($" \nLa conversión es:"+p1+p2+p3+p4+p5+p6+p7+p8+"\n");
        
            #endregion
            #region terminar
            string Ext = "";
            Console.WriteLine("Deseas Salir? (y/n)");
            Ext= Console.ReadLine();
            
            while (Ext != "Y" && Ext != "N" && Ext != "y" && Ext != "n")
            {
                Console.WriteLine("Introduce la opción correcta: ");
                Ext = Console.ReadLine();
            }
            if (Ext=="Y"||Ext=="y") { Console.WriteLine("Seleccionaste Salir"); Console.ReadLine(); Console.Clear(); repeat = false; } else { Console.WriteLine("Seleccionaste continuar");Console.ReadLine();Console.Clear();}

            #endregion
        }
        Console.Clear();
        
    }
}
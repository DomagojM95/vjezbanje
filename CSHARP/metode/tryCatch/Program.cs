


int ucitajBroj()
{


    while (true)
    {
        Console.Write("unesi broj");

        try
        {
            return int.Parse(Console.ReadLine());

        }


        catch (FormatException e)
        {
            Console.WriteLine("ne moze");

        }
        catch (OverflowException)
        {
            Console.WriteLine("ne pretjeruj");
        }

        catch (Exception)
        {
            Console.WriteLine("oops nesto nije dobro");
        }
        finally
        {

        }
    }

}

int i=ucitajBroj();
int j=ucitajBroj();

Console.WriteLine(i+j);



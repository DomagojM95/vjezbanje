

using e03jednaksotobjekata;

var s = "osijek";

var n = "osijek";


Console.WriteLine(s==n);
Console.WriteLine(s.Equals(n));

Grad g1 = new Grad { 

    naziv="osijek"
};

Grad g2 = new Grad 
{
    naziv="osijek"
};

Console.WriteLine(g1==g2);
Console.WriteLine(g1.Equals(g2));

Console.WriteLine(g1.GetHashCode());
Console.WriteLine(g2.GetHashCode());

using System;
using System.Security.Cryptography.X509Certificates;

class ObandCl
{
    public string name = "Know";
    public int id;

    public ObandCl()
    {
        System.Console.WriteLine("Enter You ID");
    }
    
    public void PlayerId(string name,int id)
    {
        this.name = name;
        this.id = id;

        System.Console.WriteLine(name + id);
        
    }
    static void Main()
    {
        ObandCl p1 = new ObandCl();
        
        p1.id = 101;

        p1.PlayerId("ram",101);

    }
}
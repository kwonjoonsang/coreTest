using System;

namespace coreTest.CStudy
{
    public class DeveloperOveride
    {
        public override string ToString()
        {
            return "Developer";
        }
    }

    public class WebDeveloper : DeveloperOveride
    {
        public override string ToString() => "Web Developer";
    }

    public class MobileDeveloper : DeveloperOveride
    {
        public override string ToString() => "Mobile Developer";
    }
    
    static void Main()
    {
        var web = new WebDeveloper();
        Console.WriteLine(web);

        var mobile = new MobileDeveloper();
        Console.WriteLine(mobile);
    }
}
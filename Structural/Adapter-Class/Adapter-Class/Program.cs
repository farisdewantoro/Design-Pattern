using System;

namespace Adapter_Class
{
    public class GetDataClass
    {
        public virtual string GetData()
        {
            return "GetData Method called";
        }
    }

    public class NewGetDataClass
    {
        public virtual string NewGetData()
        {
            return "NewGetData Method called";
        }
    }

    public class GetDataAdapter : NewGetDataClass
    {
        public string GetData()
        {
            return this.NewGetData();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            GetDataAdapter obj1 = new GetDataAdapter();
          
            Console.WriteLine(obj1.GetData());
            //You can still use the GetDataClass as shown below
            GetDataClass obj2 = new GetDataClass();
            Console.WriteLine(obj2.GetData());
            Console.Read();
        }
    }

}

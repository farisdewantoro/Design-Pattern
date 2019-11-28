using System;

namespace Adapter_Object
{
 
        // This is the class which provides the functionalities and used by the client.
        public class GetDataClass
        {
            public virtual string GetData()
            {
                return "GetData Method called";
            }
        }
        // Adaptee: The NewGetDataClass contains the functionality which the client desires 
        // but its method signature is not compatible with the existing client code. 
        // The NewGetDataClass needs some adaptation before the client code can use it.
        public class NewGetDataClass
        {
            public virtual string NewGetData()
            {
                return "NewGetData Method called";
            }
        }
        // Adapter: This is the class which makes the NewGetDataClass class compatible with the client
        // interface which the client wants to call.
        public class GetDataAdapter : GetDataClass
        {
            private NewGetDataClass newGetDataObject = new NewGetDataClass();
            public override string GetData()
            {
                return newGetDataObject.NewGetData();
            }
        }

        // The Client class
        public class Program
        {
            static void Main(string[] args)
            {
                // The GetDataAdapter class is compatible with the client code.
                // So, the client will use the GetDataAdapter instance to call functionality 
                // of Adaptee (NewGetDataClass) class
                GetDataAdapter obj1 = new GetDataAdapter();
                Console.WriteLine(obj1.GetData());
    
                //You can still use the GetDataClass as shown below
                GetDataClass obj2 = new GetDataClass();
                Console.WriteLine(obj2.GetData());
                Console.Read();
            }
        }

    
}

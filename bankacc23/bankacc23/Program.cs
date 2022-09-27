namespace bankacc23
{
    abstract class account
    {
        public abstract void display1();
    }
       class bankaccount : account
        {
            double aadhaarno;
        public void link()
            {
                Console.WriteLine("enter the aadhar no");
                aadhaarno= Convert.ToDouble(Console.ReadLine());
            }
            public override void display1()
            {
                Console.WriteLine("Account linked");
            }
           
      
                static void Main(string[] args)
                {

                    account acc = new bankaccount();
                    acc.display1();
                    acc.link();
                    
                }
                    
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Core;
using Axceligent.BusinessCore;
using System.Collections;
using Axceligent.Factory;
using Axceligent.Interface;



namespace Axceligent
{
    class Program
    {
        static void Main(string[] args)
        {


            IEnumerable<IHuman> HumanList = HumanFactory.CreatePersonList();

          //   ManipulateHumn(HumanList);
            int[] num = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };

         //   int[] num = { 1, 2, 1, 5, 5, 3, 3,5,7,7,7,3, 4,6,7,2,2};

           // int[] num = { 1, 6,1,2,6,1,6,6};


            //int sum
          //BiggestNeighbor(num);
            BuildHouse();
          //AskAlexa();
          //ProcessUser();
          //JohnRobot();
            Console.ReadLine();

        }


        public static void ManipulateHumn(IEnumerable<IHuman> hl)
        {

            //foreach (var p in hl)
            //    Console.WriteLine(p.FirstName + "," + p.LastName + " as " + p.Gender + " with age " + p.Age);

            Console.Write("Total number of person" +  hl.Count() +"\n\n");
            //hl = hl.Where(x => x.Age > 24).OrderBy(x=>x.Age).ToList();

            //Console.WriteLine(" Start displaying filtered output \n");

            foreach (var p in hl)
                Console.WriteLine(p.FirstName + "," + p.LastName + " as " + p.Gender + " with age " + p.Age);

            Console.WriteLine("\n ");

            var gb = from s in hl
                     group s by s.Age;

                     

            Console.WriteLine("Max of count ="+ gb.Max(g => g.Count()));

            Console.WriteLine("Sum of count =" + gb.Sum(g => g.Count()));


            foreach (var g in gb)
                Console.WriteLine(g.Key + " - " + g.Count() +" - "+ g.Sum(x=>x.Age));



        }
        
          public static void BiggestNeighbor(int[] input)
          {

        
            Console.Write("[");
            foreach (var i in input)
            {
                Console.Write(i + " ");
            }
            Console.Write("] \n");


     
            Console.WriteLine("SUM = " + input.Sum() +"\n");

            ArrayList TO = new ArrayList();

             
            var gb = input.GroupBy(x => x).OrderBy(x=>x.Key);

            int maxcount = gb.Max(x => x.Count());
            int displaycount = maxcount - 1;

            Console.WriteLine("maximum count by group  =" + gb.Max(x => x.Count()));

            var dict = new List<int>();

            foreach (IGrouping<int, int> g in gb)
            {
                Console.WriteLine("value =" + g.Key + "  " + "Sum =" +  g.Sum() + " Count=" + g.Count());

                if (g.Count() >= displaycount)
                    dict.Add(g.Key);

            }
            
            Console.WriteLine("\n");
            foreach (var d in dict)
                Console.WriteLine("number to be displayed ="+ d.ToString());

            Console.WriteLine("\n");

            Console.Write("start outputing filtered array => "+"[");
            foreach (var i in input)
            {
                if (checkdisplayvalue(dict, i))
                {
                    TO.Add(i);
                    Console.Write(i + " ");
                }
            }

            Console.Write("] \n");

           Console.WriteLine("Biggest Sum of adjacent neighbor = " + CalculateSum(TO) );         
              
        }

        public  static int CalculateSum(ArrayList FinalList)
        {
            int biggestSum = 0;

            for (int i = 0; i < FinalList.Count; i++)
            {

                if (i != FinalList.Count - 1)
                {

                    if (biggestSum < Convert.ToInt16(FinalList[i]) + Convert.ToInt16(FinalList[i + 1]))
                    {
                        biggestSum = Convert.ToInt16(FinalList[i]) + Convert.ToInt16(FinalList[i + 1]);
                    }
                }
            } 
            return biggestSum;



        }
        public static bool checkdisplayvalue(IList<int> input, int n)
        {
            bool result = false;

            for (var i = 0; i < input.Count(); i++)
                if (input[i].Equals(n))
                     result =true;

            return result;


        }

        public static void BuildHouse()
        {
            var myhouse = new Building().AddKitchen().AddBedRoom("master").AddBedRoom("Guest").AddBalcony();

            myhouse.Build();

            Console.WriteLine(myhouse.Describe());
            /*******************************************/

            myhouse.AddKitchen().AddBedRoom("Another");

            Console.WriteLine(myhouse.Describe());

            /*******************************************/
            myhouse.Build();

            Console.WriteLine(myhouse.Describe());

            Console.WriteLine("Please press any key to continue....");
            
        }


      
        public static void AskAlexa()
        {
            var alexa = new Alexa();
             Console.WriteLine(alexa.Talk());
            

            alexa.Configure(x =>
            {
                x.greetingmessage = "Hello {ownername}, I'm at your service";
                x.ownername = "Bob Markey";
            }
            );

            Console.WriteLine(alexa.Talk());

        }
        public static void ProcessUser()
        {
            while (true)
            {
                var u = new User();
                Console.WriteLine("Please enter username or Q to exit");
                var username=  Console.ReadLine();
                if (username == "q")
                    break;

                u.Add(username);
                Console.WriteLine("number of add user is "+ u.GetUsersCount());
                Console.WriteLine("Static variable :" + User._userlist.Count());

            }
        }
        public static void JohnRobot()
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill());

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());


        }

    }
}

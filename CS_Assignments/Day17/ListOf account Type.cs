using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day17
{
    public class Account
    {
        public string AccName { get; set; }
        public List<Customer> customers = new List<Customer>();
    }
    public class Customer
    {
        public string Name { get; set; }

        public List<Lone> Lones = new List<Lone>();


    }
    public class Lone
    {
        public string LoneName { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {

            List<Account> Accounts = new List<Account>()
            {
                new Account
                {
                    AccName="Saving",
                    customers=
                    {
                     new Customer
                        {
                            Name="Customer 1",
                            Lones=
                            {
                                new Lone{ LoneName="Home Lone"},
                                new Lone{LoneName="Car Lone"},

                            }
                        },
                        new Customer
                        {
                            Name="Customer 2",
                            Lones=
                            {
                                new Lone{LoneName="Home Lone",},
                            }
                        },
                        new Customer
                        {
                            Name="Customer 3",
                            Lones=
                            {
                                new Lone{LoneName="Gold Lone"},
                                new Lone{LoneName="Car Lone"},

                            }
                        },

                    }
                },
                new Account
                {
                    AccName="Current",
                    customers=
                    {
                        new Customer
                        {
                            Name="Customer 1",
                            Lones=
                            {
                                new Lone{LoneName="Education Lone",},
                                new Lone{LoneName="Two Wheeler Lone"}
                            }
                        },
                        new Customer
                        {
                            Name="Customer 2",
                            Lones=
                            {
                                new Lone{LoneName="Car Lone",},
                            }
                        },
                        new Customer
                        {
                            Name="Customer 3",
                            Lones=
                            {
                                new Lone{LoneName="Gold Lone",},
                                new Lone{LoneName="Car Lone"},
                            }
                        },
                        new Customer
                        {
                            Name="Customer 4",
                            Lones=
                            {
                                new Lone
                                {
                                    LoneName="Business Lone",
                                },
                                new Lone{LoneName="Home Lone"}


                            }
                        },


                    }
                },

            };
            Console.WriteLine("Account Type:");
            foreach (Account a in Accounts)
            {
                Console.WriteLine($"{a.AccName}");
                foreach (Customer c in a.customers)
                {
                    Console.WriteLine($"\t{c.Name}");
                    foreach (Lone lone in c.Lones)
                    {
                        Console.WriteLine($"\t\t{lone.LoneName}");
                    }
                }

            }


        }
    }
}

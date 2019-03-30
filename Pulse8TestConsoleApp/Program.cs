using Autofac;
using AutoMapper;
using ConsoleTables;
using Pulse8TestConsoleApp.Data;
using Pulse8TestConsoleApp.Model;
using Pulse8TestConsoleApp.Service;
using System;
using System.Linq;

namespace Pulse8TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var memberService = container.Resolve<MemberService>();
            Mapper.Initialize(cfg => cfg.CreateMap<SelectMemberCategories_Result, MemberCategory>());
            Console.WindowWidth = Console.LargestWindowWidth - 15;


            while (true)
            {
                Console.WriteLine("\nPlease enter a Member ID:");
                int memberId;
                if (int.TryParse(Console.ReadLine(), out memberId))
                {
                    var memberRecords = memberService.GetMemberCategories(memberId);

                    if(memberRecords.Any())
                    {
                        ConsoleTable.From<MemberCategory>(memberRecords).Write();
                    }
                    else
                    {
                        Console.WriteLine("No records found for the given Member ID");
                    }
                }
                else
                {
                    Console.WriteLine("Only numeric values are valid");
                }

                Console.WriteLine("Would you like to try again? (y/n)");
                var key = Console.ReadKey();
                if (key.KeyChar == 'n')
                {
                    break;
                }
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MemberRepository>().As<IMemberRepository>();
            builder.RegisterType<MemberService>();
            builder.RegisterType<Pulse8TestDBEntities>();
            return builder.Build();
        }
    }
}

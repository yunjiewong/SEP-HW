using System;
namespace Assignment2
{
	public class Parsing
	{
        public Parsing(){
            // var str = Console.ReadLine();
            var str = "www.apple.com";
            string[] protocol = str.Split("://");
            string next = "";
            if ( protocol.Length == 1 ){
                Console.WriteLine(@"[protocol] = """"");
                next = protocol[0];
            }else if(protocol[0] == ""){
                Console.WriteLine(@"[protocol] = """"");
                next = protocol[1];
            }
            else{
                Console.WriteLine("[protocol] = "+ protocol[0]);
                next = protocol[1];
            }
                string[] server = next.Split("/");
                if (server.Length > 1){
                    if (server[0] == ""){
                            Console.WriteLine("Wrong input");
                    }else{
                        Console.WriteLine("[server] = "+ server[0]);
                        Console.WriteLine("[resource] = "+ server[1]);
                    }
                }else{
                    Console.WriteLine("[server] = "+ server[0]);
                    Console.WriteLine(@"[resource] = """ );
                

            }

        }
    }
}
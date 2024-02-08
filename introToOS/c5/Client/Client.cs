// Copyright 2024 Lev Zitron
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetExClient{

    public class Client{
        const int BUFFER_SIZE = 1024;
        private string _hostName = "myHost";

        public Client(string hostName = "localhost"){
            _hostName = hostName;
        }

        public void Start(){
            byte[] byteList = new byte[BUFFER_SIZE];

            // Get IP address
            IPHostEntry host = Dns.GetHostEntry( _hostName );
            IPAddress hostip = host.AddressList[0];
            var localEndPoint = new IPEndPoint( hostip, 11000 ); // Port 11000

            try{
                // connect to remote server
                // create a socket, bind a port
                var sender = new Socket(
                    hostip.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                );
                sender.Connect( localEndPoint );

                // create a message to send
                byte[] msg = Encoding.ASCII.GetBytes("This is the message<EOF>");

                // send the message
                int bytesSent = sender.Send( msg );
                int bytesRead = sender.Receive( byteList );

                Console.WriteLine($"Received: {Encoding.ASCII.GetString( byteList )}");

                // clean up and exit

                sender.Shutdown( SocketShutdown.Both );
                sender.Close();
            }
            catch (Exception e){
                Console.WriteLine(e);
            }
        }

    }
}
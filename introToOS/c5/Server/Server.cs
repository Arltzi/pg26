// Copyright 2024 Lev Zitron
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetExServer{
    public class Server{
        private bool _done = false;
        private string _hostName = "myHost";

        const int MAX_REQUESTS = 10;
        const int BUFFER_SIZE = 1024;

        public Server(string hostName = "localhost"){
            _hostName = hostName;
        }

        public void Start(){
            // Get IP address
            IPHostEntry host = Dns.GetHostEntry( _hostName );
            IPAddress hostip = host.AddressList[0];
            Console.WriteLine(host.AddressList);
            var localEndPoint = new IPEndPoint( hostip, 11000 ); // Port 11000
            try
            {
                // create a socket using tcp to listen
                var listener = new Socket(
                    hostip.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                // bind the socket to an IP:port
                listener.Bind( localEndPoint );

                // put some limits on the server
                listener.Listen( MAX_REQUESTS );

                // wait for data
                Console.WriteLine("Listener set up, waiting for connection");
                Socket handler = listener.Accept();

                string msg = HandleIncomingData( handler );
                Console.WriteLine($"Received: {msg}");

                // shut down socket connection clearly
                string clientMsg = "bye bye now";
                byte[] msgForClient = Encoding.ASCII.GetBytes( clientMsg );
                handler.Send( msgForClient );
                handler.Shutdown( SocketShutdown.Both );
                handler.Close();
            }
            catch ( Exception e )
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }

        private string HandleIncomingData( Socket handler )
        {
            // Handle incoming data
            string data = "";
            byte[] byteList = new byte[BUFFER_SIZE];

            while (!_done){
                int bytesRead = handler.Receive( byteList );
                data += Encoding.ASCII.GetString( byteList, 0, bytesRead );
                if(data.IndexOf("<EOF>") > -1){
                    _done = true;
                }
            }
            return data;
        }
    }
}
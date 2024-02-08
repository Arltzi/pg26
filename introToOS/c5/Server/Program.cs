// Copyright 2024 Lev Zitron
using System;

namespace NetExServer{
    class Program{
        public static int Main()
        {
            var server = new Server();
            server.Start();

            return 0;
        }
    }
}
// Copyright 2024 Lev Zitron
using System;

namespace NetExClient{
    public class Program{
        public static int Main(){
            var client = new Client();
            client.Start();

            return 0;
        }
    }
}
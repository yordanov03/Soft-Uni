﻿using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            var progressInfo = new StreamProgressInfo(new File("my file",100,1000));
            var progressInfo1 = new StreamProgressInfo(new Music("Lili Ivanova", "vetrove", 5,13));
            
        }
    }
}

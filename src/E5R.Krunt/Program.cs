/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;

namespace E5R.Krunt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("E5R.Krunt running [without features]...");
            for(var a = 0; a < args.Length; a++){
                var line_ = String.Format("   arg[{0}] = {1}", a, args[a]);
                Console.WriteLine(line_);
            }
            Console.Write("Press any key to exit");
            Console.Read();
        }
    }
}

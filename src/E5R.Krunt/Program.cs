/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;
using System.Collections.Generic;
using Microsoft.Framework.DependencyInjection;
using E5R.Krunt.Services;
using E5R.Krunt.ServiceImplementations;

namespace E5R.Krunt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var provider_ = new KruntServiceContainer().GetProvider();

            var engine_ = provider_.GetService<IKruntEngine>();
            var engineType_ = engine_.GetType().ToString();

            var logger_ = provider_.GetService<IKruntLogger>();
            var loggerType_ = logger_.GetType().ToString();

            var settings_ = provider_.GetService<IKruntSettings>();
            var settingsType_ = settings_.GetType().ToString();

            Console.WriteLine("E5R.Krunt running [without features]...");
            Console.WriteLine("Registered types:");
            Console.WriteLine(string.Format("     IKruntEngine: {0}", engineType_));
            Console.WriteLine(string.Format("     IKruntLogger: {0}", loggerType_));
            Console.WriteLine(string.Format("     IKruntSettings: {0}", settingsType_));

            for(var a = 0; a < args.Length; a++){
                var line_ = String.Format("arg[{0}] = {1}", a, args[a]);
                Console.WriteLine(line_);
            }
            Console.Write("Press any key to exit");
            Console.Read();
        }
    }
}

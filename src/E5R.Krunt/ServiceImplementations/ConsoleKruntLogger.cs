/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;
using E5R.Krunt.Services;

namespace E5R.Krunt.ServiceImplementations
{
    public class ConsoleKruntLogger : IKruntLogger
    {
        public void Info(string message)
        {
            Console.WriteLine(string.Format("INFO: {0}", message));
        }

        public void Warning(string message)
        {
            Console.WriteLine(string.Format("WARNING: {0}", message));
        }

        public void Error(string message)
        {
            Console.WriteLine(string.Format("ERROR: {0}", message));
        }
    }
}

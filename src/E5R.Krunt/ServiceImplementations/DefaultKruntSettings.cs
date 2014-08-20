/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;
using E5R.Krunt.Services;

namespace E5R.Krunt.ServiceImplementations
{
    public class DefaultKruntSettings : IKruntSettings
    {
        private IKruntLogger logger;

        public IKruntLogger Logger {
            get
            {
                return this.logger;
            }
        }

        public DefaultKruntSettings(IKruntLogger logger)
        {
            this.logger = logger;
        }
    }
}

/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;
using System.Collections.Generic;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.DependencyInjection.Fallback;
using E5R.Krunt.Services;
using E5R.Krunt.ServiceImplementations;

namespace E5R.Krunt.ServiceImplementations
{
    public class KruntServiceContainer
    {
        public IServiceProvider GetProvider()
        {
            return DefaultServices().BuildServiceProvider();
        }

        private IEnumerable<IServiceDescriptor> DefaultServices()
        {
            var describer = new ServiceDescriber();

            yield return describer.Transient<IKruntEngine, DefaultKruntEngine>();
            yield return describer.Transient<IKruntLogger, ConsoleKruntLogger>();
            yield return describer.Transient<IKruntSettings, DefaultKruntSettings>();
        }
    }
}

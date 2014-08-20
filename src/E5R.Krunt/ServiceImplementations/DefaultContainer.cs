/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;
using System.Collections.Generic;
using E5R.Krunt.Services;
using E5R.Krunt.ServiceImplementations;

namespace E5R.Krunt.ServiceImplementations
{
    public class DefaultContainer : IKruntContainer
    {
        private IList<Type> registered_ = new List<Type>();

        public void Register(Type type, Object instance)
        {
        }
    }
}

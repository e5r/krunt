/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using Xunit;

namespace E5R.Krunt.Tests
{
    public class Program
    {
        [Fact]
        public void Test()
        {
            int a = 2;
            int b = 2;

            Assert.Equal(a, b);
        }
    }
}

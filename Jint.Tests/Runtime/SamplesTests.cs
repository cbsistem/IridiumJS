﻿using System;
using Xunit;

namespace IridiumJS.Tests.Runtime
{
    public class SamplesTests : IDisposable
    {
        private readonly JSEngine _engine;

        public SamplesTests()
        {
            _engine = new JSEngine()
                .SetValue("log", new Action<object>(Console.WriteLine))
                .SetValue("assert", new Action<bool>(Assert.True))
                ;
        }

        void IDisposable.Dispose()
        {
        }

        private void RunTest(string source)
        {
            _engine.Execute(source);
        }

        [Fact]
        public void GithubReadme1()
        {
            var square = new JSEngine()
                .SetValue("x", 3)
                .Execute("x * x")
                .GetCompletionValue()
                .ToObject();

            Assert.Equal(9d, square);
        }
    }
}

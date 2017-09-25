using System;
using Xunit;
using Application1;


namespace Tests
{



    public class UnitTest1
    {
        [Fact]
        public void SinglePlayerRegistration()
        {

            Program player = new Program();
            Assert.True(player.DoSomething());
        }
    }

}

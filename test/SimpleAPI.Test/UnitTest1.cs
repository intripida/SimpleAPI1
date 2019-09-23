using System;
using Xunit;
using SimpleAPI.Controllers; //directiva que hace referencia al folder controladores 


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController(); //object "Values Controller"
        [Fact] //atribute - Test Method unit test type
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Seguros del Estado", returnValue.Value);
        }



        [Fact]
        public void Test1()
        {

        }
    }
}

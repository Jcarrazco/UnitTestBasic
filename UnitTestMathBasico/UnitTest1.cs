using System;
using Calculadora_Unit_Tested;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestMathBasico
{
    [TestClass]
    public class UnitTestOperaciones
    {
        [TestMethod]//colocar [TestMethod] para poder ser identificado como test
        public void TestMethodAdd()
        {
            //Arrange Organiza los valores que puede tener y regresar
            MathOp Mo = new MathOp();
            double Result;
            //Act      ejecuta las acciones de los metodos
            Result = Mo.Add(20, 30);
            //Assert    
            Assert.AreEqual(50, Result);// Varifica (Valor esperado, valor actual)
            
        }

        [TestMethod]
        public void TestMethodSubstract()
        {
            //Arrange
            MathOp Mo = new MathOp();
            double Result;
            //Act
            Result = Mo.Substract(20, 30);
            //Assert
            Assert.AreEqual(-10, Result);
        }

        [TestMethod]
        public void TestMethodMultiply()
        {
            //Arrange
            MathOp Mo = new MathOp();
            double Result;
            //Act
            Result = Mo.Multiply(20, 30);
            //Assert
            Assert.AreEqual(600, Result);
        }

        [TestMethod]
        public void TestMethodDivide()
        {
            //Arrange
            MathOp Mo = new MathOp();
            double Result;
            //Act
            Result = Mo.Divide(100, 10);
            //Assert
            Assert.AreEqual(10, Result);
        }
    }
}

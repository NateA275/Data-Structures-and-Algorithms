using System;
using Xunit;
using Multi_Bracket_Validation;
using Multi_Bracket_Validation.Classes;

namespace BracketTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("[]")]
        [InlineData("()")]
        [InlineData("{}")]
        [InlineData("")]
        [InlineData("No Brackets at all.")]
        public void MultiBracetValidationReturnsTrue(string input)
        {
            //Act
            bool response = Program.MultiBracketValidation(input);

            //Assert
            Assert.True(response);
        }


        [Theory]
        [InlineData("[)")]
        [InlineData("(}")]
        [InlineData("{]")]
        public void MultiBracetValidationReturnsFalse(string input)
        {
            //Act
            bool response = Program.MultiBracketValidation(input);

            //Assert
            Assert.False(response);
        }


        [Theory]
        [InlineData("String[i].ToArray();", true)]
        [InlineData("Method9).isFalse();", false)]
        [InlineData("ToIntArray[].Object}{", false)]
        public void CharsDoNotEffectAlgo(string input, bool expected)
        {
            //Act
            bool response = Program.MultiBracketValidation(input);

            //Assert
            Assert.Equal(expected, response);
        }
    }
}

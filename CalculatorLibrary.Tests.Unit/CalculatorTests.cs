﻿using TestingTechniques;

namespace CalculatorLibrary.Tests.Unit
{
	public class CalculatorTests
	{
		private readonly Calculator _sut = new();
		[Theory]
		[InlineData(5, 5, 10)]
		[InlineData(-5, 5, 0)]
		[InlineData(-15, -5, -20)]
		public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers(
		  int a, int b, int expected)
		{
			//Act
			var result = _sut.Add(a, b);
			//Assert
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(5, 5, 0)]
		[InlineData(15, 5, 10)]
		[InlineData(-5, -5, 0)]
		[InlineData(-15, -5, -10)]
		[InlineData(5, 10, -5)]

		public void Subtract_ShouldSubtractTwoNumbers_whenTwoNumbersAreIntegers(
		  int a, int b, int expected)
		{
			//Act
			var result = _sut.Subtract(a, b);
			//Assert
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(5, 5, 25)]
		[InlineData(50, 0, 0)]
		[InlineData(-5, 5, -25)]

		public void Multiply_ShouldMultiplyTwoNumbers_whenTwoNumbersAreIntegers(
		  int a, int b, int expected)
		{
			//Act
			var result = _sut.Multiply(a, b);
			//Assert
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(5, 5, 1)]
		[InlineData(15, 5, 3)]
		public void Divide_ShouldDivideTwoNumbers_whenTwoNumbersAreIntegers(
		  int a, int b, float expected)
		{
			//Act
			var result = _sut.Divide(a, b);
			//Assert
			Assert.Equal(expected, result);
		}
	}

}


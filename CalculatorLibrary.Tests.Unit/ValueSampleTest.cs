using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTechniques;

namespace CalculatorLibrary.Tests.Unit
{
	public class ValueSampleTest
	{
		private readonly  ValueSamples _sut = new();
		[Fact]
		public void StringAssertionExample()
		{
			string fullName = _sut.FullName;
			fullName.Should().Be("Orima Salimi");
			fullName.Should().NotBeEmpty();
			fullName.Should().StartWith("Orima");
			fullName.Should().EndWith("Salimi");

		}
		[Fact]
		public void NumberAssertionExample()
		{
			int age = _sut.Age;
			age.Should().Be(27);
			age.Should().BePositive();
			age.Should().BeGreaterThan(20);
			age.Should().BeInRange(18,60);
			age.Should().BeGreaterThanOrEqualTo(27);
			age.Should().BeLessThanOrEqualTo(30);
		}

		[Fact]
		public void DateAssertionExample()
		{
			DateOnly dateOfBirth = _sut.DateOfBirth;
			dateOfBirth.Should().Be(new (1998, 1, 28));
			dateOfBirth.Should().BeAfter(new (1990, 1, 1));
			dateOfBirth.Should().BeBefore(new (2000, 1, 1));
		}

		[Fact]	
		public void ObjectAssertionExample()
		{
			var expected = new User
			{
				Age = 27,
				FullName = "Orima Salimi",
				DateOfBirth = new(1998, 1, 28),
			};
			var user=_sut.AppUser;
			user.Should().BeEquivalentTo(expected);
		}
		[Fact]
		public void EnumrableAssertionExample()
		{
			var expected = new User()
			{
				FullName = "Orima salimi",
				DateOfBirth = new(1998, 1, 28),
			    Age	= 27,
			};

			var users = _sut.Users.As<User[]>();
			users.Should().ContainEquivalentOf(expected);
			users.Should().HaveCount(3);
			users.Should().Contain(x=>x.Age==27);
		}
	}
}

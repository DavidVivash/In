using System.Collections.Generic;
using Xunit;

namespace In.Test
{
    public class InTests
    {
        public class InParamsTests
        {
            [Fact]
            public void AnItemDoesNotExistWhenNoValuesAreSupplied()
            {
                // arrange
                int item = 1;

                // act
                var result = item.In();

                // assert
                Assert.False(result);
            }

            [Fact]
            public void AnItemDoesntExistWhenItDoesntAppearInTheSuppliedValues()
            {
                // arrange
                int item = 1;

                // act
                var result = item.In(0, 2, 3, 4);

                // assert
                Assert.False(result);
            }

            [Fact]
            public void AnItemExistsWhenItAppearsOnceInTheList()
            {
                // arrange
                int item = 1;

                // act
                var result = item.In(1, 2, 3);

                // assert
                Assert.True(result);
            }

            [Fact]
            public void AnItemExistsWhenItAppearsMoreThanOnceInTheList()
            {
                // arrange
                int item = 1;

                // act
                var result = item.In(1, 2, 3, 1);

                // assert
                Assert.True(result);
            }
        }

        public class InListTests
        {
            [Fact]
            public void AnItemDoesNotExistInANullList()
            {
                // arrange
                List<int> items = null;
                int item = 1;

                // act
                var result = item.In(items);

                // assert
                Assert.False(result);
            }

            [Fact]
            public void AnItemDoesNotExistInAnEmptyList()
            {
                // arrange
                var items = new List<int>();
                int item = 1;

                // act
                var result = item.In(items);

                // assert
                Assert.False(result);
            }

            [Fact]
            public void AnItemDoesntExistWhenItDoesntAppearInTheList()
            {
                // arrange
                var items = new List<int> { 0, 2, 3, 4 };
                int item = 1;


                // act
                var result = item.In(items);

                // assert
                Assert.False(result);
            }

            [Fact]
            public void AnItemExistsWhenItAppearsOnceInTheList()
            {
                // arrange
                var items = new List<int> { 1, 2, 3 };
                int item = 1;

                // act
                var result = item.In(items);

                // assert
                Assert.True(result);
            }

            [Fact]
            public void AnItemExistsWhenItAppearsMoreThanOnceInTheList()
            {
                // arrange
                var items = new List<int> { 1, 2, 3, 1 };
                int item = 1;

                // act
                var result = item.In(items);

                // assert
                Assert.True(result);
            }
        }

    }
}

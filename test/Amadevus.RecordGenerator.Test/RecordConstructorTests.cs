﻿using Amadevus.RecordGenerator.TestsBase;
using System;
using Xunit;

namespace Amadevus.RecordGenerator.Test
{
    public class RecordConstructorTests : RecordTestsBase
    {
        [Fact]
        public void Ctor_HasParametersNamedLikeProperties()
        {
            new Item(id: ItemId, name: ItemName);
        }

        [Fact]
        public void Ctor_InvokesValidate_Throwing()
        {
            Assert.Throws<ArgumentNullException>("name", () => new ValidatingRecord(null, "a"));
        }

        [Fact]
        public void Ctor_InvokesValidate_Passing()
        {
            Assert.NotNull(new ValidatingRecord(ItemName, "test"));
        }
    }
}

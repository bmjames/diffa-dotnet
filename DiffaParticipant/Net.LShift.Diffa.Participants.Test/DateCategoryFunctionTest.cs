﻿//
//  Copyright (C) 2011 LShift Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using NUnit.Framework;

namespace Net.LShift.Diffa.Participants.Test
{
    [TestFixture]
    class DateCategoryFunctionTest
    {
        [Test]
        public void OwningPartitionNameShouldEqualBaseOfPartitionRange()
        {
            var categoryFunction = new MonthlyCategoryFunction();
            Assert.AreEqual("2010-06", categoryFunction.OwningPartition("2010-06-05"));
        }

        [Test]
        [ExpectedException(typeof(InvalidAttributeValueException))]
        public void ShouldThrowInvalidAttributeExceptionWhenValueDoesNotParseToInteger()
        {
            var categoryFunction = new MonthlyCategoryFunction();
            categoryFunction.OwningPartition("NOT_A_DATE");
        }
    }
}

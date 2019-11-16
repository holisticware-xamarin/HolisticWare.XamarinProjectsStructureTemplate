// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Globalization;

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestContext = System.Object;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Text;

namespace UnitTests.Core_Text_CharacterSeparatedValues
{
    public partial class TestsStaticAPI
    {
        [Test()]
        public void CharacterSeparatedValues_API_static_ParseLine_01()
        {
            //-----------------------------------------------------------------------------------------
            // Arrange
            string line = "1,2,3,4,5,6,7,8,9,10,11,12,13";
            //-----------------------------------------------------------------------------------------
            // Act
            sw.Start();
            IEnumerable<string> line_parts = CharacterSeparatedValues.ParseLine
                                                                            (
                                                                                line,
                                                                                ','
                                                                            );

            sw.Reset();
            //ConsoleOutput(csv_parsed);
            //-----------------------------------------------------------------------------------------
            // Assert
            int count = line_parts.Count();
            #if NUNIT
            Assert.AreEqual(count, 13);
            #elif XUNIT
            Assert.Equal(count, 13);
            #elif MSTEST
            Assert.AreEqual(count, 13);
            #endif

            string[] line_parts_assert = new string[]
            {
                "1", "2", "3", "4", "5", "6", "7",
                "8", "9", "10", "11", "12", "13", 
            };
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            line_parts_assert.ToList(),
                            line_parts
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            line_parts_assert.ToList(),
                            line_parts
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            line_parts_assert.ToList(),
                            line_parts.ToArray()
                        );
            #endif
            //-----------------------------------------------------------------------------------------

            return;
        }

        [Test()]
        public void CharacterSeparatedValues_API_static_ParseLine_02()
        {
            //-----------------------------------------------------------------------------------------
            // Arrange
            string line = "1,2,3,4,5,6,7,8,9,10,11,12,13";
            //-----------------------------------------------------------------------------------------
            // Act
            sw.Start();
            IEnumerable<string> line_parts = CharacterSeparatedValues.ParseLine
                                                                            (
                                                                                line,
                                                                                ';'
                                                                            );

            sw.Reset();
            //ConsoleOutput(csv_parsed);
            //-----------------------------------------------------------------------------------------
            // Assert
            int count = line_parts.Count();
            #if NUNIT && !NUNIT_LITE
            Assert.AreEqual(count, 1);
            #elif XUNIT
            Assert.Equal(count, 1);
            #elif MSTEST
            Assert.AreEqual(count, 1);
            #endif

            string[] line_parts_assert = new string[]
            {
                "1,2,3,4,5,6,7,8,9,10,11,12,13"
            };
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            line_parts_assert.ToList(),
                            line_parts
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            line_parts_assert.ToList(),
                            line_parts
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            line_parts_assert.ToList(),
                            line_parts.ToArray()
                        );
            #endif
 
            //-----------------------------------------------------------------------------------------





            return;
        }


    }
}

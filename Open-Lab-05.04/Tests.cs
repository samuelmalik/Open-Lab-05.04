using System;
using System.Collections;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Open_Lab_05._04
{
    [TestFixture]
    public class Tests
    {

        private StringTools tools;

        private const int RandStrMinSize = 1;
        private const int RandStrMaxSize = 20;
        private const int RandSeed = 504504504;
        private const int RandTestCasesCount = 97;

        [OneTimeSetUp]
        public void Init() => tools = new StringTools();

        [TestCase("The quick brown fox!", "The quick brown fox")]
        [TestCase("%fd76$fd(-)6GvKlO.", "fd76fd-6GvKlO")]
        [TestCase("D0n$c sed 0di0 du1", "D0nc sed 0di0 du1")]
        [TestCaseSource(nameof(GetRandom))]
        public void RemoveSpecialCharactersTest(string str, string expected) =>
            Assert.That(tools.RemoveSpecialCharacters(str), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var arr = new char[rand.Next(RandStrMinSize, RandStrMaxSize + 1)];

                for (var j = 0; j < arr.Length; j++)
                    arr[j] = (char) rand.Next(' ', 'z' + 1);

                var str = new string(arr);
                yield return new TestCaseData(str, Regex.Replace(str, "[^a-zA-Z0-9-_ ]", ""));
            }
        }

    }
}

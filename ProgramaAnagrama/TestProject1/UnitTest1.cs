using NUnit.Framework;
using ProgramaAnagrama;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreAnagram_uno_IsNull_Throw()
        {
            Anagrama anagrama = new Anagrama();
            Assert.That(() => anagrama.AreAnagram(null, "hola"), Throws.ArgumentNullException);
        }

        [Test]
        public void AreAnagram_dos_IsNull_Throw()
        {
            Anagrama anagrama = new Anagrama();
            Assert.That(() => anagrama.AreAnagram("hola", null), Throws.ArgumentNullException);
        }


    }
}
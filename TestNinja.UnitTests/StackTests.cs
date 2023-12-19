using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<int> ints;
        private Stack<string> strings;

        [SetUp]
        public void Setup()
        {
            ints = new Stack<int>();
            strings = new Stack<string>();
        }

        [Test]
        public void Push_ObjectIsNull_ThrowNullRefrenceExeption()
        {
            Assert.That(() => strings.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_PushObjectToStack_ObjectExistInStack()
        {
            strings.Push("Ali");

            //Assert.That(strings, Is.AnyOf("Ali"));
            Assert.That(strings.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_ObjectIsEmpty_ThrowInvalidOperationException()
        {
            Assert.That(() => ints.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }
           
        
        [Test]
        public void Pop_ObjectWithSomeValue_ReturnObjectOnTop()
        {
            strings.Push("a");
            strings.Push("b");
            strings.Push("c");

            
            Assert.That(() => strings.Pop(), Is.EqualTo("c"));
        }     
        
        [Test]
        public void Pop_ObjectWithSomeValue_RemoveObjectOnTop()
        {

            strings.Push("a");
            strings.Push("b");
            strings.Push("c");

            strings.Pop();


            Assert.That(() => strings.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOprationException()
        {
            
            Assert.That(() => strings.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_ObjectWithSomeValue_ReturnObjectOnTop()
        {
            strings.Push("a");
            strings.Push("b");
            strings.Push("c");


            Assert.That(() => strings.Pop(), Is.EqualTo("c"));
        }

        [Test]
        public void Peek_ObjectWithSomeValue_DoesNotRemoveObjectOnTop()
        {

            strings.Push("a");
            strings.Push("b");
            strings.Push("c");

            strings.Peek();


            Assert.That(() => strings.Count, Is.EqualTo(3));
        }


    }
}

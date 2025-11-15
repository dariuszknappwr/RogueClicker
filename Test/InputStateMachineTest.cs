using System.Reflection;
using System.Reflection.Emit;
using Moq;

namespace test;

public class InputStateMachineTest
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Only_one_instance_of_singleton_should_exist_at_all_times()
    {
        InputStateMachine s1 = InputStateMachine.Instance;
        InputStateMachine s2 = InputStateMachine.Instance;
        Assert.That(s1, Is.SameAs(s2));
    }

    [Test]
    public void Singleton_should_not_have_public_constructors()
    {
        ConstructorInfo[] constructors = typeof(InputStateMachine).GetConstructors();
        Assert.That(constructors.Length, Is.EqualTo(0));
    }
}

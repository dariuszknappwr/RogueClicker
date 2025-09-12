using System.Reflection;
using System.Reflection.Emit;
using Moq;

namespace test;

public class KeyBindsSingletonTest
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Only_one_instance_of_singleton_should_exist_at_all_times()
    {
        KeyBindsSingleton s1 = KeyBindsSingleton.Instance();
        KeyBindsSingleton s2 = KeyBindsSingleton.Instance();
        Assert.That(s1, Is.SameAs(s2));
    }

    [Test]
    public void Singleton_should_not_have_public_constructors()
    {
        ConstructorInfo[] constructors = typeof(KeyBindsSingleton).GetConstructors();
        Assert.That(constructors.Length, Is.EqualTo(0));
    }
}

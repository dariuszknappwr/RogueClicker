using Moq;

namespace test;

public class Tests
{
    private ClickModel model;
    ClickController controller;
    ClickerView view;
    Mock<IInputReader> mockInput;
    Mock<IOutputWriter> mockOutput;

    [SetUp]
    public void Setup()
    {
        model = new();
        controller = new(model);
        mockInput = new Mock<IInputReader>();
        mockOutput = new Mock<IOutputWriter>();
        view = new(controller, mockInput.Object, mockOutput.Object);
    }

    [Test]
    public void ClickerControllerShouldHaveZeroClicksAtStart()
    {
        Assert.That(controller.GetClicks, Is.EqualTo(0));
    }

    [TestCase(1)]
    [TestCase(20)]
    public void ClickerControllerShouldAddClicks(int loops)
    {
        for (int i = 0; i < loops; i++)
        {
            controller.Click();
        }
        Assert.That(controller.GetClicks, Is.EqualTo(loops));
    }

    [Test]
    public void ClickerViewShouldPresentClicks()
    {

        Assert.That(view.GetClicks(), Is.EqualTo("0"));
        controller.Click();
        Assert.That(view.GetClicks(), Is.EqualTo("1"));
    }

    [Test]
    public void ClickerViewShouldPresentInfo()
    {
        Assert.That(view.GetInfo(), Is.Not.Empty);
    }

    [Test]
    public void ClickerShouldListenForInputs()
    {
        controller.HandleInput(KeyBindsSingleton.Instance().ClickKey());
        Assert.That(controller.GetClicks(), Is.EqualTo(1));
        controller.HandleInput(KeyBindsSingleton.Instance().BuyKey());
        Assert.That(controller.GetClicksPerSecond(), Is.EqualTo(1));
        Console.WriteLine(controller.GetClicks());
    }

    [Test]
    public void Buy_clicks_per_second_should_throw_exception_when_bought_with_non_positive_clicks_value()
    {
        Assert.That(controller.GetClicks(), Is.EqualTo(0));
        controller.HandleInput(ConsoleKey.D);
        Assert.That(controller.GetClicksPerSecond(), Is.EqualTo(0));
    }

    [Test]
    public void Run_handles_input()
    {
        Mock<IInputReader> mockInput = new Mock<IInputReader>();
        Mock<IOutputWriter> mockOutput = new Mock<IOutputWriter>();
        mockInput.SetupSequence(x => x.ReadKey())
            .Returns(ConsoleKey.C);
    }
}

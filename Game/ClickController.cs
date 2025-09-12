
public class ClickController
{
    ClickModel model;
    public ClickController(ClickModel model)
    {
        this.model = model;
    }

    public void Click()
    {
        model.clicks++;
    }

    public void BuyClickPerSecond()
    {
        
        if (GetClicks() > 1)
        {
            model.clicks -= 1;
            model.clicksPerSecond++;
        }
    }

    public int GetClicks()
    {
        return model.clicks;
    }

    public int GetClicksPerSecond()
    {
        return model.clicksPerSecond;
    }

    public void HandleInput(object key)
    {
        if (key == KeyBindsSingleton.Instance().ClickKey())
        {
            Click();
        }
        else if (key == KeyBindsSingleton.Instance().BuyKey())
        {
            BuyClickPerSecond();
        }
    }
}
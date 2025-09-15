
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
        
        if (GetClicks() > 0)
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

    public void HandleInput(InputEvent key)
    {
        if (InputStateMachine.Instance.IsClick(key))
        {
            Click();
        }
        else if (InputStateMachine.Instance.IsBuy(key))
        {
            BuyClickPerSecond();
        }
    }
}
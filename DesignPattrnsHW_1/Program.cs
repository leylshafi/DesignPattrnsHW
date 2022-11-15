namespace FactoryMethod;

public interface IButton
{
    void render();
    void OnClick();
}

public class WindowsButton : IButton
{
    public void OnClick() => Console.WriteLine("Windows button Click");
    public void render() => Console.WriteLine("Windows button Render");
}

public class HtmlButton : IButton
{
    public void OnClick() => Console.WriteLine("HTML button Click");
    public void render() => Console.WriteLine("HTML render Render");
}


public abstract class Dialog
{
    public void render()
    {
        IButton okButton = CreateButton();
        okButton.OnClick();
        okButton.render();
    }

    public abstract IButton CreateButton();
}

public class WindowsDialog : Dialog
{
    public override IButton CreateButton() => new WindowsButton();
}

public class HtmlDialog : Dialog
{
    public override IButton CreateButton() => new HtmlButton();
}

public class Program
{
    public static void Main()
    {
        Dialog dialog = new WindowsDialog();
        dialog.render();

        dialog = new HtmlDialog();
        dialog.render();
    }
}

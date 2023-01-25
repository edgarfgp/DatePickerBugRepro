namespace MauiApp2;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    
    // Entry Focused works as expected
    private void VisualElement_OnFocused(object sender, FocusEventArgs e)
    {
    }
    // Entry UnFocused works as expected
    private void VisualElement_OnUnfocused(object sender, FocusEventArgs e)
    {
    }
    // DatePicker Focused is not trigger when the keyboard appears. I did in XF
    private void VisualElement_OnFocused2(object sender, FocusEventArgs e)
    {
    }
    // DatePicker Focused is not trigger when the keyboard is hidden. I did in XF
    private void VisualElement_OnUnfocused2(object sender, FocusEventArgs e)
    {
    }
}
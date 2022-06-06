using Gtk;
using System;

namespace Game2048;
class GameOver
{
    public void GameOverWindow()
    {
        Window go = new Window(WindowType.Popup);
        Program.App.AddWindow(go);
        Program.Win.GetPosition(out int x, out int y);
        go.Move(x + (int)Math.Round(Program.Win.AllocatedWidth * 0.25), y + (int)Math.Round(Program.Win.AllocatedHeight * 0.25));
        go.SetDefaultSize((int)Math.Round(Program.Win.AllocatedWidth * 0.5), (int)Math.Round(Program.Win.AllocatedHeight * 0.5));
        var label = new Label();
        label.Markup = "<span size='35000'>Game Over</span>";
        Button gameOverBtn = new Button(label);
        gameOverBtn.Clicked += (sender, e) =>
        {
            Program.App.RemoveWindow(go);
            go.Close();
            go.Destroy(); go.Dispose();
            Program.Restart();
        };
        go.Add(gameOverBtn);
        go.ShowAll();
    }
}

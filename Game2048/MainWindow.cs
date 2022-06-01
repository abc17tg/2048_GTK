using Gtk;

namespace Game2048
{
    class MainWindow : Window
    {
        private HeaderBar headerBar;
        private Box startGameBox;
        private HPaned hpanned;

        private Button playButton;
        private Button randomButton;
        private Button quitButton;

        public BlocksManager blocksManager;

        public MainWindow() : base(WindowType.Toplevel)
        {
            // Setup GUI
            WindowPosition = WindowPosition.Center;

            headerBar = new HeaderBar();
            headerBar.ShowCloseButton = true;
            headerBar.DecorationLayout = "minimize,maximize:menu";
            headerBar.Title = "2048";
            headerBar.ShowAll();

            Titlebar = headerBar;

            hpanned = new HPaned();
            hpanned.Position = 100;

            startGameBox = new Box(Orientation.Vertical, 5);
            startGameBox.Margin = 8;
            startGameBox.Halign = Align.Center;
            startGameBox.Valign = Align.Center;
            InitStartButtons();
            startGameBox.Add(playButton);
            startGameBox.Add(randomButton);
            VPaned vPaned = new VPaned();
            vPaned.Pack1(startGameBox, false, false);
            vPaned.Pack2(quitButton, false, false);
            hpanned.Pack1(vPaned, false, false);

            blocksManager = new BlocksManager();
            hpanned.Pack2(blocksManager.grid, false, false);
            Child = hpanned;

            KeyPressEvent += blocksManager.Move;
        }

        private void InitStartButtons()
        {
            playButton = new Button();
            playButton.Label = "Play";
            playButton.Margin = 5;
            playButton.Clicked += (sender, e) => Program.Restart();

            randomButton = new Button();
            randomButton.Label = "Random";
            randomButton.Margin = 5;
            randomButton.Clicked += (sender, e) => blocksManager.Move(Utils.RandomEnumValue<BlocksManager.Direction>());

            quitButton = new Button();
            quitButton.Label = "Quit";
            quitButton.Margin = 5;
            quitButton.Clicked += (sender, e) => Application.Quit();
        }
    }
}

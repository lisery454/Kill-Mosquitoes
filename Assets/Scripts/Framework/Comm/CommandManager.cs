namespace FrameWork {
    public class CommandManager : ICanSendCommand, IBelongedToGame {
        public CommandManager(IGame belongedGame) {
            BelongedGame = belongedGame;
        }

        public void SendCommand<T>() where T : ICommand, new() {
            var command = new T {BelongedGame = BelongedGame};
            command.Execute();
        }

        public void SendCommand<T>(T command) where T : ICommand {
            command.BelongedGame = BelongedGame;
            command.Execute();
        }

        public IGame BelongedGame { get; set; }
    }
}
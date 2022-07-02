using FrameWork;

namespace KillMosquitoesGame {
    public class GameStartCmd : Command {
        protected override void OnExecute() {
            GetNode<UISystem>().OnGameStart();
        }
    }
}
using FrameWork;

namespace KillMosquitoesGame {
    public class KMGame : Game {
        protected override void Awake() {
            base.Awake();

            OnBeforeLoadScene["Game"] = () => {
                NodeManager.Register(new UISystem());
            };


            GotoScene("Game");
        }
    }
}
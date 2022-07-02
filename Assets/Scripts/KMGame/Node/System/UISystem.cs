namespace KillMosquitoesGame {
    public class UISystem : FrameWork.System {
        public override void Init() { }


        public void OnGameStart() {
            TriggerEvent<GameStartEvt>();
        }
    }
}
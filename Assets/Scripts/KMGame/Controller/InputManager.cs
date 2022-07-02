using FrameWork;
using UnityEngine;

namespace KillMosquitoesGame {
    public class InputManager : Controller {
        private bool isGameStart = false;


        private void Update() {
            if (!isGameStart && Input.anyKeyDown) {
                SendCommand<GameStartCmd>();
            }
        }
    }
}
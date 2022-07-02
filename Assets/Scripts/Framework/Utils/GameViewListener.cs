using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FrameWork {
    public class GameViewListener {
        public int LastWidth { get; private set; }
        public int LastHeight { get; private set; }

        public void ViewListenerUpdate() {
            if (LastWidth != Screen.width || LastHeight != Screen.height) {
                LastWidth = Screen.width;
                LastHeight = Screen.height;

                var sceneName = SceneManager.GetActiveScene().name;
                if (OnViewChange.ContainsKey(sceneName))
                    OnViewChange[sceneName].Invoke(LastWidth, LastHeight);
            }
        }

        //当某个场景中，分辨率改变时时启用的操作
        //先宽后高
        public readonly Dictionary<string, Action<int, int>> OnViewChange = new();
    }
}
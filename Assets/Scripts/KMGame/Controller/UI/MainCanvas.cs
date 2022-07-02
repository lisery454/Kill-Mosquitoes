using FrameWork;
using UnityEngine;
using UnityEngine.UI;

namespace KillMosquitoesGame {
    public class MainCanvas : Controller {
        [SerializeField] private Button ConfigButton;
        [SerializeField] private Button ExitButton;
        [SerializeField] private Button RecordButton;

        private Animator _animator;

        protected override void Awake() {
            base.Awake();

            _animator = GetComponent<Animator>();

            ExitButton.onClick.AddListener(() => { GotoScene("Exit"); });


            AddEventListener<GameStartEvt>(e => {
                _animator.Play("FadeUI");
            }).UnregisterWhenGameObjectDestroyed(gameObject);
        }
    }
}
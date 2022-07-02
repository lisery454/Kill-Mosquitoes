namespace FrameWork {
    public class NodeManager : IBelongedToGame, ICanGetNode, ICanRegisterNode {
        private readonly IOCContainer<INode> IocContainer = new();

        public NodeManager(IGame belongedGame) {
            BelongedGame = belongedGame;
        }

        public void Register<T>(T node) where T : class, INode {
            node.BelongedGame = BelongedGame;
            IocContainer.Add(node);
            node.Init();
        }

        public void RegisterWithoutInit<T>(T node) where T : class, INode {
            node.BelongedGame = BelongedGame;
            IocContainer.Add(node);
        }

        public void UnRegister<T>() where T : class, INode {
            IocContainer.Remove<T>();
        }

        public T GetNode<T>() where T : class, INode {
            return IocContainer.Get<T>();
        }

        public void UnRegisterAll() {
            IocContainer.RemoveAll();
        }

        public IGame BelongedGame { get; set; }
    }
}
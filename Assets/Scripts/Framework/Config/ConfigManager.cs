using System;

namespace FrameWork {
    public class ConfigManager {
        private readonly IOCContainer<IConfig> ConfigContainer = new();

        public TConfig GetConfig<TConfig>() where TConfig : class, IConfig {
            return ConfigContainer.Get<TConfig>();
        }

        public void LoadConfig<TConfig>(string path, Func<string, TConfig> Reader) where TConfig : class, IConfig {
            var config = Reader.Invoke(path);
            ConfigContainer.Add(config);
        }

        public void RemoveConfig<TConfig>() where TConfig : class, IConfig {
            ConfigContainer.Remove<TConfig>();
        }

        public void SaveConfig<TConfig>(string path, Action<string, TConfig> Writer)
            where TConfig : class, IConfig {
            Writer.Invoke(path, GetConfig<TConfig>());
        }
    }
}
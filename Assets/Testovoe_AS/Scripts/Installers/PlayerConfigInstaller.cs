using UnityEngine;
using Zenject;

namespace Testovoe_AS
{
    [CreateAssetMenu(fileName = "PlayerConfig")]
    public class PlayerConfigInstaller : ScriptableObjectInstaller<PlayerConfigInstaller>
    {
        [SerializeField] private PlayerConfig _playerConfig;

        public override void InstallBindings()
        {
            Container
                .BindInstance(_playerConfig);
        }
    }
}
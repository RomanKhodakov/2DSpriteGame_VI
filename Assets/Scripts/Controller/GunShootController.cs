namespace Test2DGame
{
    internal sealed class GunShootController
    {
        private const float SpawnTime = 1f;
        private float _currentTime;
        private readonly IBulletEmitter _bulletEmitter;

        public GunShootController(IBulletEmitter bulletEmitter)
        {
            _bulletEmitter = bulletEmitter;
        }

        public void Execute(float deltaTime)
        {
            _currentTime += deltaTime;
            if (_currentTime >= SpawnTime)
            {
                _bulletEmitter.LaunchBullet();
                _currentTime -= SpawnTime;
            }
        }
    }
}
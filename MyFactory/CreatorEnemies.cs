using System;
using UnityEngine;

namespace Assets.Scripts
{
    class CreatorEnemies : MonoBehaviour
    {
        [SerializeField] private EnemyType _enemyType;
        //[SerializeField] private float _hp;
        private IEnemyFactory _creatorEnemy;
        private void Start()
        {
            var enemy = Instantiate(Resources.Load<Enemy>(AssetPath.Enemies[EnemyType.Big]));

            switch (_enemyType)
            {
                case EnemyType.None:
                    break;
                case EnemyType.Small:
                    _creatorEnemy = new SmallEnemyFactory();
                    break;
                case EnemyType.Big:
                    _creatorEnemy = new BigEnemyFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

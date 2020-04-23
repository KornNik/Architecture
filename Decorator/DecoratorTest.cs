using UnityEngine;


namespace Decorator
{
    
    /// <summary>
    /// Добавить прицел и удалить прицел и глушитель
    /// </summary>
    public sealed class DecoratorTest : MonoBehaviour
    {

        [SerializeField] private Weapon _weapon;
        
        private void Start()
        {
            ModificationMuffler modificationMuffler = new ModificationMuffler();
            var muffler = modificationMuffler.AddModification(_weapon);

            modificationMuffler.RemoveModification(muffler);

            ModificationAim modificationAim = new ModificationAim();
            var aim = modificationAim.AddModification(_weapon);

            modificationAim.RemoveModification(aim);


        }
    }
}

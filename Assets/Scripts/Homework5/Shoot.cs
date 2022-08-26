using UnityEngine;

namespace Homework5
{
    internal sealed class Shoot : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;
        [Header("Muffler Gun")]
        [SerializeField] private AudioClip _audioClipMuffler;
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;
        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, 1.0f);
            var muffler = new Muffler(_audioClipMuffler, _volumeFireOnMuffler, _barrelPosition, _muffler);
            var weapon = new Weapon(ammunition, _barrelPosition, 300.0f, _audioSource, _audioClip);
            ModificationWeapon modificationWeapon = new ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
            modificationWeapon.ApplyModification(weapon);
            _fire = modificationWeapon;
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
        }
    }
}
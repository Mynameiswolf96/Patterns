using UnityEngine;

namespace Visitor.Scripts
{
    public class VisitorExample : MonoBehaviour
    {
        [SerializeField]
        private Camera _mainCamera;

        [SerializeField]
        private float _damage;

        [SerializeField]
        private float _dedicatedDistance;


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out var hit, _dedicatedDistance))
                {
                    if (hit.collider.TryGetComponent<Hit>(out var damage))
                    {
                        damage.Activate(new ConsoleDisplay(), new InfoCollision(_damage, hit.point, hit.normal, hit.collider.transform));
                        damage.Activate(new ApplyDamage(), new InfoCollision(_damage, hit.point, hit.normal, hit.collider.transform));
                    }
                }
            }
        }
    }
}
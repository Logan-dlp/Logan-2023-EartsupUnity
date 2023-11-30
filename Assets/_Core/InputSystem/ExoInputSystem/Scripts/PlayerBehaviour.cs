using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(InputEventButtonListener))]
public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _fireCharge;
    
    public void Shoot()
    {
        Vector3 fireInstancePosition = transform.position + transform.up;
        Instantiate(_fireCharge, fireInstancePosition, transform.rotation);
    }
}

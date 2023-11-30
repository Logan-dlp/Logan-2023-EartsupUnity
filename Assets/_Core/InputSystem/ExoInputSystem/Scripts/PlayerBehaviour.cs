using UnityEngine;

[RequireComponent(typeof(InputEventButtonListener))]
public class PlayerBehaviour : MonoBehaviour
{
    public void Shoot()
    {
        Debug.Log("Shoot !");
    }
}

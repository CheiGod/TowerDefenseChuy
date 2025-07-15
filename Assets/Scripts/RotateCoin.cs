using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationspeed = new Vector3(0, 100, 0);

    private void Update()
    {
        transform.Rotate(rotationspeed * Time.deltaTime, Space.Self);
    }
}

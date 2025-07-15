using UnityEngine;
using UnityEngine.Events;
using Unity.VisualScripting;

public class ClickRaycast : MonoBehaviour
{
    [SerializeField]
    private LayerMask _raycastLayerMask;
    [SerializeField]
    private string _coinTagName = "Coin";
    [SerializeField]
    private float _rayDistance = 100f;
    [SerializeField]
    private UnityEvent _onCoinCollected;
    private bool _isactive = true;
    public bool IsActiveset { set => _isactive = value; }
    private void Update()
    {
        if (_isactive && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _rayDistance, _raycastLayerMask))
            {
                if (hit.collider.CompareTag(_coinTagName))
                {
                    Coin coin = hit.collider.GetComponent<Coin>();
                    if (coin != null)
                    {
                        CoinCollected(coin);
                    }
                }
            }
        }
    }
}
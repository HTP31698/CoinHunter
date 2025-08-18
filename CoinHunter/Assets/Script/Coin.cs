using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody coin;

    private void Start()
    {
        coin = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("111"); 
            var player = other.GetComponent<PlayerController>();
            Destroy(gameObject);
        }

    }
}

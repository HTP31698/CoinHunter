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
            var player = other.GetComponent<PlayerController>();
            Destroy(gameObject);
        }

    }
}

using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    private Rigidbody fallob;

    private void Start()
    {
        fallob = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerController>();
            player.Die();
        }
    }
}

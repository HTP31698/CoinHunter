using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody coin;
    public GameManager gm;

    private void Start()
    {
        coin = GetComponent<Rigidbody>();
        gm = GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerController>();
            Destroy(gameObject);
            gm.SetScore();
        }

    }
}

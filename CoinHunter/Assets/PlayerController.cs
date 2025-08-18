using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(v, 0f, h);
        if(velocity.magnitude >1f)
        {
            velocity.Normalize();
        }
        velocity *= speed;

        body.linearVelocity = velocity;
    }
}

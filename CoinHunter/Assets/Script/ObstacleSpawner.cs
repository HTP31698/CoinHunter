using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject fallPrefap;

    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 1.5f;
    public Vector3 spawnPoint;


    private float interval;
    private float timer;

    private void OnEnable()
    {
        timer = 0;
        interval = Random.Range(spawnRateMin, spawnRateMax);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval)
        {
            spawnPoint = new Vector3(Random.Range(-8f, 8f), 10f, Random.Range(-8f, 8f));
            GameObject go = Instantiate(fallPrefap, spawnPoint, fallPrefap.transform.rotation);
            timer = 0;
            interval = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}

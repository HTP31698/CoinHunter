using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefap;

    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;
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

        if(timer > interval)
        {
            spawnPoint = new Vector3(Random.Range(-8f, 8f), 0.6f, Random.Range(-8f, 8f));
            GameObject go = Instantiate(coinPrefap, spawnPoint, coinPrefap.transform.rotation);
            timer = 0;
            interval = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}

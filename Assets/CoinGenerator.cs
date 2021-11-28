using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<5; i++)
        {
            float randomX = Random.Range(-4.0f, 4.0f);
            float randomZ = Random.Range(-4.0f, 4.0f);
            GameObject newCoin = Instantiate(coinPrefab) as GameObject;
            newCoin.transform.position = new Vector3(randomX, 0.6f, randomZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    float deltaTime;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        this.deltaTime = 0.0f;
        this.speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 2.0f, 0);
        this.transform.Translate(0, this.speed, 0);

        if (this.deltaTime >= 1.0f)
        {
            this.speed *= -1;
            this.deltaTime = 0.0f;
        }

        this.deltaTime += Time.deltaTime;
    }
}

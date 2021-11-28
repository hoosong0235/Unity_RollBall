using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    GameObject score;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid = gameObject.GetComponent<Rigidbody>();
        this.score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (this.rigid.velocity.z < 5.0f)
                this.rigid.velocity = new Vector3(this.rigid.velocity.x, this.rigid.velocity.y, this.rigid.velocity.z + 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (this.rigid.velocity.z > -5.0f)
                this.rigid.velocity = new Vector3(this.rigid.velocity.x, this.rigid.velocity.y, this.rigid.velocity.z - 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (this.rigid.velocity.x < 5.0f)
                this.rigid.velocity = new Vector3(this.rigid.velocity.x + 0.1f, this.rigid.velocity.y, this.rigid.velocity.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (this.rigid.velocity.x > -5.0f)
                this.rigid.velocity = new Vector3(this.rigid.velocity.x - 0.1f, this.rigid.velocity.y, this.rigid.velocity.z);
        }

        if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y == 0.5)
        {
            this.rigid.velocity = new Vector3(this.rigid.velocity.x, this.rigid.velocity.y + 5.0f, this.rigid.velocity.z);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        this.count += 1;

        this.score.GetComponent<Text>().text = "score : " + count;

        Destroy(other.gameObject);

        if (this.count == 5)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}

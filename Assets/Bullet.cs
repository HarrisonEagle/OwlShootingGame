using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 vec = player.transform.position;
        bullet.transform.position = vec;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = bullet.transform.position;
        vec.y += 0.2f;
        bullet.transform.position = vec;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }
    //segundo Comit
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            // Add your code here
            shoot();

        }

    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

}

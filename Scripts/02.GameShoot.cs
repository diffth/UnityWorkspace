using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameShoot : MonoBehaviour
{
    public GameObject cube;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject obj = Instantiate(cube, pos.position, pos.rotation);
            Destroy(obj, 2f);
        }
    }
}

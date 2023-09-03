using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Range(1, 10)]
    public float moveSpeed = 5;
    public float roteSpeed = 200;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 rot = new Vector3(0, r, 0);

        transform.Translate(dir * moveSpeed * Time.deltaTime);
        transform.Rotate(rot * roteSpeed * Time.deltaTime);
    }
}

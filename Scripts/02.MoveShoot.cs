using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShoot : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 500, 800));    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * 360 * Time.deltaTime);
    }
}

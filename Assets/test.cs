using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float rotationSpeed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        this.transform.position += Vector3.up * speed * Time.deltaTime;
    }
}

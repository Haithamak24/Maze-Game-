using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public GameObject breakBox;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnCollisionStay(Collision collision) 
    {
        if (breakBox != null) 
        {
            Instantiate(breakBox, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}

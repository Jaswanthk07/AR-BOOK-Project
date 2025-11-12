using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // Move strictly left in WORLD space (won’t depend on rotation)
        transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime);
    }
}

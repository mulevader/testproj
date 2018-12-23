using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testskriptet : MonoBehaviour
{
    int skallebank = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        skallebank++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 60, 0));
    }
}

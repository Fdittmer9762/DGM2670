using UnityEngine;
using System.Collections;

public class NotCoroutine : MonoBehaviour {

    public float timeStep = 1;
    float t = 0;
    // Update is called once per frame
    void Update()
    {

        if (t < timeStep)
        {
            GetComponent<Renderer>().material.color = Color.blue;
            transform.Translate(Vector3.forward * Time.deltaTime);

        }

        else if (t < timeStep * 2)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }


        if (t > timeStep * 2)
            t = 0;

        t += Time.deltaTime;
    }
}

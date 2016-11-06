using UnityEngine;
using System.Collections;

public class isAcorutine : MonoBehaviour
{

    delegate void DelegateType();

    DelegateType delA, delB, delC;

    void Start()
    {
        delA = Thing;
        delB = OtherThing;
        delC = OtherOtherThing;

        DelegateType delD = () =>
        {
            GetComponent<Renderer>().material.color = Color.green;
        };

        StartCoroutine(Move(Vector3.forward, delD));

        delD = Thing;
    }

    void Thing()
    {
        transform.localScale *= 2;
    }

    void OtherThing()
    {
        transform.localScale /= 2;
    }

    void OtherOtherThing()
    {
        transform.Rotate(new Vector3(0, 45, 0));
    }

    public float timeStep;

    IEnumerator Move(Vector3 dir, DelegateType thing)
    {
        float t = 0;
        float duration = timeStep;
        GetComponent<Renderer>().material.color = Color.blue;
        while (t < timeStep)
        {
            transform.Translate(dir * Time.deltaTime);
            t += Time.deltaTime;
            yield return null;
        }
        t = 0;
        GetComponent<Renderer>().material.color = Color.red;
        thing();
        yield return new WaitForSeconds(timeStep);
        Vector3 newDir = Quaternion.Euler(0, 90, 0) * dir;

        StartCoroutine(Move(newDir, thing));
    }
}

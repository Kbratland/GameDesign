using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBase : MonoBehaviour
{
Ray ray;
RaycastHit hitData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));
        Vector3 hitPosition = hitData.point;
        float hitDistance = hitData.distance;
        string tag = hitData.collider.tag;



        
    }
}

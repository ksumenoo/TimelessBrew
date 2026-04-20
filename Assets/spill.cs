using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spill : MonoBehaviour
{
    ParticleSystem myParticleSystem;

    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if(Vector3.Angle(Vector3.left, transform.forward) < 45f || Vector3.Angle(Vector3.down, transform.forward) < 45f)
        {
            myParticleSystem.Play(); 
        }
        else
        {
            myParticleSystem.Stop();
        }
    }
    private Vector3 FindEndPoint()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        Physics.Raycast(ray, out hit, 2.0f);
        Vector3 endPoint = hit.collider ? hit.point : ray.GetPoint(2.0f);
        return endPoint;

    }
    /*
    private lifetimeCalculate()
    {
        targetPosition = FindEndPoint();
        myParticleSystem.startLifetime = 0.1;
        return 0;
    }
    */
}

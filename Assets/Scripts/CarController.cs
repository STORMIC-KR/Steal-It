using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float maxTorque = 50f;
    public float steerForce = 2f;

    public WheelCollider[] wheelColliders = new WheelCollider[4];
    public Transform[] tireMeshes = new Transform[4];

    void Update()
    {
        UpdateMeshesPositions();
    }

    void FixedUpdate()
    {
        
    }

    void UpdateMeshesPositions()
    {
        for(int i = 0; i < 4; i++)
        {
            Quaternion quat;
            Vector3 pos;
            wheelColliders[i].GetWorldPose(out pos, out quat);

            tireMeshes[i].position = pos;
            tireMeshes[i].rotation = quat;
        }
    }
}

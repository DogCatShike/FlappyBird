using System;
using UnityEngine;
using FB;

public class PipelineEntity : MonoBehaviour
{
    public int id;
    public int typeID;

    public Vector3 speed;
    public Vector2 range;

    public void Ctro()
    {

    }

    public void TearDown()
    {
        Destroy(gameObject); 
    }
}
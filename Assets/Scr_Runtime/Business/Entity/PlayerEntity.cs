using System;
using UnityEngine;
using FB;

public class PlayerEntity : MonoBehaviour
{
    public int id;
    public int typeID;

    [SerializeField]Rigidbody2D rb;
    [SerializeField]Animator ani;

    public float force;
    

    public void Ctro()
    {

    }

    public void TearDown()
    {
        Destroy(gameObject);
    }
}
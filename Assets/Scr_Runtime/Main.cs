using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FB
{
    public class Main : MonoBehaviour
    {
        GameContext ctx;
        bool isTearDown = false;

        void Awake()
        {
            ctx = new GameContext();
        }

        void Update()
        {
            
        }
    }
}

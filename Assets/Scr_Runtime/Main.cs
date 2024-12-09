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
            //TODO
            ctx = new GameContext();

            ctx.assetsCore.LoadAll();

            Binding();
        }

        void Binding()
        {
            GameBusiness.Enter(ctx);
        }

        void Update()
        {
            //TODO: Move
            
            int playerLen = ctx.playerRepository.TakeAll(out PlayerEntity[] players);
            for(int i=0; i<playerLen; i++)
            {
                PlayerEntity player = players[i];
            }
        }

        void OnDestroy()
        {
            TearDown();
        }

        void OnApplicationQuit()
        {
            TearDown();
        }

        void TearDown()
        {
            if(isTearDown)
            {
                return;
            }
            isTearDown = true;
            ctx.assetsCore.UnLoadAll();
        }
    }
}

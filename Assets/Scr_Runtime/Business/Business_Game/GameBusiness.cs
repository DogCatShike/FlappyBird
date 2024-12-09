using System;
using UnityEngine;

public static class GameBusiness
{
    public static void Enter(GameContext ctx)
    {
        PlayerDomain.Spawn(ctx, 1);
        PipelineDomain.Spawn(ctx, 1);
    }
}
using System;
using UnityEngine;
using FB;

public static class GameFactory
{
    public static PlayerEntity Player_Create(GameContext ctx, int typeID)
    {
        GameObject go = ctx.assetsCore.Entity_GetPlayer();
        go = GameObject.Instantiate(go);

        PlayerEntity entity = go.GetComponent<PlayerEntity>();
        entity.Ctro();
        return entity;
    }

    public static PipelineEntity Pipeline_Create(GameContext ctx, int typeID)
    {
        GameObject go = ctx.assetsCore.Entity_GetPipeline();
        go = GameObject.Instantiate(go);

        PipelineEntity entity = go.GetComponent<PipelineEntity>();
        entity.Ctro();
        return entity;
    }
}
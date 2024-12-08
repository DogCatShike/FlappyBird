using System;
using UnityEngine;
using FB;

public static class PipelineDomain
{
    public static PipelineEntity Spawn(GameContext ctx, int typeID)
    {
        PipelineEntity entity = GameFactory.Pipeline_Create(ctx, typeID);
        ctx.pipelinerepository.Add(entity);
        Debug.Log(entity.name);
        return entity;
    }
}
using System;
using UnityEngine;
using FB;

public static class PlayerDomain
{
    public static PlayerEntity Spawn(GameContext ctx, int typeID)
    {
        PlayerEntity entity = GameFactory.Player_Create(ctx, typeID);
        ctx.playerRepository.Add(entity);
        Debug.Log(entity.name);
        return entity;
    }
}
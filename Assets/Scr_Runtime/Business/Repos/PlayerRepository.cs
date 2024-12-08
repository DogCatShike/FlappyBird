using System;
using UnityEngine;
using FB;
using System.Collections.Generic;

public class PlayerRepository
{
    Dictionary<int, PlayerEntity> all;
    PlayerEntity[] temArray;

    public PlayerRepository()
    {
        all = new Dictionary<int, PlayerEntity>();
        temArray = new PlayerEntity[1000];
    }

    public void Add(PlayerEntity entity)
    {
        all.Add(entity.id, entity);
    }

    public void Remove(PlayerEntity entity)
    {
        all.Remove(entity.id);
    }

    //TODO
}
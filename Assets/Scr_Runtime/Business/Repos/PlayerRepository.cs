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

    //获取Player？
    public int TakeAll(out PlayerEntity[] array)
    {
        if(all.Count > temArray.Length)
        {
            temArray = new PlayerEntity[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;
    }

    //返回Player
    public PlayerEntity Find(Predicate<PlayerEntity> predicate)
    {
        foreach(PlayerEntity player in all.Values)
        {
            bool isMatch = predicate(player);
            if(isMatch)
            {
                return player;
            }
        }
        return null;
    }
}
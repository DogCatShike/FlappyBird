using System;
using UnityEngine;
using FB;
using System.Collections.Generic;

public class PipelineRepository
{
    Dictionary<int, PipelineEntity> all;
    PipelineEntity[] temArray;

    public PipelineRepository()
    {
        all = new Dictionary<int, PipelineEntity>();
        temArray = new PipelineEntity[1000];
    }

    public void Add(PipelineEntity entity)
    {
        all.Add(entity.id, entity);
    }

    public void Remove(PipelineEntity entity)
    {
        all.Remove(entity.id);
    }

    //TODO
}
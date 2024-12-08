using System;
using UnityEngine;
using FB;

public class GameContext
{
    public AssetsCore assetsCore;

    //repos
    public PlayerRepository playerRepository;
    public PipelineRepository pipelinerepository;

    public GameContext()
    {
        assetsCore = new AssetsCore();

        //repos
        playerRepository = new PlayerRepository();
        pipelinerepository = new PipelineRepository();
    }
}
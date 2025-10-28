using UnityEngine;
using System;
using System.Collections.Generic;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private int _victoryScore;
    [SerializeField] private GameObject _victoryUI;

    public static CollectibleManager Instance { get; private set; }

    private List<CollectibleRespawn> _collectibles = new List<CollectibleRespawn>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void RegisterCollectible(CollectibleRespawn collectible)
    {
        if (!_collectibles.Contains(collectible))
            _collectibles.Add(collectible);
    }

    public void RespawnOneCollectible()
    {
        foreach (var collectible in _collectibles)
        {
            if (collectible.IsCollected())
            {
                collectible.Respawn();
                return;
            }
        }
    }

    public void RespawnAll()
    {
        foreach (var collectible in _collectibles)
        {
            collectible.Respawn();
        }
    }
}

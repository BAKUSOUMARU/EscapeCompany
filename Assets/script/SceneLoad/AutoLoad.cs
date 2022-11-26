using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

public class AutoLoad : SceneLoad
{

    [SerializeField]
    [Header("ÉçÅ[ÉhÇ∑ÇÈÇ‹Ç≈ÇÃéûä‘(É~Éäïb)")]
    int _delayTime = 5000;

    private CancellationTokenSource _cts = new CancellationTokenSource();
    async void Start()
    {
        await StartLoad(_cts.Token);
    }

    void Update()
    {
        if (Input.anyKey)
        {
            _cts.Cancel();
        }    
    }
    async UniTask StartLoad(CancellationToken ct = default)
    {
        try
        {
            await UniTask.Delay(_delayTime,cancellationToken: ct);
        }
        catch(System.OperationCanceledException)
        {
            throw;
        }
        finally
        {
            LoadScene();
        }
    }
}

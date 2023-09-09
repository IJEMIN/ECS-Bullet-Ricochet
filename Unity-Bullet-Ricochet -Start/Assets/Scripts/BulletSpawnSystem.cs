using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

[BurstCompile]
[UpdateBefore(typeof(TransformSystemGroup))] // TransformSystemGroup 이전에 실행하여 총알 위치가 반영 안되는 문제 해결
public partial struct BulletSpawnSystem : ISystem
{
    private Random _random; // 랜덤값 생성기

    // OnCreate는 시스템이 생성될 때 한번만 실행된다.
    public void OnCreate(ref SystemState state)
    {
        _random = new Random(999);
        state.RequireForUpdate<BulletSpawner>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var aimPoint = new float3(0, 0, 0);
        var bulletSpawner = SystemAPI.GetSingleton<BulletSpawner>();
        if (bulletSpawner.NextSpawnTime < SystemAPI.Time.ElapsedTime)
        {
           
        }
    }
}
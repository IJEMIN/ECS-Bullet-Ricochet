using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

[BurstCompile]
[UpdateAfter(typeof(BulletSpawnSystem))]
public partial struct BulletVelocitySystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<Bullet>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
       
    }
}

// [WithAll(typeof(Bullet))]
// [BurstCompile]
// public partial struct BulletVelocityJob : IJobEntity
// {
//     // 총알이 서로 충돌한 것으로 판정하는데 사용할 거리
//     private const float ReflectDistanceBetBullet = 0.1f;
//     private const float ReflectDistanceBetBulletSQ = ReflectDistanceBetBullet * ReflectDistanceBetBullet;
//
//     [ReadOnly] public NativeArray<LocalTransform> OtherBulletTransforms;
//     [ReadOnly] public NativeArray<Entity> OtherBulletEntities;
//     public float DeltaTime;
//     
//     public void Execute(Entity bulletEntity, ref LocalTransform bulletTransform, ref Movement bulletMovement)
//     {
//         var velocity = bulletMovement.Velocity;
//         var newPosition = bulletTransform.Position + velocity * DeltaTime;
//         
//         
//         bulletTransform.Position = newPosition;
//     }
// }

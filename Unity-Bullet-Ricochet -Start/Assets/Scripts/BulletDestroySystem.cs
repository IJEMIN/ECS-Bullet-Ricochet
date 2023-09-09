using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

// OnUpdate를 BulletVelocitySystem의 OnUpdate 이후에 실행
[UpdateAfter(typeof(BulletVelocitySystem))]
public partial struct BulletDestroySystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        
    }

    public void OnUpdate(ref SystemState state)
    {
      
    }
}
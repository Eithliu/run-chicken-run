using UnityEngine;

public class GoodGarbageObject : GarbageObject
{
    
    public override void PlayerHit()
    {
        Destroy(gameObject);
    }
}

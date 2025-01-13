using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public BoxCollider2D garbageCollider;
    
    void Start()
    {
        garbageCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }
}

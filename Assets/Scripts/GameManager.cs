using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected Vector2 initialPos = new Vector2(0, -4.1f);
    public static GameManager Instance { get; private set; }
    public PlayerController Player;
    public GarbageManager garbage;

    private int lives;
    private int forceLife;
    private BoxCollider2D _garbageCollider;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        Player.Spawn();  
        lives = 3;  
        forceLife = 3;
       _garbageCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        garbage.generateGoodGarbage();
        garbage.generateBadGarbage();

        // Player.OnTriggerEnter(_garbageCollider);
    }

    public void LoseLife()
    {
        if (lives > 0) {
            if (forceLife > 0) {
                lives--;
                if (lives < 1) {
                    Debug.Log("game over!");
                }
            } else {
                forceLife--;
            }
        } else {
            Debug.Log("Game over!");
        }
    }
}

using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    protected Vector2 initialPos = new Vector2(0, -4.1f);
    public static GameManager Instance { get; private set; }
    public PlayerController Player;
    public GarbageManager garbage;

    public int lives;
    private int health;

    public UIDocument UIDoc;
    private Label healthLabel;
    private Label lifeLabel;
    private Label gameOverLabel;
    private VisualElement _gameOverPanel;

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
        _gameOverPanel = UIDoc.rootVisualElement.Q<VisualElement>("GameOverPanel");
        gameOverLabel = UIDoc.rootVisualElement.Q<Label>("GameOverText");

        _gameOverPanel.style.visibility = Visibility.Hidden;
        Player.Spawn();  
        lives = 3;  
        health = 3;


        healthLabel = UIDoc.rootVisualElement.Q<Label>("healthLabel");
        lifeLabel = UIDoc.rootVisualElement.Q<Label>("lifeLabel");

        healthLabel.text = "Vous avez " + health + " points de santé";
        lifeLabel.text = lives + " vies";
    }

    void Update()
    {
        garbage.generateGoodGarbage();
        garbage.generateBadGarbage();

    }

    public void LoseLife()
    {
        var firstPart = "Vous avez ";
        var lastPart = " points de santé";
        if (lives > 1) {
            if (health > 1) {
                health--;
                if (health <=1) {
                    healthLabel.text = firstPart + health + " point de santé";
                } else {
                    healthLabel.text = firstPart + health + lastPart;
                }
            } else {
                lives--;
                if (lives <= 1) {
                    lifeLabel.text = lives + " vie";
                } else {
                    lifeLabel.text = lives + " vies";
                }
                health = 3;
                if (health <=1) {
                    healthLabel.text = firstPart + health + " point de santé";
                } else {
                    healthLabel.text = firstPart + health + lastPart;
                }
            }
        } else {
            Player.GameOver();
            _gameOverPanel.style.visibility = Visibility.Visible;
            healthLabel.text = "";
            gameOverLabel.text = "Game Over !";
        }
    }
}

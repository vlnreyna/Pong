using UnityEngine;

public class GameManager : MonoBehaviour
{   

    public static GameManager Instance;
    public int playerGoals = 0;
    public int enemyGoals = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    } 

    public void IncreasePlayerPoints()
    {
        playerGoals += 1;
    }

    public void IncreaseEnemyPoints()
    {
        enemyGoals += 1;
    }
}

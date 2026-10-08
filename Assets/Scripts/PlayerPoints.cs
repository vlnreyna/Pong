using UnityEngine;

public class PlayerPoints : MonoBehaviour
{   
    public TMPro.TMP_Text points;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = GetComponent<TMPro.TMP_Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Player: " + GameManager.Instance.playerGoals;
    }
}

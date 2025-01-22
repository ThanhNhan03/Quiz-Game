using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Scorekeeper scorekeeper;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        scorekeeper = FindAnyObjectByType<Scorekeeper>();
    }

    public void DisplayFinalScore()
    {
        finalScoreText.text = "Your Scored \n" + scorekeeper.CalculateScore() + "%";
    }
}

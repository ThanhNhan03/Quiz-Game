using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int GetCorrectAnswers()
    {
       return correctAnswers;
    }

    public void IncrementCorrectAnswer ()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}

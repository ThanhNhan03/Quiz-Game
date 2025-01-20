using UnityEngine;

[CreateAssetMenu(fileName = "Quiz Question", menuName = "Scriptable Objects/QuestionOS")]
public class QuestionOS : ScriptableObject
{
    [TextArea(3, 10)]
    [SerializeField] string question = "Enter your question";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex = 0;

    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

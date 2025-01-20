using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionOS question;
    [SerializeField] GameObject[] answerButton;
    int correctAnswerIndex;
    [SerializeField] Sprite correctAnswer;
    [SerializeField] Sprite defaultAnswer;
    void Start()
    {
        DisplayQuestion();
    }

    public void OnAnswerSelected(int index)
    {
        Image imageButton;

        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            imageButton = answerButton[index].GetComponent<Image>();
            imageButton.sprite = correctAnswer;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswerText = question.GetAnswer(correctAnswerIndex);
            questionText.text = "Incorrect! The correct answer is: \n" + correctAnswerText;
            imageButton = answerButton[correctAnswerIndex].GetComponent<Image>();
            imageButton.sprite = correctAnswer;
        }
        SetButtonState(false);
    }

    void GetNextQuestion()
    {
        SetButtonState(true);
        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();
        for (int i = 0; i < answerButton.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButton[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButton.Length; i++)
        {
            Button button = answerButton[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    void SetDefaultButtonSprites()
    {
        for (int i = 0; i < answerButton.Length; i++)
        {
            Image imageButton = answerButton[i].GetComponent<Image>();
            imageButton.sprite = defaultAnswer;
        }
    }
}

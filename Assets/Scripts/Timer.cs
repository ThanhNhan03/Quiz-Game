using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool isAnswered = false;
    float timerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnswered)
        {
            if (timerValue <= 0)
            {
                Debug.Log("Time's up!");
                isAnswered = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue <=0)
            {
                isAnswered = true;
                timerValue = timeToCompleteQuestion;
            }
        }
        Debug.Log(timerValue);
    }
}

using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float countdownTime = 30f;
    private float currentTime = 0f;
    private bool isTimerRunning = false;
    private TextMeshProUGUI timerText;

    private void Start()
    {
        timerText = GameObject.FindGameObjectWithTag("TimerText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

            // Ubah format waktu menjadi detik saja
            int seconds = Mathf.FloorToInt(currentTime % 60);

            // Tampilkan waktu di UI
            timerText.text = seconds.ToString();

            if (currentTime <= 0)
            {
                // Jika waktu habis, tampilkan "game over"
                Debug.Log("Game Over");
                isTimerRunning = false;
            }
        }
    }

    public void StartTimer()
    {
        currentTime = countdownTime;
        isTimerRunning = true;
    }
}

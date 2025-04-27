using System;
using Task_1.Scripts.Main;
using TMPro;
using UnityEngine;

namespace Task_1.Scripts.Menu_01
{
    public class ClockHandler : MonoBehaviour, IDisposable
    {
        [Header("Кнопки управления будильником")][Space]
        [SerializeField] private MinuteDownButton minuteDownButton;
        [SerializeField] private MinuteUpButton minuteUpButton;
        [SerializeField] private SecondDownButton secondDownButton;
        [SerializeField] private SecondUpButton secondUpButton;
    
        [Header("Отображение Будильника")][Space]
        [SerializeField] private TextMeshPro mainTimeText;
        [SerializeField] private TextMeshPro timeMinuteText;
        [SerializeField] private TextMeshPro timeSecondText;
        
        private int _minutes;
        private int _seconds;

        private void Awake()
        {
            _minutes = Constants.leftTimerValue;
            _seconds = Constants.rightTimerValue;
        }
    
        private void UpdateTimeDisplay()
        {
            mainTimeText.text = string.Format("{0:D2} : {1:D2}", timeMinuteText.text, timeSecondText.text);
        }
    
        
        public void IncreaseMinutes()
        {
            if (int.TryParse(timeMinuteText.text, out int timerValue))
            {
                timerValue = (timerValue >= _minutes) ? 0 : ++timerValue;
                timeMinuteText.text = timerValue.ToString("D2");
            }
            else Debug.LogWarning("Текст не является числом!");
            UpdateTimeDisplay();
        }

        public void DecreaseMinutes()
        {
            if (int.TryParse(timeMinuteText.text, out var timerValue))
            {
                timerValue = (timerValue <= 0) ? _minutes : --timerValue;
                timeMinuteText.text = timerValue.ToString("D2");
            }
            else Debug.LogWarning("Текст не является числом!");
            UpdateTimeDisplay();
        }

        public void IncreaseSeconds()
        {
            if (int.TryParse(timeSecondText.text, out var timerValue))
            {
                timerValue = (timerValue >= _seconds) ? 0 : ++timerValue;
                timeSecondText.text = timerValue.ToString("D2");
            }
            else Debug.LogWarning("Текст не является числом!");
            UpdateTimeDisplay();
        }

        public void DecreaseSeconds()
        {
            if (int.TryParse(timeSecondText.text, out var timerValue))
            {
                timerValue = (timerValue <= 0) ? _seconds : --timerValue;
                timeSecondText.text = timerValue.ToString("D2");
            }
            else Debug.LogWarning("Текст не является числом!");
            UpdateTimeDisplay();
        }

    
        private void OnEnable()
        {
            minuteDownButton.ClickMinuteDownButton += DecreaseMinutes;
            minuteUpButton.ClickMinuteUpButton += IncreaseMinutes;
            secondUpButton.ClickSecondUpButton += IncreaseSeconds;
            secondDownButton.ClickSecondDownButton += DecreaseSeconds;
        }
    
        public void Dispose()
        {
            minuteDownButton.ClickMinuteDownButton -= DecreaseMinutes;
            minuteUpButton.ClickMinuteUpButton -= IncreaseMinutes;
            secondUpButton.ClickSecondUpButton -= IncreaseSeconds;
            secondDownButton.ClickSecondDownButton -= DecreaseSeconds;
        }
    }
}

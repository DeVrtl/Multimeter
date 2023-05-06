using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private BaseValues _baseValues;

    private void Start()
    {
        CalculateVoltage();
        CalculateAmperage();
    }

    private void CalculateVoltage()
    {
        float intermediateNumber = _baseValues.Power * _baseValues.Resistance;
        intermediateNumber = Mathf.Sqrt(intermediateNumber);
        intermediateNumber = (float)Math.Round(intermediateNumber, 2);

        _baseValues.SetVoltage(intermediateNumber);
    }

    private void CalculateAmperage()
    {
        float intermediateNumber = _baseValues.Power / _baseValues.Resistance;
        intermediateNumber = Mathf.Sqrt(intermediateNumber);
        intermediateNumber = (float)Math.Round(intermediateNumber, 2);

        _baseValues.SetAmperage(intermediateNumber);
    }
}

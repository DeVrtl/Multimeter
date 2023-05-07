using UnityEngine;

public class BaseValues : MonoBehaviour
{
    public float Resistance { get; private set; } = 1000;
    public float AlternatingVoltage { get; private set; } = 0.01f;
    public float Power { get; private set; } = 400;
    public float Voltage { get; private set; }
    public float Amperage { get; private set; }

    public void SetAmperage(float amperage)
    {
        Amperage = amperage;
    }

    public void SetVoltage(float voltage)
    {
        Voltage = voltage;
    }
}

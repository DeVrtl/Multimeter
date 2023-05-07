using UnityEngine;

[RequireComponent(typeof(Voltage))]
public class VoltageHandler : Handler
{
    [SerializeField] private BaseValues _baseValues;

    private Voltage _voltage;

    private void Awake()
    {
        _voltage = GetComponent<Voltage>();
    }

    private void OnEnable()
    {
        _voltage.Passed += OnPassed;
    }
    private void OnDisable()
    {
        _voltage.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        RewriteText(_baseValues.Voltage);
    }
}
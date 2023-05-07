using UnityEngine;

[RequireComponent(typeof(AlternatingVoltage))]
public class AlternatingVoltageHandler : Handler
{
    [SerializeField] private BaseValues _baseValues;

    private AlternatingVoltage _alternatingVoltage;

    private void Awake()
    {
        _alternatingVoltage = GetComponent<AlternatingVoltage>();
    }

    private void OnEnable()
    {
        _alternatingVoltage.Passed += OnPassed;
    }

    private void OnDisable()
    {
        _alternatingVoltage.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        RewriteText(_baseValues.AlternatingVoltage);
    }
}

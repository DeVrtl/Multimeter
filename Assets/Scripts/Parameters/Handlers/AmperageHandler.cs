using UnityEngine;

[RequireComponent(typeof(Amperage))]
public class AmperageHandler : Handler
{
    [SerializeField] private BaseValues _baseValues;

    private Amperage _amperage;

    private void Awake()
    {
        _amperage = GetComponent<Amperage>();
    }

    private void OnEnable()
    {
        _amperage.Passed += OnPassed;
    }

    private void OnDisable()
    {
        _amperage.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        RewriteText(_baseValues.Amperage);
    }
}

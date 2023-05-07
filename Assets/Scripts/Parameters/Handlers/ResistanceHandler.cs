using UnityEngine;

[RequireComponent(typeof(Resistance))]
public class ResistanceHandler : Handler
{
    [SerializeField] private BaseValues _baseValues;

    private Resistance _resistance;

    private void Awake()
    {
        _resistance = GetComponent<Resistance>();
    }

    private void OnEnable()
    {
        _resistance.Passed += OnPassed;
    }
    private void OnDisable()
    {
        _resistance.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        RewriteText(_baseValues.Resistance);
    }
}

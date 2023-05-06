using UnityEngine;
using TMPro;

[RequireComponent(typeof(Voltage))]
public class VoltageHandler : MonoBehaviour
{
    [SerializeField] private BaseValues _baseValues;
    [SerializeField] private TMP_Text _multimeterDisplay;
    [SerializeField] private TMP_Text _canvas;

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
        _multimeterDisplay.text = _baseValues.Voltage.ToString();
        _canvas.text = _baseValues.Voltage.ToString();
    }
}
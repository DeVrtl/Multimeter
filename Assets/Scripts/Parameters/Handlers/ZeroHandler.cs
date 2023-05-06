using UnityEngine;
using TMPro;

[RequireComponent(typeof(Zero))]
public class ZeroHandler : MonoBehaviour
{
    [SerializeField] private float _zeroNumber = 0;
    [SerializeField] private TMP_Text _multimeterDisplay;

    private Zero _zero;

    private void Awake()
    {
        _zero = GetComponent<Zero>();
    }

    private void OnEnable()
    {
        _zero.Passed += OnPassed;
    }
    private void OnDisable()
    {
        _zero.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        _multimeterDisplay.text = _zeroNumber.ToString();
    }
}

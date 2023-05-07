using UnityEngine;

public class RegulatorRotation : MonoBehaviour
{
    [SerializeField] private float _yOffset;

    private MultimeterInputs _inputs;
    private float _mouseScrollY;

    private void Awake()
    {
        _inputs = new MultimeterInputs();

        _inputs.Regulator.MouseScrollY.performed += ctx => _mouseScrollY = ctx.ReadValue<float>();
    }

    private void OnEnable()
    {
        _inputs.Enable();
    }

    private void OnDisable()
    {
        _inputs.Disable();
    }

    private void Update()
    {
        if (_mouseScrollY > 0)
        {
            transform.Rotate(0f, _yOffset, 0f);
        }

        if (_mouseScrollY < 0)
        {
            transform.Rotate(0f, -_yOffset, 0f);
        }
    }

}

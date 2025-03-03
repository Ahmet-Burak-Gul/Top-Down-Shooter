using UnityEngine;
public class Camera_Controllar : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private float _cameraSpeed;
    [SerializeField] private Transform _target;
    private Vector3 _Distance;

    void Start()
    {
        _camera.position = new Vector3 (_target.position.x, _target.position.y, _camera.position.z);
        _Distance = _camera.position - _target.position;
    }

    void LateUpdate()
    {
        _camera.position = Vector3.Lerp(_camera.position, _target.position + _Distance, _cameraSpeed * Time.deltaTime);
    }
}

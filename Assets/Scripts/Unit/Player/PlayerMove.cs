using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public sealed class PlayerMove : MonoBehaviour
{   
    public Transform crosshair;
    [SerializeField] private float _speed;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Start()
    {
        crosshair.gameObject.SetActive(true);
    }

    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _characterController.Move(moveDir * _speed * Time.deltaTime);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 lookPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(lookPos);
            crosshair.transform.position = lookPos;
        }
    }
}
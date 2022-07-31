using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public sealed class TrajectoryRenderer : MonoBehaviour
{
    //[SerializeField] private LineRenderer _lineRenderer;

    //void Start()
    //{
    //    _lineRenderer = GetComponent<LineRenderer>();
    //}

    //public void ShowTrajectory(Vector3 origin, Vector3 speed)
    //{
    //    Vector3[] points = new Vector3[100];
    //    _lineRenderer.positionCount = points.Length;

    //    for (int i = 0; i < points.Length; i++)
    //    {
    //        float time = i + 0.1f;
    //        points[i] = origin + speed * time + Physics.gravity * time * time / 2f;
    //    }

    //    _lineRenderer.SetPositions(points);
    //}
}

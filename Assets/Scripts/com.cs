using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class com : MonoBehaviour
{
    public RectTransform compassBarTransform;

    public RectTransform objetivoMTransform;
    public RectTransform NorteMTransform;
    public RectTransform SurMTransform;

    public Transform cameraObjectTransform;
    public Transform objectiveObjectTransform;

    private void Update()
    {
        SetMarkerPosition(objetivoMTransform, objectiveObjectTransform.position);
        SetMarkerPosition(NorteMTransform, Vector3.forward * 1000);
        SetMarkerPosition(SurMTransform, Vector3.back * 1000);
    }

    private void SetMarkerPosition(RectTransform markerTransform, Vector3 worldPosition)
    {
        Vector3 direccionToTarget = worldPosition - cameraObjectTransform.position;
        float angle = Vector2.Angle(new Vector2(direccionToTarget.x, direccionToTarget.z), new Vector2(cameraObjectTransform.transform.forward.x, cameraObjectTransform.transform.forward.z));
        float compassPositionX = Mathf.Clamp(2 * angle / Camera.main.fieldOfView, -1, 1);
        markerTransform.anchoredPosition = new Vector2(compassBarTransform.rect.width / 2 * compassPositionX, 0);
    }
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class UIDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{
    public UnityAction<PointerEventData, object> _downCall;
    public UnityAction<PointerEventData, object> _beginCall;
    public UnityAction<PointerEventData, object> _dragCall;
    public UnityAction<PointerEventData, object> _endCall;
    private object mParam;
    public void SetEnable(bool isEnable)
    {
        this.enabled = isEnable;
    }

    public void SetParam(object param)
    {
        this.mParam = param;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this._downCall != null)
            this._downCall.Invoke(eventData, mParam);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (this._beginCall != null)
            this._beginCall.Invoke(eventData, mParam);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (this._dragCall != null)
            this._dragCall.Invoke(eventData, mParam);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (this._endCall != null)
            this._endCall.Invoke(eventData, mParam);
    }
}


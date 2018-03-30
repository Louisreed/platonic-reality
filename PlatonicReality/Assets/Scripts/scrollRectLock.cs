using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollRectLock : MonoBehaviour {

	private ScrollRect scroll;
	private RectTransform scrollTransform;

	void Start()
	{
		scroll = GetComponent<ScrollRect>();
		scrollTransform = GetComponent<RectTransform>();
	}

	public void CenterToItem(RectTransform obj)
	{
		float normalizePosition = scrollTransform.anchorMin.y - obj.anchoredPosition.y;
		normalizePosition += (float)obj.transform.GetSiblingIndex() / (float)scroll.content.transform.childCount;
		normalizePosition /= 1000f;
		normalizePosition = Mathf.Clamp01(1 - normalizePosition);
		scroll.verticalNormalizedPosition = normalizePosition;
		Debug.Log(normalizePosition);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

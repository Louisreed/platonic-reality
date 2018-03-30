using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VRMode : MonoBehaviour {
		
	// Use this for initialization
	void Start () {
		Device.Instance.GetViewerList();

		// find all names in the viewer list:
		IEnumerable<IViewerParameters> viewerParameters = Device.Instance.GetViewerList().GetAllViewers();

		// set Cardboard v1 viewer:
		foreach (IViewerParameters vp in viewerParameters)
			if (vp.GetName().Equals("Cardboard v1"))
				MixedRealityController.Instance.SetViewerParameters(vp);

		// now tell Vuforia that it's being put into the headset:
		MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_AR);
	}
	
	// Update is called once per frame
	void Update () {

	}
}

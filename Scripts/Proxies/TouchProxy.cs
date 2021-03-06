﻿#if UNITY_EDITOR
using System.Collections;
using UnityEditor.Experimental.EditorVR.Input;
using UnityEditor.Experimental.EditorVR.Utilities;
using UnityEngine;

namespace UnityEditor.Experimental.EditorVR.Proxies
{
	sealed class TouchProxy : TwoHandedProxyBase
	{
		public override void Awake()
		{
			base.Awake();
			m_InputToEvents = ObjectUtils.AddComponent<OVRTouchInputToEvents>(gameObject);
		}

		public override IEnumerator Start()
		{
			// Touch controllers should be spawned under a root that corresponds to the head with no offsets, since the
			// local positions of the controllers will be provided that way.
#if UNITY_EDITOR
			EditorApplication.delayCall += () =>
			{
				transform.localPosition = Vector3.zero;
			};
#else
			transform.localPosition = Vector3.zero;
#endif

			return base.Start();
		}
	}
}
#endif

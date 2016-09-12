﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.VR.Handles;

namespace UnityEngine.VR.Modules
{
	public class RayEventData : PointerEventData
	{
		/// <summary>
		/// The root from where the ray is cast
		/// </summary>
		public Transform rayOrigin { get; set; }

		/// <summary>
		/// The node associated with the ray
		/// </summary>
		public Node node { get; set; }

		public Vector3 positionDelta { get; set; }

		public Quaternion rotationDelta { get; set; }

		/// <summary>
		/// The length of the direct selection pointer
		/// </summary>
		public float pointerLength { get; set; }

		public RayEventData(EventSystem eventSystem) : base(eventSystem)
		{
		}
	}
}
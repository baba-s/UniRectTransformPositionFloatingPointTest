using NUnit.Framework;
using System;
using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class RectTransformPositionFloatingPointTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void RectTransform_の_Position_に小数点が含まれていない()
		{
			bool IsValid( GameObject gameObject )
			{
				var rectTransform = gameObject.GetComponent<RectTransform>();

				if ( rectTransform == null ) return true;

				var anchoredPosition = rectTransform.anchoredPosition;

				return
					Math.Abs( anchoredPosition.x % 1 ) < 0.00001f &&
					Math.Abs( anchoredPosition.y % 1 ) < 0.00001f
					;
			}

			AllGameObjectTester.Test( IsValid );
		}
	}
}
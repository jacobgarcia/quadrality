// Copyright © 2011-2013 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;

/// <summary>
/// Similar to UIButtonColor, but adds a 'disabled' state based on whether the collider is enabled or not.
/// </summary>

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButtonBackground : UIButtonColor
{
	/// <summary>
	/// Color that will be applied when the button is disabled.
	/// </summary>
	
	public Color disabledColor = Color.grey;
	private string value;
	private int counter = 0;
	
	/// <summary>
	/// If the collider is disabled, assume the disabled color.
	/// </summary>
	/// 

	protected override void OnEnable ()
	{
		if (isEnabled) {
			base.OnEnable ();
		} else {
			UpdateColor (false, true);
		}
	}
	
	public override void OnHover (bool isOver){ 
		if (isEnabled) {
			base.OnHover (isOver);
		}
		
	}
	
	public override void OnPress (bool isPressed) { 
		if (isEnabled) base.OnPress(isPressed); 
		isEnabled = false;
	}
	
	/// <summary>
	/// Whether the button should be enabled.
	/// </summary>
	
	public bool isEnabled
	{
		get
		{
			Collider col = GetComponent<Collider>();
			return col && col.enabled;
		}
		set
		{
			Collider col = GetComponent<Collider>();
			if (!col) return;
			
			if (col.enabled != value)
			{
				col.enabled = value;
				UpdateColor(value, false);
			}
		}
	}
	
	/// <summary>
	/// Update the button's color to either enabled or disabled state.
	/// </summary>
	
	public void UpdateColor (bool shouldBeEnabled, bool immediate)
	{
		if (tweenTarget)
		{
			if (!mStarted)
			{
				mStarted = true;
				Init();
			}
			
			Color c = shouldBeEnabled ? defaultColor : disabledColor;
			TweenColor tc = TweenColor.Begin(tweenTarget, 0.15f, c);
			
			if (immediate)
			{
				tc.color = c;
				tc.enabled = false;
			}
		}
	}

	void Update(){
		if (UIButton.thisIsEnabled) {
			isEnabled = true;
		} else {
			isEnabled = false;
			base.OnHover(false);
			base.OnPress(false);
		}
	}
}
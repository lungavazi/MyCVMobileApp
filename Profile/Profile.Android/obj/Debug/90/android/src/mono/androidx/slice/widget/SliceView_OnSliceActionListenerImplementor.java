package mono.androidx.slice.widget;


public class SliceView_OnSliceActionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.slice.widget.SliceView.OnSliceActionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSliceAction:(Landroidx/slice/widget/EventInfo;Landroidx/slice/SliceItem;)V:GetOnSliceAction_Landroidx_slice_widget_EventInfo_Landroidx_slice_SliceItem_Handler:AndroidX.Slice.Widget.SliceView/IOnSliceActionListenerInvoker, Xamarin.Android.Support.Slices.View\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Slice.Widget.SliceView+IOnSliceActionListenerImplementor, Xamarin.Android.Support.Slices.View", SliceView_OnSliceActionListenerImplementor.class, __md_methods);
	}


	public SliceView_OnSliceActionListenerImplementor ()
	{
		super ();
		if (getClass () == SliceView_OnSliceActionListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Slice.Widget.SliceView+IOnSliceActionListenerImplementor, Xamarin.Android.Support.Slices.View", "", this, new java.lang.Object[] {  });
	}


	public void onSliceAction (androidx.slice.widget.EventInfo p0, androidx.slice.SliceItem p1)
	{
		n_onSliceAction (p0, p1);
	}

	private native void n_onSliceAction (androidx.slice.widget.EventInfo p0, androidx.slice.SliceItem p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

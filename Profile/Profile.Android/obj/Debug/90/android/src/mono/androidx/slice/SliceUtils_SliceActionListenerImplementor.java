package mono.androidx.slice;


public class SliceUtils_SliceActionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.slice.SliceUtils.SliceActionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSliceAction:(Landroid/net/Uri;Landroid/content/Context;Landroid/content/Intent;)V:GetOnSliceAction_Landroid_net_Uri_Landroid_content_Context_Landroid_content_Intent_Handler:AndroidX.Slice.SliceUtils/ISliceActionListenerInvoker, Xamarin.Android.Support.Slices.View\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Slice.SliceUtils+ISliceActionListenerImplementor, Xamarin.Android.Support.Slices.View", SliceUtils_SliceActionListenerImplementor.class, __md_methods);
	}


	public SliceUtils_SliceActionListenerImplementor ()
	{
		super ();
		if (getClass () == SliceUtils_SliceActionListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Slice.SliceUtils+ISliceActionListenerImplementor, Xamarin.Android.Support.Slices.View", "", this, new java.lang.Object[] {  });
	}


	public void onSliceAction (android.net.Uri p0, android.content.Context p1, android.content.Intent p2)
	{
		n_onSliceAction (p0, p1, p2);
	}

	private native void n_onSliceAction (android.net.Uri p0, android.content.Context p1, android.content.Intent p2);

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

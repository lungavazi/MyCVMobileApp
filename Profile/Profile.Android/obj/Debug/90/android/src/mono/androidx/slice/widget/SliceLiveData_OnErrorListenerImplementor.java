package mono.androidx.slice.widget;


public class SliceLiveData_OnErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.slice.widget.SliceLiveData.OnErrorListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSliceError:(ILjava/lang/Throwable;)V:GetOnSliceError_ILjava_lang_Throwable_Handler:AndroidX.Slice.Widget.SliceLiveData/IOnErrorListenerInvoker, Xamarin.Android.Support.Slices.View\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Slice.Widget.SliceLiveData+IOnErrorListenerImplementor, Xamarin.Android.Support.Slices.View", SliceLiveData_OnErrorListenerImplementor.class, __md_methods);
	}


	public SliceLiveData_OnErrorListenerImplementor ()
	{
		super ();
		if (getClass () == SliceLiveData_OnErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Slice.Widget.SliceLiveData+IOnErrorListenerImplementor, Xamarin.Android.Support.Slices.View", "", this, new java.lang.Object[] {  });
	}


	public void onSliceError (int p0, java.lang.Throwable p1)
	{
		n_onSliceError (p0, p1);
	}

	private native void n_onSliceError (int p0, java.lang.Throwable p1);

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

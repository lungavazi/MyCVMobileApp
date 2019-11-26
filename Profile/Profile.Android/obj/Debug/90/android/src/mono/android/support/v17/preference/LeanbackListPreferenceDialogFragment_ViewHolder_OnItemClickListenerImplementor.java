package mono.android.support.v17.preference;


public class LeanbackListPreferenceDialogFragment_ViewHolder_OnItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v17.preference.LeanbackListPreferenceDialogFragment.ViewHolder.OnItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClick:(Landroid/support/v17/preference/LeanbackListPreferenceDialogFragment$ViewHolder;)V:GetOnItemClick_Landroid_support_v17_preference_LeanbackListPreferenceDialogFragment_ViewHolder_Handler:Android.Support.V17.Preferences.Leanback.LeanbackListPreferenceDialogFragment/ViewHolder/IOnItemClickListenerInvoker, Xamarin.Android.Support.v17.Preference.Leanback\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V17.Preferences.Leanback.LeanbackListPreferenceDialogFragment+ViewHolder+IOnItemClickListenerImplementor, Xamarin.Android.Support.v17.Preference.Leanback", LeanbackListPreferenceDialogFragment_ViewHolder_OnItemClickListenerImplementor.class, __md_methods);
	}


	public LeanbackListPreferenceDialogFragment_ViewHolder_OnItemClickListenerImplementor ()
	{
		super ();
		if (getClass () == LeanbackListPreferenceDialogFragment_ViewHolder_OnItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V17.Preferences.Leanback.LeanbackListPreferenceDialogFragment+ViewHolder+IOnItemClickListenerImplementor, Xamarin.Android.Support.v17.Preference.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onItemClick (android.support.v17.preference.LeanbackListPreferenceDialogFragment.ViewHolder p0)
	{
		n_onItemClick (p0);
	}

	private native void n_onItemClick (android.support.v17.preference.LeanbackListPreferenceDialogFragment.ViewHolder p0);

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

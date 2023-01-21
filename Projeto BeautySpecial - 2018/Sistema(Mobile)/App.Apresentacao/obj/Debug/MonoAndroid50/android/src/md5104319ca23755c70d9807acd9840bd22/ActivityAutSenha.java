package md5104319ca23755c70d9807acd9840bd22;


public class ActivityAutSenha
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("App.Apresentacao.ActivityAutSenha, App.Apresentacao", ActivityAutSenha.class, __md_methods);
	}


	public ActivityAutSenha ()
	{
		super ();
		if (getClass () == ActivityAutSenha.class)
			mono.android.TypeManager.Activate ("App.Apresentacao.ActivityAutSenha, App.Apresentacao", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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

package md5a9896770b549763b7bfb15dcb67ca07d;


public class Apresentacao
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
		mono.android.Runtime.register ("CamadaAcessoADados_DTO.Apresentacao, App.Apresentacao", Apresentacao.class, __md_methods);
	}


	public Apresentacao ()
	{
		super ();
		if (getClass () == Apresentacao.class)
			mono.android.TypeManager.Activate ("CamadaAcessoADados_DTO.Apresentacao, App.Apresentacao", "", this, new java.lang.Object[] {  });
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

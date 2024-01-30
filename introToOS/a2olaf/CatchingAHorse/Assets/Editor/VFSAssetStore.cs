using UnityEngine;
using UnityEditor;
using System.Collections;

using System;
using System.Reflection;

/*
 * WebWindow courtesy of Ryan Christensen Github drawcode/WebWindow.cs
 * Adapted fro use at VFS by Scott Henshaw
 * 
 */
public class WebWindow : EditorWindow {
	
	static Rect windowRect =             new Rect(100,100,800,600);
	static BindingFlags fullBinding =    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
	static StringComparison ignoreCase = StringComparison.CurrentCultureIgnoreCase;
	
    object     webView;
	// dynamic x;
	Type       webViewType;
	MethodInfo doGUIMethod;
	MethodInfo loadURLMethod;
	MethodInfo focusMethod;
	MethodInfo unFocusMethod;
	
	Vector2 resizeStartPos;
	Rect resizeStartWindowSize;
	MethodInfo dockedGetterMethod;
	
	string urlText = "http://pgwm.vfs.local";

    public: 
        // Note that the use of this. prefixing members is redundant, but added for clarity

        [MenuItem ("Window/VFS Assets")]
	    static void Load() {

		    WebWindow window = WebWindow.GetWindow<WebWindow>();
		    //window.Show();
		    window.Init();
	    }
	

	void Init() {
		//Set window rect
		this.position = windowRect;
		//Get WebView type
		this.webViewType = GetTypeFromAllAssemblies("WebView");
		//Init web view
		this.InitWebView();
		//Get docked property getter MethodInfo
		Type ewClass = typeof( EditorWindow );
        this.dockedGetterMethod = ewClass.GetProperty("docked", fullBinding ).GetGetMethod( true );
	}
	

	private void InitWebView() {

		this.webView = ScriptableObject.CreateInstance( this.webViewType );
        this.webViewType.GetMethod("InitWebView").Invoke( this.webView, new object[] {(int)position.width,(int)position.height,false});
        this.webViewType.GetMethod("set_hideFlags").Invoke( this.webView, new object[] {13});
		
		loadURLMethod = this.webViewType.GetMethod("LoadURL");
		loadURLMethod.Invoke( this.webView, new object[] {urlText});
        this.webViewType.GetMethod("SetDelegateObject").Invoke( this.webView, new object[] {this});
		
		doGUIMethod = this.webViewType.GetMethod("DoGUI");
		focusMethod = this.webViewType.GetMethod("Focus");
		unFocusMethod = this.webViewType.GetMethod("UnFocus");
		
		this.wantsMouseMove = true;
	}
	

	void OnGUI() {

		if (GUI.GetNameOfFocusedControl().Equals("urlfield")) {

			if (this.webView == null)
				return;

			unFocusMethod.Invoke( this.webView, null );
		}

		bool isDocked = false;
		if (dockedGetterMethod != null) 
			isDocked = (bool)(dockedGetterMethod.Invoke( this, null ));

		Rect webViewRect = new Rect( 0,20,position.width,position.height - ((isDocked) ? 20 : 40));
        bool mouseDownEvent = Event.current.type == EventType.MouseDown;
        bool mouseInsideView = webViewRect.Contains( Event.current.mousePosition );
        if (Event.current.isMouse && mouseDownEvent && mouseInsideView) {

			GUI.FocusControl("hidden");
			focusMethod.Invoke( webView, null );
		}
		
		//Hidden, disabled, button for taking focus away from urlfield
		GUI.enabled = false;
		GUI.SetNextControlName("hidden");
		GUI.Button( new Rect( -20,-20,5,5 ), string.Empty );
		GUI.enabled = true;
		
		//URL Label
		GUI.Label( new Rect( 0,0,30,20), "URL:" );
		
		//URL text field
		GUI.SetNextControlName("urlfield"); 
		urlText = GUI.TextField( new Rect( 30,0, position.width-30, 20 ), urlText );

        //Focus on web view if return is pressed in URL field
        bool returnKeyPressed = Event.current.keyCode == KeyCode.Return;
        bool urlfieldHasFocus = GUI.GetNameOfFocusedControl().Equals("urlfield");
        if (Event.current.isKey && returnKeyPressed && urlfieldHasFocus) {

			loadURLMethod.Invoke(webView, new object[] {urlText});
			GUI.FocusControl("hidden");
			focusMethod.Invoke( webView, null );
		}
		
		//Web view
		if(webView != null)
			doGUIMethod.Invoke( webView, new object[] { webViewRect } );
	}
	

	private void OnWebViewDirty() {

		this.Repaint();
	}
	

	public static Type GetTypeFromAllAssemblies(string typeName) {

		Assembly[] assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
		foreach(Assembly assembly in assemblies) {
			Type[] types = assembly.GetTypes();
			foreach(Type type in types) {
				if(type.Name.Equals(typeName, ignoreCase) || type.Name.Contains('+' + typeName)) //+ check for inline classes
					return type;
			}
		}
		return null;
	}
	

	void OnDestroy() {

		//Destroy web view
		webViewType.GetMethod("DestroyWebView", fullBinding).Invoke(webView, null);
	}
}
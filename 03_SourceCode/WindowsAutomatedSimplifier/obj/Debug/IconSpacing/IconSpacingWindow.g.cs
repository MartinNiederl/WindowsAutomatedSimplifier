﻿#pragma checksum "..\..\..\IconSpacing\IconSpacingWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6ADA33E6D87F0442EC851C826F03F76"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WindowsAutomatedSimplifier.IconSpacing {
    
    
    /// <summary>
    /// IconSpacingWindow
    /// </summary>
    public partial class IconSpacingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Default;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Reset;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Vertical;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VSlider;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Horizontal;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider HSlider;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyChangesBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ExpCheckBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WindowsAutomatedSimplifier;component/iconspacing/iconspacingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Default = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
            this.Default.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Reset = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
            this.Reset.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Vertical = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.VSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.Horizontal = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.HSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.ApplyChangesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\IconSpacing\IconSpacingWindow.xaml"
            this.ApplyChangesBtn.Click += new System.Windows.RoutedEventHandler(this.ApplyChangesBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ExpCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


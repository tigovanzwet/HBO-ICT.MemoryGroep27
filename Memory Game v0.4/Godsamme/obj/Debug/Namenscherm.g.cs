﻿#pragma checksum "..\..\Namenscherm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C03546EE6C0C32FF1D6D889BBCE7CFCC5EBAE04E74F944F896F14AD4E057B9E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Godsamme;
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


namespace Godsamme {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Namenscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Speler1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Namenscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Speler2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Namenscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Startbutton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Namenscherm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Backbutton;
        
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
            System.Uri resourceLocater = new System.Uri("/Godsamme;component/namenscherm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Namenscherm.xaml"
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
            this.Speler1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\Namenscherm.xaml"
            this.Speler1.GotFocus += new System.Windows.RoutedEventHandler(this.Speler1_GotFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\Namenscherm.xaml"
            this.Speler1.LostFocus += new System.Windows.RoutedEventHandler(this.Speler1_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Speler2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\Namenscherm.xaml"
            this.Speler2.GotFocus += new System.Windows.RoutedEventHandler(this.Speler2_GotFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\Namenscherm.xaml"
            this.Speler2.LostFocus += new System.Windows.RoutedEventHandler(this.Speler2_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Startbutton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Namenscherm.xaml"
            this.Startbutton.Click += new System.Windows.RoutedEventHandler(this.startbutton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Backbutton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Namenscherm.xaml"
            this.Backbutton.Click += new System.Windows.RoutedEventHandler(this.Terugbutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


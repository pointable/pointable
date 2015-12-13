﻿#pragma checksum "..\..\WindowApplicationEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4025240057FA44ED9EF001697B171F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8670
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace PointableUI {
    
    
    /// <summary>
    /// WindowApplicationEdit
    /// </summary>
    public partial class WindowApplicationEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\WindowApplicationEdit.xaml"
        internal PointableUI.WindowApplicationEdit windowApplicationEdit;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Button buttonOK;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Button buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.ListBox listBox1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Expander expanderAdvance;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Button buttonBrowse;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.TextBox textBoxfilePath;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.TextBox textBoxArguments;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.TextBox textBoxIcon;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Border border1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Image imageIcon;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.TextBox textBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowApplicationEdit.xaml"
        internal System.Windows.Controls.Button buttonBrowseIcon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pointable;component/windowapplicationedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowApplicationEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.windowApplicationEdit = ((PointableUI.WindowApplicationEdit)(target));
            
            #line 4 "..\..\WindowApplicationEdit.xaml"
            this.windowApplicationEdit.Loaded += new System.Windows.RoutedEventHandler(this.windowApplicationEdit_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonOK = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\WindowApplicationEdit.xaml"
            this.buttonOK.Click += new System.Windows.RoutedEventHandler(this.buttonOK_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WindowApplicationEdit.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBox1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.expanderAdvance = ((System.Windows.Controls.Expander)(target));
            
            #line 14 "..\..\WindowApplicationEdit.xaml"
            this.expanderAdvance.Expanded += new System.Windows.RoutedEventHandler(this.expanderAdvance_Expanded);
            
            #line default
            #line hidden
            
            #line 14 "..\..\WindowApplicationEdit.xaml"
            this.expanderAdvance.Collapsed += new System.Windows.RoutedEventHandler(this.expanderAdvance_Collapsed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WindowApplicationEdit.xaml"
            this.buttonBrowse.Click += new System.Windows.RoutedEventHandler(this.buttonBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.textBoxfilePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.textBoxArguments = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.textBoxIcon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.button1 = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.border1 = ((System.Windows.Controls.Border)(target));
            return;
            case 15:
            this.imageIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.textBoxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.buttonBrowseIcon = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\WindowApplicationEdit.xaml"
            this.buttonBrowseIcon.Click += new System.Windows.RoutedEventHandler(this.buttonBrowseIcon_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


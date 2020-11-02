﻿#pragma checksum "..\..\..\Views\AlertManagerView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "689383EC6E36854E06869188A3361CB8F1F3FE73E027CBAFA8420F0B044CCCE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AlertToCareUI.ViewModel;
using AlertToCareUI.Views;
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


namespace AlertToCareUI.Views {
    
    
    /// <summary>
    /// AlertManagerView
    /// </summary>
    public partial class AlertManagerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\AlertManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBeds;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AlertManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAlerts;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\AlertManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDisable;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\AlertManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUndoDisable;
        
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
            System.Uri resourceLocater = new System.Uri("/AlertToCareUI;component/views/alertmanagerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AlertManagerView.xaml"
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
            this.cmbBeds = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Views\AlertManagerView.xaml"
            this.cmbBeds.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbBeds_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbAlerts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Views\AlertManagerView.xaml"
            this.cmbAlerts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbAlerts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDisable = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\AlertManagerView.xaml"
            this.btnDisable.Click += new System.Windows.RoutedEventHandler(this.btnDisable_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnUndoDisable = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\AlertManagerView.xaml"
            this.btnUndoDisable.Click += new System.Windows.RoutedEventHandler(this.btnUndoDisable_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


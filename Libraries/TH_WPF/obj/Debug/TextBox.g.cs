﻿#pragma checksum "..\..\TextBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "19AB3BEF339A701FD0514DEF7922A4D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;
using TH_WPF;


namespace TH_WPF {
    
    
    /// <summary>
    /// TextBox
    /// </summary>
    public partial class TextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\TextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid root;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\TextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt;
        
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
            System.Uri resourceLocater = new System.Uri("/TH_WPF;component/textbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TextBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.root = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 45 "..\..\TextBox.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Help_MouseDown);
            
            #line default
            #line hidden
            
            #line 45 "..\..\TextBox.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Help_MouseEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\TextBox.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Help_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 165 "..\..\TextBox.xaml"
            this.txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_TextChanged);
            
            #line default
            #line hidden
            
            #line 173 "..\..\TextBox.xaml"
            this.txt.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txt_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 174 "..\..\TextBox.xaml"
            this.txt.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.txt_MouseDown);
            
            #line default
            #line hidden
            
            #line 175 "..\..\TextBox.xaml"
            this.txt.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.txt_GotMouseCapture);
            
            #line default
            #line hidden
            
            #line 176 "..\..\TextBox.xaml"
            this.txt.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txt_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 177 "..\..\TextBox.xaml"
            this.txt.LostFocus += new System.Windows.RoutedEventHandler(this.txt_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


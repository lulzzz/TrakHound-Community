﻿#pragma checksum "..\..\TableManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D4036E89A65A4DB8A146EEEA1705F94"
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
using TH_TableManager.Controls;
using TH_WPF;
using TH_WPF.LoadingAnimation;


namespace TH_TableManager {
    
    
    /// <summary>
    /// TableManager
    /// </summary>
    public partial class TableManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 265 "..\..\TableManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.Button_02 PreviousPage_BT;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\TableManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PageNumbers_STACK;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\TableManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TH_WPF.Button_02 NextPage_BT;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\TableManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RowLimit_COMBO;
        
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
            System.Uri resourceLocater = new System.Uri("/TH_TableManager;component/tablemanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TableManager.xaml"
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
            
            #line 57 "..\..\TableManager.xaml"
            ((TH_WPF.Button_02)(target)).Clicked += new TH_WPF.Button_02.Clicked_Handler(this.DropTables_Button_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 95 "..\..\TableManager.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TableList_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PreviousPage_BT = ((TH_WPF.Button_02)(target));
            
            #line 265 "..\..\TableManager.xaml"
            this.PreviousPage_BT.Clicked += new TH_WPF.Button_02.Clicked_Handler(this.PageButton_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PageNumbers_STACK = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.NextPage_BT = ((TH_WPF.Button_02)(target));
            
            #line 269 "..\..\TableManager.xaml"
            this.NextPage_BT.Clicked += new TH_WPF.Button_02.Clicked_Handler(this.PageButton_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RowLimit_COMBO = ((System.Windows.Controls.ComboBox)(target));
            
            #line 273 "..\..\TableManager.xaml"
            this.RowLimit_COMBO.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RowDisplayLimit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 284 "..\..\TableManager.xaml"
            ((TH_WPF.Button_02)(target)).Clicked += new TH_WPF.Button_02.Clicked_Handler(this.TableInfoRefresh_Button_Clicked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 368 "..\..\TableManager.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


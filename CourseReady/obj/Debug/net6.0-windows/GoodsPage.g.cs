﻿#pragma checksum "..\..\..\GoodsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6F234663F7D9E59ED5D7E98F7D6E02202167002"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseReady;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CourseReady {
    
    
    /// <summary>
    /// GoodsPage
    /// </summary>
    public partial class GoodsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListGoods;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GoodsCMB;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kolkol;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HistoryButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCartButon;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\GoodsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CourseReady;component/goodspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GoodsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListGoods = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.GoodsCMB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 45 "..\..\..\GoodsPage.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Caterory1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\GoodsPage.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Caterory2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\GoodsPage.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Caterory3);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 51 "..\..\..\GoodsPage.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Caterory4);
            
            #line default
            #line hidden
            return;
            case 7:
            this.kolkol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.HistoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\GoodsPage.xaml"
            this.HistoryButton.Click += new System.Windows.RoutedEventHandler(this.HistoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddCartButon = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\GoodsPage.xaml"
            this.AddCartButon.Click += new System.Windows.RoutedEventHandler(this.AddCartButon_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CarButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\GoodsPage.xaml"
            this.CarButton.Click += new System.Windows.RoutedEventHandler(this.CarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

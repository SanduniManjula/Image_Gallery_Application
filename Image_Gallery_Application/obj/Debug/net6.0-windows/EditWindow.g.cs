﻿#pragma checksum "..\..\..\EditWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F0C1574DF5414BA317A57130AAD5FA8E82C23C11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Image_Gallery_Application;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Image_Gallery_Application {
    
    
    /// <summary>
    /// EditWindow
    /// </summary>
    public partial class EditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas LoadingCanvas;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path selectionPath;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button crop;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bw;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button red;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button green;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blue;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button @return;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rotate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Image_Gallery_Application;component/editwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoadingCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.img = ((System.Windows.Controls.Image)(target));
            
            #line 15 "..\..\..\EditWindow.xaml"
            this.img.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\EditWindow.xaml"
            this.img.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ImageMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\EditWindow.xaml"
            this.img.MouseMove += new System.Windows.Input.MouseEventHandler(this.ImageMouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.selectionPath = ((System.Windows.Shapes.Path)(target));
            return;
            case 4:
            this.crop = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\EditWindow.xaml"
            this.crop.Click += new System.Windows.RoutedEventHandler(this.crop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bw = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\EditWindow.xaml"
            this.bw.Click += new System.Windows.RoutedEventHandler(this.bw_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.red = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\EditWindow.xaml"
            this.red.Click += new System.Windows.RoutedEventHandler(this.red_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.green = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\EditWindow.xaml"
            this.green.Click += new System.Windows.RoutedEventHandler(this.green_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.blue = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\EditWindow.xaml"
            this.blue.Click += new System.Windows.RoutedEventHandler(this.blue_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.@return = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\EditWindow.xaml"
            this.@return.Click += new System.Windows.RoutedEventHandler(this.return_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rotate = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\EditWindow.xaml"
            this.rotate.Click += new System.Windows.RoutedEventHandler(this.rotate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

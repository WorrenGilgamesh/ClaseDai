﻿#pragma checksum "..\..\Modifica.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58B18FC3614A8A064D3A50B4CB10E1F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Aspirantes;
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


namespace Aspirantes {
    
    
    /// <summary>
    /// Modifica
    /// </summary>
    public partial class Modifica : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Grado;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Ingeniería;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_modifica;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_programa;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_aspirante;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_correo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Modifica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_regreso;
        
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
            System.Uri resourceLocater = new System.Uri("/Aspirantes;component/modifica.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modifica.xaml"
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
            
            #line 9 "..\..\Modifica.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grado = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Ingeniería = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.radio1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.radio2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.radio3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.btn_modifica = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Modifica.xaml"
            this.btn_modifica.Click += new System.Windows.RoutedEventHandler(this.btn_modifica_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cb_programa = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cb_aspirante = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\Modifica.xaml"
            this.cb_aspirante.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_aspirante_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tb_correo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btn_regreso = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Modifica.xaml"
            this.btn_regreso.Click += new System.Windows.RoutedEventHandler(this.btn_regreso_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Views\Agendamento.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EDE554D09079C524F57340FA67709090374E2284"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetoCSharp.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ProjetoCSharp.Views {
    
    
    /// <summary>
    /// Agendamento
    /// </summary>
    public partial class Agendamento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProjetoCSharp.Views.Agendamento Agenda;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPerfil;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar cadData;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Agendar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mensagem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ValorBase;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock data;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label info;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mensag;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label valorbase;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\Agendamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboHorario;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetoCSharp;component/views/agendamento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Agendamento.xaml"
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
            this.Agenda = ((ProjetoCSharp.Views.Agendamento)(target));
            
            #line 8 "..\..\..\Views\Agendamento.xaml"
            this.Agenda.Loaded += new System.Windows.RoutedEventHandler(this.Agenda_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgPerfil = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.cadData = ((System.Windows.Controls.Calendar)(target));
            return;
            case 4:
            this.Agendar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\Agendamento.xaml"
            this.Agendar.Click += new System.Windows.RoutedEventHandler(this.Agendar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Mensagem = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Views\Agendamento.xaml"
            this.Mensagem.Click += new System.Windows.RoutedEventHandler(this.Mensagem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ValorBase = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.data = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.info = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.mensag = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.valorbase = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.cboHorario = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

